using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;

namespace Killutter.Modules.DownloadsOrganizer
{
    internal static class Classifier
    {
        public static string Classify(string path)
        {
            byte[] header = new byte[16];

            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                stream.Read(header, 0, header.Length);
            }

            string Type = CheckSignature(header);

            if (Type == "ZIP")
                Type = InspectZip(path);

            else if (Type == "Unknown")
                Type = CheckExtension(path);

            return Type;
        }

        private static string CheckSignature(byte[] header)
        {
            if (header.Length >= 4 && header[0] == 0x25 && header[1] == 0x50 &&
                header[2] == 0x44 && header[3] == 0x46)
                return "Documents"; // %PDF

            if (header.Length >= 3 && header[0] == 0xFF && header[1] == 0xD8 && header[2] == 0xFF)
                return "Pictures"; // JPEG

            if (header.Length >= 8 && header[0] == 0x89 && header[1] == 0x50 &&
                header[2] == 0x4E && header[3] == 0x47)
                return "Pictures"; // PNG

            if (header.Length >= 3 && header[0] == 0x47 && header[1] == 0x49 && header[2] == 0x46)
                return "Pictures"; // GIF

            if (header.Length >= 3 && header[0] == 0x49 && header[1] == 0x44 && header[2] == 0x33)
                return "Audio"; // MP3 (ID3 tag)

            if (header.Length >= 2 && header[0] == 0x4D && header[1] == 0x5A)
                return "Installers"; // MZ - Windows EXE

            if (header.Length >= 3 && header[0] == 0x1F && header[1] == 0x8B)
                return "Archives"; // GZIP

            if (header.Length >= 4 && header[0] == 0x50 && header[1] == 0x4B &&
                header[2] == 0x03 && header[3] == 0x04)
                return "ZIP"; // needs inner inspection - handled separately

            return "Unknown";
        }

        private static string InspectZip(string path)
        {
            using (ZipArchive archive = ZipFile.OpenRead(path))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.StartsWith("word/"))
                        return "Documents"; // .docx

                    if (entry.FullName.StartsWith("ppt/"))
                        return "Documents"; // .pptx

                    if (entry.FullName.StartsWith("xl/"))
                        return "Documents"; // .xlsx

                    if (entry.FullName == "AndroidManifest.xml")
                        return "Installers"; // .apk

                    if (entry.FullName == "META-INF/MANIFEST.MF")
                        return "Archives"; // .jar
                }
            }

            return "Archives"; // plain zip, nothing more specific matched
        }

        private static string CheckExtension(string path)
        {
            string ext = Path.GetExtension(path).ToLower();

            if (ext == ".txt" || ext == ".csv" || ext == ".md" || ext == ".log")
                return "Text";

            if (ext == ".json" || ext == ".py" || ext == ".js")
                return "Code";

            return "Unsorted";
        }


    }
}
