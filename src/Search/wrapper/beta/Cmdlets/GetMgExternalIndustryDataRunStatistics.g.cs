#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/external/industryData/runs/{industryDataRun-id}/microsoft.graph.industryData.getStatistics()")]
    [Cmdlet(VerbsCommon.Get, "MgExternalIndustryDataRunStatistics")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.IndustryDataRunStatistics))]
    public class GetMgExternalIndustryDataRunStatisticsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IndustryDataRunId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Search.Client.Models.IndustryData.IndustryDataRunStatistics? result;
            try
            {
                result = client.External.IndustryData.Runs[IndustryDataRunId].MicrosoftGraphIndustryDataGetStatistics.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, IndustryDataRunId);
                return;
            }

            WriteObject(result);
        }
    }
}
