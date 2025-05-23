﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Core
{
    public static class ErrorConstants
    {
        internal static class Codes
        {
            internal const string SessionNotInitialized = nameof(SessionNotInitialized);
            internal const string SessionLockReadRecursion = nameof(SessionLockReadRecursion);
            internal const string SessionLockReadDisposed = nameof(SessionLockReadDisposed);
            internal const string SessionLockWriteDisposed = nameof(SessionLockWriteDisposed);
            internal const string SessionLockWriteRecursion = nameof(SessionLockWriteRecursion);
            internal const string InvalidJWT = nameof(InvalidJWT);
            internal const string OutputNotInitialized = nameof(OutputNotInitialized);
        }

        public static class Message
        {
            public const string MissingAuthContext = "Authentication needed. Please call Connect-MgGraph.";
            public const string MissingSessionProperty = "{0} is missing. Please call Connect-MgGraph then try again.";
            internal const string InvalidJWT = "Invalid JWT access token.";
            internal const string InvalidScope = "Please retry by specifying a sign-in -Audience or -TenantId to Connect-MgGraph. e.g., Connect-MgGraph -Audience 'organizations' -Scopes 'YOUR_SCOPES' -UseDeviceAuthentication.";
            internal const string NullOrEmptyParameter = "Parameter '{0}' cannot be null or empty.";
            internal const string AuthenticationTimeout = "Authentication timed out after {0} seconds due to inactivity. Please try again.";
            internal const string InvalidUserProvidedToken = "The provided access token is invalid. Set a valid access token to `-{0}` parameter and try again.";
            internal const string ExpiredUserProvidedToken = "The provided access token has expired. Set a valid access token to `-{0}` parameter and try again.";
            internal const string CertificateNotFound = "Certificate with {0} '{1}' was not found in certificate store or has expired.";
            internal const string AuthNotSupported = "{0} auth is not supported by the module. Please use client certificate or secret credential instead.";
        }
    }
}
