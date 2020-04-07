// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    using System;
    using System.Threading;
    public class GraphSession: IGraphSession
    {
        static GraphSession _instance;
        static bool _initialized = false;
        static ReaderWriterLockSlim sessionLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
        public IAuthContext AuthContext { get; set; }
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

        public static void Initialize(Func<GraphSession> instanceCreator)
        {
            Initialize(instanceCreator, false);
        }

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
    }
}
