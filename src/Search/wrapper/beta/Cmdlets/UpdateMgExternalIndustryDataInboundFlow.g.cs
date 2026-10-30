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
    [GraphRoute("PATCH", "/external/industryData/inboundFlows/{inboundFlow-id}")]
    [Cmdlet(VerbsData.Update, "MgExternalIndustryDataInboundFlow", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.InboundFlow))]
    public class UpdateMgExternalIndustryDataInboundFlowCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string InboundFlowId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EffectiveDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.ReadinessStatus? ReadinessStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.InboundDomain? DataDomain { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.IndustryDataConnector? DataConnector { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.YearTimePeriodDefinition? Year { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(InboundFlowId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.InboundFlow();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EffectiveDateTime)))
        body.EffectiveDateTime = EffectiveDateTime;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(ReadinessStatus)))
        body.ReadinessStatus = ReadinessStatus;

    if (this.IsParameterBound(nameof(DataDomain)))
        body.DataDomain = DataDomain;

    if (this.IsParameterBound(nameof(DataConnector)))
        body.DataConnector = DataConnector;

    if (this.IsParameterBound(nameof(Year)))
        body.Year = Year;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.InboundFlow? result;
            try
            {
                result = client.External.IndustryData.InboundFlows[InboundFlowId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, InboundFlowId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.External.IndustryData.InboundFlows[InboundFlowId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, InboundFlowId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
