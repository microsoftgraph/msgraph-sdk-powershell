// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell
{
    using System.Management.Automation;
    public static class PSCmdletExtensions
    {
        /// <summary>
        /// Overrides OnDefault method in the generated cmdlets.
        /// </summary>
        /// <param name="cmdlet">The calling <see cref="PSCmdlet"/></param>
        /// <param name="responseMessage">The HTTP response message from the service.</param>
        /// <param name="returnNow">Determines whether the caller should return after OverrideOnDefault is called, or not. </param>
        public static void OverrideOnDefault(this PSCmdlet cmdlet, global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow)
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                if (cmdlet.MyInvocation?.BoundParameters?.ContainsKey("PassThru") == true)
                {
                    cmdlet.WriteObject(true);
                }
                returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(true);
            }
        }
    }
}
