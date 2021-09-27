using Interface;
using System.IO;

namespace Business
{
    /// <summary>
    /// Wrapper for path methods
    /// </summary>
    public class PathWrapper : IPathWrapper
    {
        /// <inheritdoc/>
        public string Combine(params string[] paths)
        {
            return Path.Combine(paths);
        }

        /// <inheritdoc/>
        public string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        /// <inheritdoc/>
        public string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }

        /// <inheritdoc/>
        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }

        /// <inheritdoc/>
        public string GetFullPath(string path)
        {
            return Path.GetFullPath(path);
        }

        /// <inheritdoc/>
        public string ChangeExtension(string path, string extension)
        {
            return Path.ChangeExtension(path, extension);
        }
    }
}
