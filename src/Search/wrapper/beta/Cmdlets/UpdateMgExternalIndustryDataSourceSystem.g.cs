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
    [GraphRoute("PATCH", "/external/industryData/sourceSystems/{sourceSystemDefinition-id}")]
    [Cmdlet(VerbsData.Update, "MgExternalIndustryDataSourceSystem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.SourceSystemDefinition))]
    public class UpdateMgExternalIndustryDataSourceSystemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SourceSystemDefinitionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Vendor { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.UserMatchingSetting[]? UserMatchingSettings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SourceSystemDefinitionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.SourceSystemDefinition();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Vendor)))
        body.Vendor = Vendor;

    if (this.IsParameterBound(nameof(UserMatchingSettings)))
        body.UserMatchingSettings = UserMatchingSettings!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.SourceSystemDefinition? result;
            try
            {
                result = client.External.IndustryData.SourceSystems[SourceSystemDefinitionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SourceSystemDefinitionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.External.IndustryData.SourceSystems[SourceSystemDefinitionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SourceSystemDefinitionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
