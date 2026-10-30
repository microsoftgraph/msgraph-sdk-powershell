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
    [GraphRoute("PATCH", "/external/industryData/outboundProvisioningFlowSets/{outboundProvisioningFlowSet-id}")]
    [Cmdlet(VerbsData.Update, "MgExternalIndustryDataOutboundProvisioningFlowSet", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.OutboundProvisioningFlowSet))]
    public class UpdateMgExternalIndustryDataOutboundProvisioningFlowSetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OutboundProvisioningFlowSetId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.Filter? Filter { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OutboundProvisioningFlowSetId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.OutboundProvisioningFlowSet();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Filter)))
        body.Filter = Filter;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.OutboundProvisioningFlowSet? result;
            try
            {
                result = client.External.IndustryData.OutboundProvisioningFlowSets[OutboundProvisioningFlowSetId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OutboundProvisioningFlowSetId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.External.IndustryData.OutboundProvisioningFlowSets[OutboundProvisioningFlowSetId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, OutboundProvisioningFlowSetId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
