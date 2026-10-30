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
    [GraphRoute("PATCH", "/external/industryData/dataConnectors/{industryDataConnector-id}")]
    [Cmdlet(VerbsData.Update, "MgExternalIndustryDataConnector", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.IndustryDataConnector))]
    public class UpdateMgExternalIndustryDataConnectorCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IndustryDataConnectorId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.SourceSystemDefinition? SourceSystem { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IndustryDataConnectorId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.IndustryDataConnector();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(SourceSystem)))
        body.SourceSystem = SourceSystem;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.IndustryDataConnector? result;
            try
            {
                result = client.External.IndustryData.DataConnectors[IndustryDataConnectorId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, IndustryDataConnectorId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.External.IndustryData.DataConnectors[IndustryDataConnectorId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, IndustryDataConnectorId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
