// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;

namespace Microsoft.Graph.PowerShell
{
    public class AuthenticationException : Exception
    {
        public AuthenticationException(string message, Exception innerException = null) : base(message, innerException)
        {
        }
    }
}
