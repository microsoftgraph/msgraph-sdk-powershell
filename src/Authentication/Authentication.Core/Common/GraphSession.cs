// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Core;
using Microsoft.Graph.PowerShell.Authentication.Core.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Core.TokenCache;
using Microsoft.Graph.PowerShell.Authentication.Interfaces;
using System;
using System.Collections;
using System.Net.Http;
using System.Threading;

namespace Microsoft.Graph.PowerShell.Authentication
{
    /// <summary>
    /// Contains methods to create, modify or obtain a thread safe static instance of <see cref="GraphSession"/>.
    /// </summary>
    public class GraphSession : IGraphSession
    {
        static GraphSession _instance;
        static bool _initialized = false;
        static readonly ReaderWriterLockSlim _sessionLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
        internal Guid _graphSessionId;

        // Checks if an instance of <see cref="GraphSession"/> exists.
        public static bool Exists { get { return _initialized; } }

        /// <summary>
        /// Gets or Sets <see cref="IAuthContext"/>.
        /// </summary>
        public IAuthContext AuthContext { get; set; }

        /// <summary>
        /// Gets or sets <see cref="IDataStore"/>.
        /// </summary>
        public IDataStore DataStore { get; set; }

        /// <summary>
        /// Holds in-memory token cache from Azure.Identity for the lifetime of a precess.
        /// </summary>
        public InMemoryTokenCache InMemoryTokenCache { get; set; }

        /// <summary>
        /// The selected national cloud environment.
        /// </summary>
        public IGraphEnvironment Environment { get; set; }

        /// <summary>
        /// Gets or Sets <see cref="IRequestContext"/>.
        /// </summary>
        public IRequestContext RequestContext { get; set; }

        /// <summary>
        /// Stores the user's Graph options.
        /// </summary>
        public IGraphOption GraphOption { get; set; }

        /// <summary>
        /// Temporarily stores the user's Graph request details such as Method and Uri. Essential as part of the Proof of Possession efforts.
        /// </summary>
        public IGraphRequestProofofPossession GraphRequestProofofPossession { get; set; }

        /// <summary>
        /// Represents a collection of Microsoft Graph PowerShell meta-info.
        /// </summary>
        public Hashtable[] MgCommandMetadata { get; set; }

        /// <summary>
        /// Represents a collection of Microsoft Graph PowerShell command names mapped to legacy commands.
        /// </summary>
        public Hashtable[] MgLegacyCommandMapping { get; set; }

        public HttpClient GraphHttpClient { get; set; }

        /// <summary>
        /// Gets an instance of <see cref="GraphSession"/>.
        /// </summary>
        public static GraphSession Instance
        {
            get
            {
                try
                {
                    _sessionLock.EnterReadLock();
                    try
                    {
                        if (null == _instance)
                        {
                            throw new InvalidOperationException(ErrorConstants.Codes.SessionNotInitialized);
                        }
                        return _instance;
                    }
                    finally
                    {
                        _sessionLock.ExitReadLock();
                    }
                }
                catch (LockRecursionException lockException)
                {
                    throw new InvalidOperationException(ErrorConstants.Codes.SessionLockReadRecursion, lockException);
                }
                catch (ObjectDisposedException disposedException)
                {
                    throw new InvalidOperationException(ErrorConstants.Codes.SessionLockReadDisposed, disposedException);
                }
            }
        }

        /// <summary>
        /// Creates a new GraphSession.
        /// </summary>
        public GraphSession()
        {
            _graphSessionId = Guid.NewGuid();
        }

        /// <summary>
        /// Initialize <see cref="GraphSession"/>.
        /// </summary>
        /// <param name="instanceCreator">A func to create an instance.</param>
        /// <param name="overwrite">If true, overwrite the current instance. Otherwise do not initialize.</param>
        public static void Initialize(Func<GraphSession> instanceCreator, bool overwrite)
        {
            try
            {
                _sessionLock.EnterWriteLock();
                try
                {
                    if (overwrite || !_initialized)
                    {
                        _instance = instanceCreator();
                        _initialized = true;
                    }
                }
                finally
                {
                    _sessionLock.ExitWriteLock();
                }
            }
            catch (LockRecursionException lockException)
            {
                throw new InvalidOperationException(ErrorConstants.Codes.SessionLockWriteRecursion, lockException);
            }
            catch (ObjectDisposedException disposedException)
            {
                throw new InvalidOperationException(ErrorConstants.Codes.SessionLockWriteDisposed, disposedException);
            }
        }

        /// <summary>
        /// Initialize the current instance if none exists.
        /// </summary>
        /// <param name="instanceCreator">A func to create an instance.</param>
        public static void Initialize(Func<GraphSession> instanceCreator)
        {
            Initialize(instanceCreator, overwrite: false);
        }

        /// <summary>
        /// Modify the current instance of <see cref="GraphSession"/>.
        /// </summary>
        /// <param name="modifier">A func to modify the <see cref="GraphSession"/> instance.</param>
        public static void Modify(Action<GraphSession> modifier)
        {
            try
            {
                _sessionLock.EnterWriteLock();
                try
                {
                    modifier(_instance);
                }
                finally
                {
                    _sessionLock.ExitWriteLock();
                }
            }
            catch (LockRecursionException lockException)
            {
                throw new InvalidOperationException(ErrorConstants.Codes.SessionLockWriteRecursion, lockException);
            }
            catch (ObjectDisposedException disposedException)
            {
                throw new InvalidOperationException(ErrorConstants.Codes.SessionLockWriteDisposed, disposedException);
            }
        }

        /// <summary>
        /// Resets the current instance of <see cref="GraphSession"/> to initial state.
        /// </summary>
        public static void Reset()
        {
            try
            {
                _sessionLock.EnterWriteLock();
                try
                {
                    _instance = null;
                    _initialized = false;
                }
                finally
                {
                    _sessionLock.ExitWriteLock();
                }
            }
            catch (LockRecursionException lockException)
            {
                throw new InvalidOperationException(ErrorConstants.Codes.SessionLockWriteRecursion, lockException);
            }
            catch (ObjectDisposedException disposedException)
            {
                throw new InvalidOperationException(ErrorConstants.Codes.SessionLockWriteDisposed, disposedException);
            }
        }

        private IPSGraphOutputWriter _outputWriter;
        /// <summary>
        /// Provides Access to output methods provided by the Cmdlet
        /// </summary>
        public IPSGraphOutputWriter OutputWriter
        {
            get
            {
                if (_outputWriter == null)
                {
                    throw new InvalidOperationException(ErrorConstants.Codes.OutputNotInitialized);
                }
                return _outputWriter;
            }
            set => _outputWriter = value;
        }
    }
}
