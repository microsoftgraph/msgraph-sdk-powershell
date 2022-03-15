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
        private readonly ReaderWriterLockSlim sessionLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
        internal ReadOnlyMemory<byte> TokenCache { get; private set; }
        public InMemoryTokenCacheOptions() : this(ReadOnlyMemory<byte>.Empty) { }
        public InMemoryTokenCacheOptions(ReadOnlyMemory<byte> token)
        {
            TokenCache = token;
        }
        protected override async Task<ReadOnlyMemory<byte>> RefreshCacheAsync()
        {
            sessionLock.EnterReadLock();
            try
            {
                return await Task.FromResult(TokenCache);
            }
            finally
            {
                sessionLock.ExitReadLock();
            }
        }

        protected override Task TokenCacheUpdatedAsync(TokenCacheUpdatedArgs tokenCacheUpdatedArgs)
        {
            sessionLock.EnterWriteLock();
            try
            {
                TokenCache = tokenCacheUpdatedArgs.UnsafeCacheData;
            }
            finally
            {
                sessionLock.ExitWriteLock();
            }
            return Task.CompletedTask;
        }

        internal void Serialize(Stream stream)
        {
            sessionLock.EnterReadLock();
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
                sessionLock.ExitReadLock();
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
