// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Azure.Identity;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Core.TokenCache
{
    public class InMemoryTokenCacheOptions : UnsafeTokenCacheOptions
    {
        private readonly ReaderWriterLockSlim _sessionLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
        internal ReadOnlyMemory<byte> TokenCache { get; private set; }
        public InMemoryTokenCacheOptions() : this(ReadOnlyMemory<byte>.Empty) { }
        public InMemoryTokenCacheOptions(ReadOnlyMemory<byte> token)
        {
            TokenCache = token;
        }
        protected override async Task<ReadOnlyMemory<byte>> RefreshCacheAsync()
        {
            _sessionLock.EnterReadLock();
            try
            {
                return await Task.FromResult(TokenCache);
            }
            finally
            {
                _sessionLock.ExitReadLock();
            }
        }

        protected override Task TokenCacheUpdatedAsync(TokenCacheUpdatedArgs tokenCacheUpdatedArgs)
        {
            _sessionLock.EnterWriteLock();
            try
            {
                TokenCache = tokenCacheUpdatedArgs.UnsafeCacheData;
            }
            finally
            {
                _sessionLock.ExitWriteLock();
            }
            return Task.CompletedTask;
        }

        internal void Serialize(Stream stream)
        {
            _sessionLock.EnterReadLock();
            try
            {
                if (!TokenCache.IsEmpty)
                {
                    var bytes = TokenCache.ToArray();
                    stream.Write(bytes, 0, bytes.Length);
                }
            }
            finally
            {
                _sessionLock.ExitReadLock();
            }
        }

        internal static InMemoryTokenCacheOptions Deserialize(Stream stream)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                var token = memoryStream.ToArray();
                return new InMemoryTokenCacheOptions(token);
            }
        }
    }
}
