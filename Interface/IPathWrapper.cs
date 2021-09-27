namespace Interface
{
    /// <summary>
    /// Contract for path methods
    /// </summary>
    public interface IPathWrapper
    {
        /// <summary>
        /// Combines paths into one path
        /// </summary>
        /// <param name="paths">List of strings</param>
        /// <returns>String representing concanated string</returns>
        string Combine(params string[] paths);

        /// <summary>
        /// Returns the file name of the specified path string without extension
        /// </summary>
        /// <param name="path">Source file path</param>
        /// <returns>File name without extension</returns>
        string GetFileNameWithoutExtension(string path);

        /// <summary>
        /// Returns the directory information for the specified path string
        /// </summary>
        /// <param name="path">Source path</param>
        /// <returns>Directory name</returns>
        string GetDirectoryName(string path);

        /// <summary>
        /// Returns the file name and extension of the specified path string
        /// </summary>
        /// <param name="path">Source file path</param>
        /// <returns>Name with extension</returns>
        string GetFileName(string path);

        /// <summary>
        /// Returns the absolute path for the specified path string
        /// </summary>
        /// <param name="path">Source file path</param>
        /// <returns>Absolute path</returns>
        string GetFullPath(string path);

        /// <summary>
        /// Changes existing extension on provided path
        /// </summary>
        /// <param name="path">Source file path</param>
        /// <param name="extension">New extension; specify null if you want to remove current extension</param>
        /// <returns>The modified path information. On Windows-based desktop platforms, if path is
        ///     null or an empty string (""), the path information is returned unmodified. If
        ///     extension is null, the returned string contains the specified path with its extension
        ///     removed. If path has no extension, and extension is not null, the returned path
        ///     string contains extension appended to the end of path.</returns>
        string ChangeExtension(string path, string extension);
    }
}
