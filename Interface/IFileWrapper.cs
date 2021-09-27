using System.Diagnostics;
using System.IO;

namespace Interface
{
    /// <summary>
    /// Contract for file methods
    /// </summary>
    public interface IFileWrapper
    {
        /// <summary>
        /// Deletes the specified file.
        /// </summary>
        /// <param name="path">The name of the file to be deleted. Wildcard characters are not supported.</param>
        void Delete(string path);

        /// <summary>
        /// Copies a file from a source location to a destination location. 
        /// If the file with the same name already exists on a destination location, it will be overwritten.
        /// </summary>
        /// <param name="sourceFileName">Source file</param>
        /// <param name="destFileName">Destination file</param>
        /// <param name="overwrite">Boolean value that indicates if overwrite should be performed</param>
        void Copy(string sourceFileName, string destFileName, bool overwrite = false);

        /// <summary>
        /// Determines whether the specified file exists.
        /// </summary>
        /// <param name="path">The file to check.</param>
        /// <returns>true if the caller has the required permissions and path contains the name of
        ///     an existing file; otherwise, false. This method also returns false if path is
        ///     null, an invalid path, or a zero-length string. If the caller does not have sufficient
        ///     permissions to read the specified file, no exception is thrown and the method
        ///     returns false regardless of the existence of path.</returns>
        bool Exists(string path);

        /// <summary>
        /// Returns the file version info
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <returns>FileVersionInfo instance for given file</returns>
        FileVersionInfo GetVersionInfo(string fileName);

        /// <summary>
        /// Read all lines in provided file, then closes it
        /// </summary>
        /// <param name="path"></param>
        /// <returns>All lines of the file</returns>
        string ReadAllText(string path);

        /// <summary>
        /// Opens an existing file for reading
        /// </summary>
        /// <param name="path">Source to file</param>
        /// <returns>Stream</returns>
        Stream OpenRead(string path);

        /// <summary>
        /// Creates a new file, write the specified string array to the file, and then closes the file.
        /// </summary>
        /// <param name="path">Destination path</param>
        /// <param name="contents">Content to write to the file</param>
        void WriteAllLines(string path, string[] contents);

        /// <summary>
        /// Opens a text file, reads all lines of the file, and then closes the file.
        /// </summary>
        /// <param name="path">Destination path</param>
        /// <returns>A string array containing all lines of the file</returns>
        string[] ReadAllLines(string path);

        /// <summary>
        /// Opens a file, appends the specified string to the file, and then closes the file.
        /// If the file does not exist, this method creates a file, writes the specified
        /// string to the file, then closes the file.
        /// </summary>
        /// <param name="path">Destination path</param>
        /// <param name="contents">Content to write to the file</param>
        void AppendAllText(string path, string contents);

        /// <summary>
        /// Opens binary file, reads all bytes and closes it
        /// </summary>
        /// <param name="path">Destination path</param>
        /// <returns>Byte array</returns>
        byte[] ReadAllBytes(string path);

        /// <summary>
        /// Creates a new file 
        /// </summary>
        /// <param name="path">Destination path</param>
        /// <param name="overwrite">Should overwrite if a file with the same name exists</param>
        /// <returns>FileStream object</returns>
        FileStream Create(string path, bool overwrite);

        /// <summary>
        /// Open existing file and return file stream
        /// </summary>
        /// <param name="path">Destination path</param>
        /// <returns>FileStream object</returns>
        FileStream Open(string path);
    }
}
