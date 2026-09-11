// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Linq;

namespace Microsoft.Graph.PowerShell.Authentication.Core.TokenCache
{
    public class InMemoryTokenCache
    {
        private byte[] _tokenCache;
        protected byte[] _tokenCacheDataToFlush;

        public InMemoryTokenCache()
        {
            _tokenCache = Array.Empty<byte>();
        }
        public InMemoryTokenCache(byte[] tokenCache)
        {
            _tokenCache = tokenCache ?? Array.Empty<byte>();
        }

        internal void UpdateTokenDataWithoutFlush(byte[] data)
        {
            _tokenCacheDataToFlush = data;
        }

        internal byte[] ReadTokenData()
        {
            return _tokenCache.ToArray();
        }

        internal void FlushTokenData()
        {
            if (_tokenCacheDataToFlush != null)
            {
                _tokenCache = _tokenCacheDataToFlush;
                _tokenCacheDataToFlush = null;
            }
        }

        internal void ClearCache()
        {
            _tokenCache = Array.Empty<byte>();
        }
    }
}
