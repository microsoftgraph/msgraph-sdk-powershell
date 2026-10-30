#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Search.Client;
using Microsoft.Graph.PowerShell.Search.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Search
{
    [GraphRoute("PATCH", "/external/industryData/outboundProvisioningFlowSets/{outboundProvisioningFlowSet-id}/provisioningFlows/{provisioningFlow-id}")]
    [Cmdlet(VerbsData.Update, "MgExternalIndustryDataOutboundProvisioningFlowSetProvisioningFlow", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.ProvisioningFlow))]
    public class UpdateMgExternalIndustryDataOutboundProvisioningFlowSetProvisioningFlowCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OutboundProvisioningFlowSetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ProvisioningFlowId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ProvisioningFlowId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.ProvisioningFlow();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.ProvisioningFlow? result;
            try
            {
                result = client.External.IndustryData.OutboundProvisioningFlowSets[OutboundProvisioningFlowSetId].ProvisioningFlows[ProvisioningFlowId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ProvisioningFlowId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.External.IndustryData.OutboundProvisioningFlowSets[OutboundProvisioningFlowSetId].ProvisioningFlows[ProvisioningFlowId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ProvisioningFlowId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
