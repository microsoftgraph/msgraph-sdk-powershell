// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    public static class Errors
    {
        public const string InvokeGraphHttpResponseException = nameof(InvokeGraphHttpResponseException);
        public const string InvokeGraphContentTypeException = nameof(InvokeGraphContentTypeException);
        public const string InvokeGraphRequestInvalidHost = nameof(InvokeGraphRequestInvalidHost);
        public const string InvokeGraphRequestSessionConflictException = nameof(InvokeGraphRequestSessionConflictException);
        public const string InvokeGraphRequestBodyMissingWhenMethodIsSpecified = nameof(InvokeGraphRequestBodyMissingWhenMethodIsSpecified);
        public const string InvokeGraphRequestOutFileMissingException = nameof(InvokeGraphRequestOutFileMissingException);
        public const string InvokeGraphRequestAuthenticationTokenConflictException = nameof(InvokeGraphRequestAuthenticationTokenConflictException);
        public const string InvokeGraphRequestAuthenticationCredentialNotSuppliedException = nameof(InvokeGraphRequestAuthenticationCredentialNotSuppliedException);
        public const string InvokeGraphRequestBodyConflictException = nameof(InvokeGraphRequestBodyConflictException);
        public const string InvokeGraphRequestFileNotFilesystemPathException = nameof(InvokeGraphRequestFileNotFilesystemPathException);
        public const string InvokeGraphRequestInputFileMultiplePathsResolvedException = nameof(InvokeGraphRequestInputFileMultiplePathsResolvedException);
        public const string InvokeGraphRequestInputFileNoPathResolvedException = nameof(InvokeGraphRequestInputFileNoPathResolvedException);
        public const string InvokeGraphRequestInputFileNotFilePathException = nameof(InvokeGraphRequestInputFileNotFilePathException);
        public const string InvokeGraphRequestMissingAuthenticationContext = nameof(InvokeGraphRequestMissingAuthenticationContext);
        public const string InvokeGraphRequestEmptyKeyInJsonString = nameof(InvokeGraphRequestEmptyKeyInJsonString);
        public const string InvokeGraphRequestDuplicateKeysInJsonString = nameof(InvokeGraphRequestDuplicateKeysInJsonString);
        public const string InvokeGraphRequestKeysWithDifferentCasingInJsonString =nameof(InvokeGraphRequestKeysWithDifferentCasingInJsonString);
    }
}