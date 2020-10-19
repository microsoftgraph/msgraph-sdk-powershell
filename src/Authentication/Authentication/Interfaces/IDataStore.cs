// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Interfaces
{
    using System.IO;
    using System.Text;

    /// <summary>
    /// An interface for a file system.
    /// </summary>
    public interface IDataStore
    {
        /// <summary>
        /// Writes the given contents to the specified file.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <param name="contents">The file contents.</param>
        void WriteFile(string path, string contents);

        /// <summary>
        /// Writes the given contents to the specified file, using the specified encoding.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <param name="content">The file contents.</param>
        /// <param name="encoding">The encoding to use.</param>
        void WriteFile(string path, string content, Encoding encoding);

        /// <summary>
        /// Writes the given binary contents to the specified file.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <param name="contents">The binary contents.</param>
        void WriteFile(string path, byte[] contents);

        /// <summary>
        /// Returns the contents of the given file as a text string.
        /// </summary>
        /// <param name="path">The file path</param>
        /// <returns>The contents of the given file as a string.  Throws an exception if the file is not found.</returns>
        string ReadFileAsText(string path);

        /// <summary>
        /// Returns the contents of the given file as a byte array.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The contents of the given file as a byte array.  Throws an exception if the file is not found.</returns>
        byte[] ReadFileAsBytes(string path);

        /// <summary>
        /// Returns the contents of the given file as a stream.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The contents of the given file as a stream.  Throws an exception if the file is not found.</returns>
        Stream ReadFileAsStream(string path);

        /// <summary>
        /// Moves the file to the specified location.  Overwrites the file if it exists.
        /// </summary>
        /// <param name="oldPath">Source file path.</param>
        /// <param name="newPath">Target file path.</param>
        void RenameFile(string oldPath, string newPath);

        /// <summary>
        /// Copies the given file to the target path. Overwrites the file if it exists.
        /// </summary>
        /// <param name="oldPath">Source file path.</param>
        /// <param name="newPath">Target file path.</param>
        void CopyFile(string oldPath, string newPath);

        /// <summary>
        /// Checks if the given file exists.
        /// </summary>
        /// <param name="path">The file path to check.</param>
        /// <returns>True if the file exists, false otherwise.</returns>
        bool FileExists(string path);

        /// <summary>
        /// Removes the given file.
        /// </summary>
        /// <param name="path">The path of the file to delete.</param>
        void DeleteFile(string path);

        /// <summary>
        /// Removes the given directory.
        /// </summary>
        /// <param name="dir">The directory path.</param>
        void DeleteDirectory(string dir);

        /// <summary>
        /// Removes all files from the given directory.
        /// </summary>
        /// <param name="dirPath">The directory to empty.</param>
        void EmptyDirectory(string dirPath);

        /// <summary>
        /// Checks for the existence of the given directory.
        /// </summary>
        /// <param name="path">The directory path to check.</param>
        /// <returns>True if the directory exists, otherwise false.</returns>
        bool DirectoryExists(string path);

        /// <summary>
        /// Creates a directory at the given path.
        /// </summary>
        /// <param name="path">The directory path.</param>
        void CreateDirectory(string path);

        /// <summary>
        /// Gets the set of directories inside the given directory path.
        /// </summary>
        /// <param name="sourceDirName">The directory to list directory contents.</param>
        string[] GetDirectories(string sourceDirName);

        /// <summary>
        /// Gets directories at the given path matching the given pattern and search options.
        /// </summary>
        /// <param name="startDirectory">The directory to list directory contents of.</param>
        /// <param name="filePattern">The pattern of directory names to include.</param>
        /// <param name="options">Directory search options.</param>
        /// <returns>The path to all contained directories.</returns>
        string[] GetDirectories(string startDirectory, string filePattern, SearchOption options);

        /// <summary>
        /// Gets the files in the given directory.
        /// </summary>
        /// <param name="sourceDirName">The directory path to check.</param>
        /// <returns>The list of file paths in the given directory.</returns>
        string[] GetFiles(string sourceDirName);

        /// <summary>
        /// Gets files at the given path matching the given pattern and search options.
        /// </summary>
        /// <param name="startDirectory">The directory to list file contents.</param>
        /// <param name="filePattern">The pattern of file names to include.</param>
        /// <param name="options">File search options.</param>
        /// <returns>The path to all contained files.</returns>
        string[] GetFiles(string startDirectory, string filePattern, SearchOption options);

        /// <summary>
        /// Gets the file system attributes for the given file.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The file system attributes associated with the file</returns>
        FileAttributes GetFileAttributes(string path);

        /// <summary>
        /// Opens a <see cref="FileStream"/> with shared read.
        /// </summary>
        /// <param name="path">Path to the file to open.</param>
        /// <returns>A <see cref="FileStream"/> to the specified path with shared read.</returns>
        Stream OpenForSharedRead(string path);

        /// <summary>
        /// Opens a <see cref="FileStream"/> with exclusive write.
        /// </summary>
        /// <param name="path">Path to the file to open.</param>
        /// <returns>A <see cref="FileStream"/> to the specified path with exclusive write.</returns>
        Stream OpenForExclusiveWrite(string path);
    }
}
