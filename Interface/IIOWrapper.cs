namespace Interface
{
    /// <summary>
    /// Contract for I/O methods
    /// </summary>
    public interface IIOWrapper
    {
        /// <summary>
        /// Instance of <see cref="IFile"/>
        /// </summary>
        IFileWrapper File { get; }

        /// <summary>
        /// Instance of <see cref="IDirectory"/>
        /// </summary>
        IDirectoryWrapper Directory { get; }

        /// <summary>
        /// Instance of <see cref="IPathWrapper"/>
        /// </summary>
        IPathWrapper Path { get; }
    }
}
