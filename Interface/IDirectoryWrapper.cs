using System.Collections.Generic;
using System.IO;

namespace Interface
{
    /// <summary>
    /// Contract for directory methods
    /// </summary>
    public interface IDirectoryWrapper
    {
        /// <summary>
        /// Check if directory exists
        /// </summary>
        /// <param name="path">Path to the directory</param>
        /// <returns>Boolean value indicating if directory exists on the given path</returns>
        bool Exists(string path);

        /// <summary>
        /// Get IEnumerable collection of files in directory
        /// </summary>
        /// <param name="path">Path to the directory</param>
        /// <param name="searchPattern">Search pattern</param>
        /// <param name="recursive">Should include all sub directories</param>
        /// <returns>IEnumerable collection of found files</returns>
        IEnumerable<string> EnumerateFiles(string path, string searchPattern = "*", bool recursive = false);

        /// <summary>
        /// Get file array from directory which names search pattern
        /// </summary>
        /// <param name="path">Path to the directory</param>
        /// <param name="searchPattern">Search pattern</param>
        /// <returns>Array of found files</returns>
        string[] GetFiles(string path, string searchPattern = "*");

        /// <summary>
        /// Deletes specified directory.
        /// </summary>
        /// <param name="path">Destination path</param>
        /// <param name="recursive">Flag indiciating if all sub directories should recursively be deleted</param>
        void Delete(string path, bool recursive);

        /// <summary>
        /// Creates directory in specified path
        /// </summary>
        /// <param name="path">Destination path</param>
        /// <returns>Directory info object</returns>
        DirectoryInfo CreateDirectory(string path);
    }
}
