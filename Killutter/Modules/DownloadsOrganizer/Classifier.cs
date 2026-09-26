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

            if (Type == "zip")
                Type = InspectZip(path);

            else if (Type == "unknown")
                Type = CheckExtension(path);

            return Type;
        }

        private static string CheckSignature(byte[] header)
        {
            if (header.Length >= 4 && header[0] == 0x25 && header[1] == 0x50 &&
                header[2] == 0x44 && header[3] == 0x46)
                return "pdf"; // %PDF

            if (header.Length >= 3 && header[0] == 0xFF && header[1] == 0xD8 && header[2] == 0xFF)
                return "jpeg";

            if (header.Length >= 8 && header[0] == 0x89 && header[1] == 0x50 &&
                header[2] == 0x4E && header[3] == 0x47)
                return "png";

            if (header.Length >= 3 && header[0] == 0x47 && header[1] == 0x49 && header[2] == 0x46)
                return "gif";

            if (header.Length >= 3 && header[0] == 0x49 && header[1] == 0x44 && header[2] == 0x33)
                return "mp3"; // ID3 tag

            if (header.Length >= 2 && header[0] == 0x4D && header[1] == 0x5A)
                return "exe"; // MZ - Windows EXE

            if (header.Length >= 3 && header[0] == 0x1F && header[1] == 0x8B)
                return "gzip";

            if (header.Length >= 4 && header[0] == 0x50 && header[1] == 0x4B &&
                header[2] == 0x03 && header[3] == 0x04)
                return "zip"; // needs inner inspection - handled separately

            return "unknown";
        }

        private static string InspectZip(string path)
        {
            using (ZipArchive archive = ZipFile.OpenRead(path))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.StartsWith("word/"))
                        return "docx";

                    if (entry.FullName.StartsWith("ppt/"))
                        return "pptx";

                    if (entry.FullName.StartsWith("xl/"))
                        return "xlsx";

                    if (entry.FullName == "AndroidManifest.xml")
                        return "apk";

                    if (entry.FullName == "META-INF/MANIFEST.MF")
                        return "jar";
                }
            }

            return "zip"; // plain zip, nothing more specific matched
        }

        private static string CheckExtension(string path)
        {
            string ext = Path.GetExtension(path).ToLower();

            if (ext == ".txt") return "txt";
            if (ext == ".csv") return "csv";
            if (ext == ".md") return "md";
            if (ext == ".log") return "log";
            if (ext == ".json") return "json";
            if (ext == ".py") return "py";
            if (ext == ".js") return "js";

            return "Unsorted";
        }
    }
}