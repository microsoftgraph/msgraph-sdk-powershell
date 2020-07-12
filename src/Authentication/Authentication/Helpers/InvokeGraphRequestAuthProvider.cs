// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Management.Automation.Language;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    public class InvokeGraphRequestAuthProvider : IAuthenticationProvider
    {
        private readonly GraphRequestSession _session;

        public InvokeGraphRequestAuthProvider(GraphRequestSession session)
        {
            _session = session;
        }

        public Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            var authenticationHeader = new AuthenticationHeaderValue("Bearer", new NetworkCredential(string.Empty, _session.Token).Password);
            request.Headers.Authorization = authenticationHeader;
            return Task.CompletedTask;
        }
    }
}
