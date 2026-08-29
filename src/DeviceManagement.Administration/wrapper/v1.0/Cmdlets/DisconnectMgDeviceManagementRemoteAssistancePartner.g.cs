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
    [GraphRoute("POST", "/deviceManagement/remoteAssistancePartners/{remoteAssistancePartner-id}/disconnect")]
    [Cmdlet(VerbsCommunications.Disconnect, "MgDeviceManagementRemoteAssistancePartner", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class DisconnectMgDeviceManagementRemoteAssistancePartnerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RemoteAssistancePartnerId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RemoteAssistancePartnerId, "Disconnect"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.RemoteAssistancePartners[RemoteAssistancePartnerId].Disconnect.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, RemoteAssistancePartnerId);
                return;
            }

        }
    }
}
