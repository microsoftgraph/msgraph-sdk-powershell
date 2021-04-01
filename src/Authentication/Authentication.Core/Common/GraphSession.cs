// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    using Microsoft.Graph.PowerShell.Authentication.Core;
    using Microsoft.Graph.PowerShell.Authentication.Interfaces;
    using System;
    using System.Security;
    using System.Threading;

    /// <summary>
    /// Contains methods to create, modify or obtain a thread safe static instance of <see cref="GraphSession"/>.
    /// </summary>
    public class GraphSession : IGraphSession
    {
        static GraphSession _instance;
        static bool _initialized = false;
        static ReaderWriterLockSlim sessionLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
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

        private byte[] msalToken;

        /// <summary>
        /// Gets or Sets a session based token.
        /// This returns an empty byte[] when token is not present.
        /// </summary>
        public byte[] MSALToken
        {
            get { return msalToken ?? new byte[0]; }
            set { msalToken = value; }
        }

        /// <summary>
        /// Gets or Sets a user provided access token for calling Microsoft Graph service.
        /// </summary>
        public SecureString UserProvidedToken { get; set; }

        /// <summary>
        /// The name of the selected Microsoft Graph profile.
        /// This defaults to v1.0-beta.
        /// </summary>
        public string SelectedProfile { get; set; } = Constants.DefaultProfile;

        /// <summary>
        /// The selected national cloud environment.
        /// </summary>
        public IGraphEnvironment Environment { get; set; }

        /// <summary>
        /// Gets an instance of <see cref="GraphSession"/>.
        /// </summary>
        public static GraphSession Instance
        {
            get
            {
                try
                {
                    sessionLock.EnterReadLock();
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
                        sessionLock.ExitReadLock();
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
                sessionLock.EnterWriteLock();
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
                    sessionLock.ExitWriteLock();
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
            Initialize(instanceCreator, false);
        }

        /// <summary>
        /// Modify the current instance of <see cref="GraphSession"/>.
        /// </summary>
        /// <param name="modifier">A func to modify the <see cref="GraphSession"/> instance.</param>
        public static void Modify(Action<GraphSession> modifier)
        {
            try
            {
                sessionLock.EnterWriteLock();
                try
                {
                    modifier(_instance);
                }
                finally
                {
                    sessionLock.ExitWriteLock();
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
                sessionLock.EnterWriteLock();
                try
                {
                    _instance = null;
                    _initialized = false;
                }
                finally
                {
                    sessionLock.ExitWriteLock();
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
    }
}
