using Interface;
using System.Diagnostics;
using System.IO;

namespace Business
{
    /// <summary>
    /// Wrapper for file methods
    /// </summary>
    public class FileWrapper : IFileWrapper
    {
        /// <inheritdoc/>
        public void Delete(string path)
        {
            File.Delete(path);
        }

        /// <inheritdoc/>
        public void Copy(string sourceFileName, string destFileName, bool overwrite = false)
        {
            File.Copy(sourceFileName, destFileName, overwrite);
        }

        /// <inheritdoc/>
        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        /// <inheritdoc/>
        public FileVersionInfo GetVersionInfo(string fileName)
        {
            return FileVersionInfo.GetVersionInfo(fileName);
        }

        /// <inheritdoc/>
        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }

        public Stream OpenRead(string path)
        {
            return File.OpenRead(path);
        }

        /// <inheritdoc/>
        public void WriteAllLines(string path, string[] contents)
        {
            File.WriteAllLines(path, contents);
        }

        /// <inheritdoc/>
        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        /// <inheritdoc/>
        public void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }

        /// <inheritdoc/>
        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        /// <inheritdoc/>
        public FileStream Create(string path, bool overwrite)
        {
            if (!overwrite && Exists(path))
            {
                return Open(path);
            }

            return File.Create(path);
        }

        /// <inheritdoc/>
        public FileStream Open(string path)
        {
            return File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        }
    }
}
