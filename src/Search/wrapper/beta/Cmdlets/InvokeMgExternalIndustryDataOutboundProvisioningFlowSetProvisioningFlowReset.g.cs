#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Search.Client;
using Microsoft.Graph.PowerShell.Search.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Search
{
    [GraphRoute("POST", "/external/industryData/outboundProvisioningFlowSets/{outboundProvisioningFlowSet-id}/provisioningFlows/{provisioningFlow-id}/microsoft.graph.industryData.reset")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgExternalIndustryDataOutboundProvisioningFlowSetProvisioningFlowReset", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgExternalIndustryDataOutboundProvisioningFlowSetProvisioningFlowResetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OutboundProvisioningFlowSetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ProvisioningFlowId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ProvisioningFlowId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.External.IndustryData.OutboundProvisioningFlowSets[OutboundProvisioningFlowSetId].ProvisioningFlows[ProvisioningFlowId].MicrosoftGraphIndustryDataReset.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ProvisioningFlowId);
                return;
            }

        }
    }
}
