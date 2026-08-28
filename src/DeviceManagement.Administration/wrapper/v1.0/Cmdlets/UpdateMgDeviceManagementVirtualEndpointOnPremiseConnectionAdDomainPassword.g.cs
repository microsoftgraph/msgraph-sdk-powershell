#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("POST", "/deviceManagement/virtualEndpoint/onPremisesConnections/{cloudPcOnPremisesConnection-id}/updateAdDomainPassword")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementVirtualEndpointOnPremiseConnectionAdDomainPassword", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class UpdateMgDeviceManagementVirtualEndpointOnPremiseConnectionAdDomainPasswordCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudPcOnPremisesConnectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AdDomainPassword { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CloudPcOnPremisesConnectionId, "Update"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.DeviceManagement.VirtualEndpoint.OnPremisesConnections.Item.UpdateAdDomainPassword.UpdateAdDomainPasswordPostRequestBody();

    if (this.IsParameterBound(nameof(AdDomainPassword)))
        body.AdDomainPassword = AdDomainPassword;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.VirtualEndpoint.OnPremisesConnections[CloudPcOnPremisesConnectionId].UpdateAdDomainPassword.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CloudPcOnPremisesConnectionId);
                return;
            }

        }
    }
}
