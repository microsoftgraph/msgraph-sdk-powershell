#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/targetedManagedAppConfigurations/hasPayloadLinks")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceAppManagementTargetedManagedAppConfigurationHasPayloadLinks", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.TargetedManagedAppConfigurations.HasPayloadLinks.HasPayloadLinksPostResponse))]
    public class InvokeMgDeviceAppManagementTargetedManagedAppConfigurationHasPayloadLinksCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? PayloadIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.TargetedManagedAppConfigurations.HasPayloadLinks.HasPayloadLinksPostRequestBody();

    if (this.IsParameterBound(nameof(PayloadIds)))
        body.PayloadIds = PayloadIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.TargetedManagedAppConfigurations.HasPayloadLinks.HasPayloadLinksPostResponse? result;
            try
            {
                result = client.DeviceAppManagement.TargetedManagedAppConfigurations.HasPayloadLinks.PostAsHasPayloadLinksPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
