// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Common
{
    using Microsoft.Graph.PowerShell.Authentication.Interfaces;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Disk data store based on System.IO APIs.
    /// </summary>
    public class DiskDataStore : IDataStore
    {
        /// <summary>
        /// Writes the given contents to the specified file.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <param name="contents">The file contents.</param>
        public void WriteFile(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }

        /// <summary>
        /// Writes the given contents to the specified file, using the specified encoding.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <param name="content">The file contents.</param>
        /// <param name="encoding">The encoding to use.</param>
        public void WriteFile(string path, string contents, Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }

        /// <summary>
        /// Writes the given binary contents to the specified file.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <param name="contents">The binary contents.</param>
        public void WriteFile(string path, byte[] contents)
        {
            File.WriteAllBytes(path, contents);
        }

        /// <summary>
        /// Returns the contents of the given file as a text string.
        /// </summary>
        /// <param name="path">The file path</param>
        /// <returns>The contents of the given file as a string.  Throws an exception if the file is not found.</returns>
        public string ReadFileAsText(string path)
        {
            return File.ReadAllText(path);
        }

        /// <summary>
        /// Returns the contents of the given file as a byte array.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The contents of the given file as a byte array.  Throws an exception if the file is not found.</returns>
        public byte[] ReadFileAsBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        /// <summary>
        /// Returns the contents of the given file as a stream.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The contents of the given file as a stream.  Throws an exception if the file is not found.</returns>
        public Stream ReadFileAsStream(string path)
        {
            return File.Open(path, FileMode.Open, FileAccess.Read);
        }

        /// <summary>
        /// Moves the file to the specified location.  Overwrites the file if it exists.
        /// </summary>
        /// <param name="oldPath">Source file path.</param>
        /// <param name="newPath">Target file path.</param>
        public void RenameFile(string oldPath, string newPath)
        {
            File.Move(oldPath, newPath);
        }

        /// <summary>
        /// Copies the given file to the target path. Overwrites the file if it exists.
        /// </summary>
        /// <param name="oldPath">Source file path.</param>
        /// <param name="newPath">Target file path.</param>
        public void CopyFile(string oldPath, string newPath)
        {
            File.Copy(oldPath, newPath, true);
        }

        /// <summary>
        /// Checks if the given file exists.
        /// </summary>
        /// <param name="path">The file path to check.</param>
        /// <returns>True if the file exists, false otherwise.</returns>
        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        /// <summary>
        /// Removes the given file.
        /// </summary>
        /// <param name="path">The path of the file to delete.</param>
        public void DeleteFile(string path)
        {
            File.Delete(path);
        }

        /// <summary>
        /// Removes the given directory.
        /// </summary>
        /// <param name="dir">The directory path.</param>
        public void DeleteDirectory(string dir)
        {
            Directory.Delete(dir, true);
        }

        /// <summary>
        /// Removes all files from the given directory.
        /// </summary>
        /// <param name="dirPath">The directory to empty.</param>
        public void EmptyDirectory(string dirPath)
        {
            foreach (var filePath in Directory.GetFiles(dirPath))
            {
                File.Delete(filePath);
            }
        }

        /// <summary>
        /// Gets the files in the given directory.
        /// </summary>
        /// <param name="sourceDirName">The directory path to check.</param>
        /// <returns>The list of file paths in the given directory.</returns>
        public string[] GetFiles(string sourceDirName)
        {
            return Directory.GetFiles(sourceDirName);
        }

        /// <summary>
        /// Gets files at the given path matching the given pattern and search options.
        /// </summary>
        /// <param name="startDirectory">The directory to list file contents.</param>
        /// <param name="filePattern">The pattern of file names to include.</param>
        /// <param name="options">File search options.</param>
        /// <returns>The path to all contained files.</returns>
        public string[] GetFiles(string startDirectory, string filePattern, SearchOption options)
        {
            return Directory.GetFiles(startDirectory, filePattern, options);
        }

        /// <summary>
        /// Gets the file system attributes for the given file.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The file system attributes associated with the file</returns>
        public FileAttributes GetFileAttributes(string path)
        {
            return File.GetAttributes(path);
        }

        /// <summary>
        /// Checks for existence of the given directory.
        /// </summary>
        /// <param name="path">The directory path to check.</param>
        /// <returns>True if the directory exists, otherwise false.</returns>
        public bool DirectoryExists(string path)
        {
            return Directory.Exists(path);
        }

        /// <summary>
        /// Creates a directory at the given path.
        /// </summary>
        /// <param name="path">The directory path.</param>
        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        /// <summary>
        /// Gets the set of directories inside the given directory path.
        /// </summary>
        /// <param name="sourceDirName">The directory to list directory contents.</param>
        public string[] GetDirectories(string sourceDirName)
        {
            return Directory.GetDirectories(sourceDirName);
        }

        /// <summary>
        /// Gets directories at the given path matching the given pattern and search options.
        /// </summary>
        /// <param name="startDirectory">The directory to list directory contents of.</param>
        /// <param name="filePattern">The pattern of directory names to include.</param>
        /// <param name="options">Directory search options.</param>
        /// <returns>The path to all contained directories.</returns>
        public string[] GetDirectories(string startDirectory, string filePattern, SearchOption options)
        {
            return Directory.GetDirectories(startDirectory, filePattern, options);
        }

        /// <summary>
        /// Opens a <see cref="FileStream"/> with shared read.
        /// </summary>
        /// <param name="path">Path to the file to open.</param>
        /// <returns>A <see cref="FileStream"/> to the specified path with shared read.</returns>
        public Stream OpenForSharedRead(string path)
        {
            return File.Open(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
        }

        /// <summary>
        /// Opens a <see cref="FileStream"/> with exclusive write.
        /// </summary>
        /// <param name="path">Path to the file to open.</param>
        /// <returns>A <see cref="FileStream"/> to the specified path with exclusive write.</returns>
        public Stream OpenForExclusiveWrite(string path)
        {
            return File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
        }
    }
}
