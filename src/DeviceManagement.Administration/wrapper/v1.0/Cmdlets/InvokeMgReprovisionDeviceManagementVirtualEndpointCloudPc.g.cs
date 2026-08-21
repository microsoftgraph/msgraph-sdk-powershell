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
    [GraphRoute("POST", "/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC-id}/reprovision")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgReprovisionDeviceManagementVirtualEndpointCloudPc", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgReprovisionDeviceManagementVirtualEndpointCloudPcCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudPCId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcUserAccountType? UserAccountType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcOperatingSystem? OsVersion { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CloudPCId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Reprovision.ReprovisionPostRequestBody();

    if (this.IsParameterBound(nameof(UserAccountType)))
        body.UserAccountType = UserAccountType;

    if (this.IsParameterBound(nameof(OsVersion)))
        body.OsVersion = OsVersion;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.VirtualEndpoint.CloudPCs[CloudPCId].Reprovision.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, CloudPCId);
                return;
            }

        }
    }
}
