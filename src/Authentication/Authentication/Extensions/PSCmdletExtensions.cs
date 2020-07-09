// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Extensions
{
    using System.Management.Automation;
    internal static class PSCmdletExtensions
    {
        /// <summary>
        /// Determines is a parameter has been provided by the user.
        /// </summary>
        /// <param name="cmdlet">The executing cmdlet.</param>
        /// <param name="parameterName">The name of the parameter to check.</param>
        /// <returns>True is the parameter was set by the user, otherwise false.</returns>
        public static bool IsParameterBound(this PSCmdlet cmdlet, string parameterName)
        {
            return cmdlet.MyInvocation?.BoundParameters.ContainsKey(parameterName) ?? false;
        }
    }
}