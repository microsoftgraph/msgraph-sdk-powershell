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
            internal const string InvokeGraphHttpResponseException = nameof(InvokeGraphHttpResponseException);
            internal const string InvokeGraphContentTypeException = nameof(InvokeGraphContentTypeException);
            internal const string InvokeGraphRequestInvalidHost = nameof(InvokeGraphRequestInvalidHost);
            internal const string InvokeGraphRequestSessionConflictException = nameof(InvokeGraphRequestSessionConflictException);
            internal const string InvokeGraphRequestBodyMissingWhenMethodIsSpecified = nameof(InvokeGraphRequestBodyMissingWhenMethodIsSpecified);
            internal const string InvokeGraphRequestOutFileMissingException = nameof(InvokeGraphRequestOutFileMissingException);
            internal const string InvokeGraphRequestAuthenticationTokenConflictException = nameof(InvokeGraphRequestAuthenticationTokenConflictException);
            internal const string InvokeGraphRequestAuthenticationCredentialNotSuppliedException = nameof(InvokeGraphRequestAuthenticationCredentialNotSuppliedException);
            internal const string InvokeGraphRequestBodyConflictException = nameof(InvokeGraphRequestBodyConflictException);
            internal const string InvokeGraphRequestFileNotFilesystemPathException = nameof(InvokeGraphRequestFileNotFilesystemPathException);
            internal const string InvokeGraphRequestInputFileMultiplePathsResolvedException = nameof(InvokeGraphRequestInputFileMultiplePathsResolvedException);
            internal const string InvokeGraphRequestInputFileNoPathResolvedException = nameof(InvokeGraphRequestInputFileNoPathResolvedException);
            internal const string InvokeGraphRequestInputFileNotFilePathException = nameof(InvokeGraphRequestInputFileNotFilePathException);
            internal const string InvokeGraphRequestMissingAuthenticationContext = nameof(InvokeGraphRequestMissingAuthenticationContext);
            internal const string InvokeGraphRequestEmptyKeyInJsonString = nameof(InvokeGraphRequestEmptyKeyInJsonString);
            internal const string InvokeGraphRequestDuplicateKeysInJsonString = nameof(InvokeGraphRequestDuplicateKeysInJsonString);
            internal const string InvokeGraphRequestKeysWithDifferentCasingInJsonString = nameof(InvokeGraphRequestKeysWithDifferentCasingInJsonString);
            public const string InvokeGraphRequestCouldNotInferFileName = nameof(InvokeGraphRequestKeysWithDifferentCasingInJsonString);
        }

        internal static class Message
        {
            internal const string CannotModifyBuiltInEnvironment = "Cannot {0} built-in environment {1}.";
            internal const string InvalidUrlParameter = "Parameter '{0}' has an invalid endpoint URL. Please use a valid URL with a network protocol i.e. [protocol]://[resource-name].";
            internal const string InvalidEnvironment = "Unable to find environment with name '{0}'. Use Get-MgEnvironment to list available environments.";
            internal const string CannotAccessFile = "Could not {0} file at '{1}'. Please ensure you have access to this file and try again in a few minutes..";
            internal const string InvalidCertificateThumbprint = "'{0}' must have a length of 40. Ensure you have the right certificate thumbprint then try again.";
        }
    }
}
