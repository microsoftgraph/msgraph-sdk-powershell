// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    /// <summary>
    ///     Output data format to return to the caller
    /// </summary>
    public enum OutputType
    {
        /// <summary>
        /// Default OutputType, Key Value
        /// </summary>
        HashTable,
        /// <summary>
        /// Deserialized from returned Json to a PSObject.
        /// </summary>
        PSObject,
        /// <summary>
        /// Full Http Response
        /// </summary>
        HttpResponseMessage,
        /// <summary>
        /// Raw Json String.
        /// </summary>
        Json
    }
}