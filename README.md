# Killutter

**Killutter kills clutter in your Downloads folder.**

It watches your Downloads folder in the background, identifies each new
file by its actual content, not its file extension, and moves it
automatically into the folder you've configured for that type. No more
manually sorting years of downloaded PDFs, installers, and screenshots.

---

## Why content, not extension?

Most "download organizer" tools sort by file extension. That's fragile:
a renamed file, a mislabeled download, or an extension-less file slips
right through. Killutter reads the actual bytes of each file (its
magic-byte signature) to determine what it really is, with a fallback
to extension only for file types that don't have a distinguishing
signature (plain text, code files, etc.). A `.zip` masquerading as a
`.docx`, or vice versa, gets sorted correctly either way.

## How it works

1. **Watch**: a `FileSystemWatcher` monitors your chosen folder
   (Downloads, by default) for new or renamed files.
2. **Classify**: each file's header bytes are checked against known
   signatures (PDF, JPEG, PNG, GIF, MP3, EXE, GZIP, ZIP) to determine
   its real type. ZIP-based formats (`.docx`, `.pptx`, `.xlsx`, `.apk`,
   `.jar`) get a second, deeper look at their internal structure to
   distinguish them from a plain `.zip`.
3. **Match**: the identified type is looked up against your
   user-defined groups, each mapping a set of file types to a
   destination folder.
4. **Move**: the file is moved to its group's folder. If the file is
   still being written (e.g. an in-progress download), Killutter
   retries with exponential backoff rather than failing outright. Name
   collisions are handled automatically with a numbered suffix.

The same pipeline also runs once at every startup, sweeping any files
already sitting in the watched folder, not just ones that arrive while
the app is running.

## Configuring groups

Killutter's settings window lets you define **groups**: a set of
recognized file types mapped to one destination folder. For example, a
"Documents" group might catch PDFs and Word files and route them to
`D:\Documents`, while a "Media" group catches images and audio and
routes them elsewhere. A given file type can only belong to one group
at a time, since Killutter *moves* files rather than copying them, and
a type can't sensibly be routed to two places at once. Any file type
that doesn't match a configured group is left alone.

## Running on startup

Killutter registers itself with Windows Task Scheduler to launch
automatically when you log in, running quietly in the background with
no visible window. It can be enabled or disabled at any time from the
settings window.

## Tech stack

- **C# / .NET 10 LTS**
- **Windows Forms**, a background app with a lightweight settings UI
- **Microsoft.Win32.TaskScheduler**, Task Scheduler COM interop for
  startup registration
- Self-contained, single-file `win-x64` publish, no separate .NET
  runtime install required

## Architecture

```
Killutter/
    Program.cs
    Modules/
        DownloadsOrganizer/
            Watcher.cs        : detects new/renamed files, delegates to Organizer
            Classifier.cs     : identifies a file's real type from its content
            Mover.cs          : moves files with lock-retry and collision handling
            Organizer.cs      : orchestrates classify, match, move
            TaskRegistrar.cs  : Task Scheduler registration
        Shared/
            Config.cs         : persisted user settings (watched folder, groups)
            Group.cs          : a type-set-to-destination mapping
            Logger.cs         : file-based logging with severity levels
    UI/
        GroupCard.cs          : a single group's card in the settings list
        ConfigForm.cs         : the settings window
        AddGroupPanel.cs      : the add/edit-group flow
```

Each component has a single, deliberate responsibility. `Watcher` only
detects events, `Classifier` only identifies file types, `Mover` only
moves files, and `Organizer` is the only thing that coordinates between
them. This separation was a consistent design principle throughout the
build; no class reaches "sideways" into a peer it doesn't own.

## Building

Requires Visual Studio 2022+ with the .NET 10 SDK and the Windows
Forms workload.

```
git clone https://github.com/saifalobaisi1/Killutter.git
```

Open `Killutter.sln` and build. To produce a distributable executable:

```
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

## Project background

Killutter was built as a systems-engineering project with an emphasis
on process, not just output. Design decisions, incremental commits,
and real end-to-end testing (including verifying the Task Scheduler
integration through actual log-off/log-on cycles, not just unit-level
checks) were treated as part of the deliverable alongside the working
app itself.

## License

MIT. See `LICENSE.txt`.
