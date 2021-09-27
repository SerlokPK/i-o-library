using Interface;
using System.Collections.Generic;
using System.IO;

namespace Business
{
    /// <summary>
    /// Wrapper for directory methods
    /// </summary>
    public class DirectoryWrapper : IDirectoryWrapper
    {
        /// <inheritdoc/>
        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern = "*", bool recursive = false)
        {
            return Directory.EnumerateFiles(path, searchPattern, recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
        }

        /// <inheritdoc/>
        public string[] GetFiles(string path, string searchPattern = "*")
        {
            return Directory.GetFiles(path, searchPattern);
        }

        /// <inheritdoc/>
        public void Delete(string path, bool recursive)
        {
            Directory.Delete(path, recursive);
        }

        /// <inheritdoc/>
        public DirectoryInfo CreateDirectory(string path)
        {
            return Directory.CreateDirectory(path);
        }
    }
}
