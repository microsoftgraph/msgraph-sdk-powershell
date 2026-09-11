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
    internal class InMemoryTokenCacheOptions : UnsafeTokenCacheOptions
    {
        private readonly ReaderWriterLockSlim _sessionLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
        private readonly InMemoryTokenCache _tokenCache;

        public InMemoryTokenCacheOptions(InMemoryTokenCache tokenCache)
        {
            _tokenCache = tokenCache;
        }

        protected override async Task<TokenCacheData> RefreshCacheAsync(TokenCacheRefreshArgs args, CancellationToken cancellationToken = default)
        {
            _sessionLock.EnterReadLock();
            try
            {
                return await Task.FromResult(new TokenCacheData(_tokenCache.ReadTokenData())).ConfigureAwait(false);
            }
            finally
            {
                _sessionLock.ExitReadLock();
            }
        }

        protected override async Task<ReadOnlyMemory<byte>> RefreshCacheAsync()
        {
            _sessionLock.EnterReadLock();
            try
            {
                return await Task.FromResult<ReadOnlyMemory<byte>>(_tokenCache.ReadTokenData()).ConfigureAwait(false);
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
                _tokenCache.UpdateTokenDataWithoutFlush(tokenCacheUpdatedArgs.UnsafeCacheData.ToArray());
                _tokenCache.FlushTokenData();
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
                byte[] tokenCache = _tokenCache.ReadTokenData();
                if (tokenCache.Length > 0)
                {
                    stream.Write(tokenCache, 0, tokenCache.Length);
                }
            }
            finally
            {
                _sessionLock.ExitReadLock();
            }
        }

    }
}
