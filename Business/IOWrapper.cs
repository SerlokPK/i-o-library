using Interface;

namespace Business
{
    /// <summary>
    /// Wrapper for I/O methods
    /// </summary>
    public class IOWrapper : IIOWrapper
    {
        private readonly IFileWrapper _fileWrapper;
        private readonly IDirectoryWrapper _directoryWrapper;
        private readonly IPathWrapper _pathWrapper;

        /// <summary>
        /// Constructor
        /// </summary>
        public IOWrapper()
        {
            _fileWrapper = new FileWrapper();
            _directoryWrapper = new DirectoryWrapper();
            _pathWrapper = new PathWrapper();
        }

        /// <inheritdoc/>
        public IFileWrapper File => _fileWrapper;

        /// <inheritdoc/>
        public IDirectoryWrapper Directory => _directoryWrapper;

        /// <inheritdoc/>
        public IPathWrapper Path => _pathWrapper;
    }
}
