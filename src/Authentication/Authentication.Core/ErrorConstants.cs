// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using System;

namespace Microsoft.Graph.PowerShell.Authentication.Core
{
    public static class ErrorConstants
    {
        internal static class Codes
        {
            internal const string SessionNotInitialized = "sessionNotInitialized";
            internal const string SessionLockReadRecursion = "sessionLockReadRecursion";
            internal const string SessionLockReadDisposed = "sessionLockReadDisposed";
            internal const string SessionLockWriteDisposed = "sessionLockWriteDisposed";
            internal const string SessionLockWriteRecursion = "sessionLockWriteRecursion";
            internal const string InvalidJWT = "invalidJWT";
            internal const string OutputNotInitialized = "outputNotInitialized";
        }

        public static class Message
        {
            public const string MissingAuthContext = "Authentication needed, call Connect-MgGraph.";
            internal const string InvalidJWT = "Invalid JWT access token.";
            internal const string InvalidScope = "Please retry by specifying a sign-in -Audience or -TenantId to Connect-MgGraph. e.g., Connect-MgGraph -Audience 'organizations' -Scopes 'YOUR_SCOPES' -UseDeviceAuthentication.";
            internal const string NullOrEmptyParameter = "Parameter '{0}' cannot be null or empty.";
            internal const string MacKeyChainFailed = "{0} failed with result code {1}.";
            internal const string AuthenticationTimeout = "Authentication timed-out after {0} seconds due to inactivity. Please try again.";
            internal const string InvalidUserProvidedToken = "The provided access token is invalid. Set a valid access token to `-{0}` parameter and try again.";
            internal const string ExpiredUserProvidedToken = "The provided access token has expired. Set a valid access token to `-{0}` parameter and try again.";
        }
    }
}
