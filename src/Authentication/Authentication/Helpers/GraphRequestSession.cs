// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using Microsoft.Graph.PowerShell.Authentication.Cmdlets;
using Microsoft.Graph.PowerShell.Authentication.Models;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    public class GraphRequestSession
    {
        /// <summary>
        /// Gets or sets the Header property.
        /// </summary>
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or sets the content Headers when using HttpClient.
        /// </summary>
        public Dictionary<string, string> ContentHeaders { get; set; }

        /// <summary>
        /// Gets or Sets the User Agent when using HttpClient
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or Sets a User Specified JWT Token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets the AuthenticationType to be used for the current Session
        /// </summary>
        public GraphRequestAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Construct a new instance of a WebRequestSession object.
        /// </summary>
        public GraphRequestSession()
        {
            // build the headers collection
            Headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            ContentHeaders = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }
    }
}