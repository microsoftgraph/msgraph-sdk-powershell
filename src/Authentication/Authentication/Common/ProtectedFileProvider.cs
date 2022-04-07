// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Authentication.Interfaces;
using System;
using System.IO;
using System.Text;
using System.Threading;

namespace Microsoft.Graph.PowerShell.Authentication.Common
{
    public enum FileProtection
    {
        SharedRead,
        ExclusiveWrite
    }

    /// <summary>
    /// Provides protected access to a shared file.
    /// The file can be accessed in ReadOnly or ReadWrite mode.
    /// This class MUST be disposed by the caller.
    /// </summary>
    public abstract class ProtectedFileProvider : IFileProvider, IDisposable
    {
        protected Stream _stream;
        public const int MaxTries = 30;
        static readonly TimeSpan RetryInterval = TimeSpan.FromMilliseconds(500);
        public string FilePath { get; set; }
        protected IDataStore DataStore { get; set; }

        /// <summary>
        /// Use a named Mutex to prevent cross-process file I/O.
        /// </summary>
        /// <returns></returns>
        private static readonly Mutex _initializationLock = new Mutex(false, @"Local\GraphPowerShellProtectedFileProviderInit");

        /// <summary>
        /// A stream for the file provider.
        /// </summary>
        public Stream Stream
        {
            get
            {
                if (_stream == null)
                {
                    InitializeStream();
                }

                return _stream;
            }
        }

        /// <summary>
        /// Initializes a stream for the file provider.
        /// </summary>
        protected virtual void InitializeStream()
        {
            _initializationLock.WaitOne();
            try
            {
                if (_stream == null)
                {
                    Stream stream;
                    if (!TryGetStreamLock(AcquireLock, FilePath, out stream))
                    {
                        throw new UnauthorizedAccessException(ErrorConstants.Message.CannotAccessFile.FormatCurrentCulture("acquire access to", FilePath));
                    }
                    _stream = stream;
                }
            }
            finally
            {
                _initializationLock.ReleaseMutex();
            }
        }

        protected abstract Stream AcquireLock(string filePath);

        /// <summary>
        /// Creates a reader for the stream associated with the file provider.
        /// </summary>
        /// <returns>A <see cref="StreamReader"/>.</returns>
        public StreamReader CreateReader()
        {
            if (Stream == null || !Stream.CanRead || !Stream.CanSeek)
            {
                throw new IOException(ErrorConstants.Message.CannotAccessFile.FormatCurrentCulture("read", FilePath));
            }

            Stream.Seek(0, SeekOrigin.Begin);
            return new StreamReader(Stream, Encoding.UTF8);
        }

        /// <summary>
        /// Creates a writer for the stream associated with the file provider.
        /// </summary>
        /// <returns></returns>
        public StreamWriter CreateWriter()
        {
            if (Stream == null || !Stream.CanWrite || !Stream.CanSeek)
            {
                throw new IOException(ErrorConstants.Message.CannotAccessFile.FormatCurrentCulture("write to", FilePath));
            }

            Stream.Seek(0, SeekOrigin.Begin);
            return new StreamWriter(Stream, Encoding.UTF8);
        }

        private bool TryGetStreamLock(Func<string, Stream> acquireLock, string filePath, out Stream stream)
        {
            stream = null;
            int tries = 0;
            do
            {
                try
                {
                    stream = acquireLock(filePath);
                }
                catch (IOException)
                {
                    tries++;
                    Thread.Sleep(RetryInterval);
                }
            }
            while (tries <= MaxTries && stream == null);
            return stream != null;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                var stream = Interlocked.Exchange(ref _stream, null);
                if (stream != null)
                {
                    FileStream file = stream as FileStream;
                    if (file != null)
                    {
                        file.Flush(true);
                    }
                    else
                    {
                        stream.Flush();
                    }

                    stream.Close();
                }
            }
        }

        /// <summary>
        /// Disposes the file and file lock. The caller MUST dispose.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }

        /// <summary>
        /// Create a <see cref="ProtectedFileProvider"/> with protected access using the given protection level.
        /// </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <param name="protectionLevel">The <see cref="FileProtection"/> level for the file.</param>
        /// <param name="dataStore">The <see cref="IDataStore"/> to access.</param>
        /// <returns>A <see cref="ProtectedFileProvider"/> with specified access to the file.</returns>
        public static ProtectedFileProvider CreateFileProvider(string filePath, FileProtection protectionLevel, IDataStore dataStore)
        {
            if (null == dataStore)
            {
                throw new ArgumentNullException(nameof(dataStore), "IDataStore cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentOutOfRangeException(nameof(filePath), "A valid file path must be provided.");
            }

            ProtectedFileProvider provider;
            switch (protectionLevel)
            {
                case FileProtection.ExclusiveWrite:
                    provider = new ExclusiveWriteFileProvider();
                    break;
                default:
                    provider = new SharedReadOnlyFileProvider();
                    break;
            }

            provider.DataStore = dataStore;
            provider.FilePath = filePath;
            return provider;
        }

        /// <summary>
        /// Create a <see cref="ProtectedFileProvider"/> with protected access using the given protection level.
        /// </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <param name="protectionLevel">The <see cref="FileProtection"/> level for the file.</param>
        /// <returns>A <see cref="ProtectedFileProvider"/> with specified access to the file.</returns>
        public static ProtectedFileProvider CreateFileProvider(string filePath, FileProtection protectionLevel = FileProtection.SharedRead)
        {
            return CreateFileProvider(filePath, protectionLevel, GraphSession.Instance.DataStore);
        }

        /// <summary>
        /// A <see cref="ProtectedFileProvider"/> with shared read only access to the file.
        /// </summary>
        private class SharedReadOnlyFileProvider : ProtectedFileProvider
        {
            protected override Stream AcquireLock(string filePath)
            {
                return DataStore.OpenForSharedRead(filePath);
            }
        }

        /// <summary>
        /// A <see cref="ProtectedFileProvider"/> with exclusive write access to the file.
        /// </summary>
        private class ExclusiveWriteFileProvider : ProtectedFileProvider
        {
            protected override Stream AcquireLock(string filePath)
            {
                return DataStore.OpenForExclusiveWrite(filePath);
            }
        }
    }
}
