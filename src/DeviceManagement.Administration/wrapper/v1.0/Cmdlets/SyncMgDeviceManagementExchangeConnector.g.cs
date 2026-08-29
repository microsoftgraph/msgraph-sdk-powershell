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
    [GraphRoute("POST", "/deviceManagement/exchangeConnectors/{deviceManagementExchangeConnector-id}/sync")]
    [Cmdlet(VerbsData.Sync, "MgDeviceManagementExchangeConnector", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SyncMgDeviceManagementExchangeConnectorCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementExchangeConnectorId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementExchangeConnectorSyncType? SyncType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementExchangeConnectorId, "Sync"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.DeviceManagement.ExchangeConnectors.Item.Sync.SyncPostRequestBody();

    if (this.IsParameterBound(nameof(SyncType)))
        body.SyncType = SyncType;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.ExchangeConnectors[DeviceManagementExchangeConnectorId].Sync.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementExchangeConnectorId);
                return;
            }

        }
    }
}
