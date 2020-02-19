// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication
{
    public static class ErrorConstants
    {
        internal static class Codes
        {
            internal const string InvalidJWT = "invalidJWT";
        }

        internal static class Message
        {
            internal const string InvalidJWT = "Invalid JWT access token.";
        }
    }
}
