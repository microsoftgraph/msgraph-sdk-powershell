#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DirectoryObjects.Client;
using Microsoft.Graph.PowerShell.DirectoryObjects.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DirectoryObjects
{
    [GraphRoute("POST", "/directoryObjects/getAvailableExtensionProperties")]
    [Cmdlet(VerbsCommon.Get, "MgDirectoryObjectAvailableExtensionProperty", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DirectoryObjects.Client.DirectoryObjects.GetAvailableExtensionProperties.GetAvailableExtensionPropertiesPostResponse))]
    public class GetMgDirectoryObjectAvailableExtensionPropertyCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? IsSyncedFromOnPremises { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DirectoryObjects.Client.DirectoryObjects.GetAvailableExtensionProperties.GetAvailableExtensionPropertiesPostRequestBody();

    if (this.IsParameterBound(nameof(IsSyncedFromOnPremises)))
        body.IsSyncedFromOnPremises = IsSyncedFromOnPremises;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DirectoryObjects.Client.DirectoryObjects.GetAvailableExtensionProperties.GetAvailableExtensionPropertiesPostResponse? result;
            try
            {
                result = client.DirectoryObjects.GetAvailableExtensionProperties.PostAsGetAvailableExtensionPropertiesPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
