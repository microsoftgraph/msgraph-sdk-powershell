// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Azure.Identity;

namespace Microsoft.Graph.PowerShell.Authentication.Core.TokenCache
{
    public class InMemoryTokenCache
    {
        private InMemoryTokenCacheOptions InMemoryTokenCacheOptions { get; set; }
        protected byte[] _tokenCacheDataToFlush;
        public InMemoryTokenCache(byte[] tokenCache)
        {
            InMemoryTokenCacheOptions = new InMemoryTokenCacheOptions(tokenCache);
        }

        public InMemoryTokenCache(InMemoryTokenCacheOptions options = null)
        {
            InMemoryTokenCacheOptions = options ?? new InMemoryTokenCacheOptions();
        }
        internal void UpdateTokenDataWithoutFlush(byte[] data)
        {
            _tokenCacheDataToFlush = data;
        }

        internal byte[] ReadTokenData()
        {
            return InMemoryTokenCacheOptions.TokenCache.ToArray();
        }
        internal void FlushTokenData()
        {
            if (_tokenCacheDataToFlush != null)
            {
                InMemoryTokenCacheOptions = new InMemoryTokenCacheOptions(_tokenCacheDataToFlush);
                _tokenCacheDataToFlush = null;
            }
        }

        internal void ClearCache()
        {
            InMemoryTokenCacheOptions = new InMemoryTokenCacheOptions();
        }

        internal TokenCachePersistenceOptions GetTokenCachePersistenceOptions()
        {
            return InMemoryTokenCacheOptions;
        }

    }
}
