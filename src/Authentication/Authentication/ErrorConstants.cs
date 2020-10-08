// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using System;

namespace Microsoft.Graph.PowerShell.Authentication
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
        }

        internal static class Message
        {
            internal const string InvalidJWT = "Invalid JWT access token.";
            internal const string MissingAuthContext = "Authentication needed, call Connect-Graph.";
            internal const string NullOrEmptyParameter = "Parameter '{0}' cannot be null or empty.";
            internal const string MacKeyChainFailed = "{0} failed with result code {1}.";
            internal const string DeviceCodeTimeout = "Device code terminal timed-out after {0} seconds. Please try again.";
            internal const string InvalidUserProvidedToken = "The provided access token is invalid. Set a valid access token to `-{0}` parameter and try again.";
            internal const string ExpiredUserProvidedToken = "The provided access token has expired. Set a valid access token to `-{0}` parameter and try again.";
            internal const string InvalidUrlParameter = "Parameter '{0}' has an invalid endpoint URL. Please use a valid URL with a network protocol i.e. [protocol]://[resource-name].";
            internal const string InvalidNationalCloud = "Parameter `{0}` has an invalid national cloud. Use Get-MgEnvironment to get a list of valid national clouds.";
            internal const string InvalidEnvironment = "Unable to find environment with name '{0}'.";
            internal const string CannotAccessFile = "Could not {0} file at '{1}'. Please ensure you have access to this file and try again in a few minutes..";
            internal const string CannotModifyBuiltInEnvironment = "Cannot {0} built-in environment {1}.";
        }
    }
}
