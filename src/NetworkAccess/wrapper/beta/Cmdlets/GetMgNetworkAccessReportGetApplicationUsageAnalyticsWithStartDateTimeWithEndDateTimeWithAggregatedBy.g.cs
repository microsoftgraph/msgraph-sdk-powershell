#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("GET", "/networkAccess/reports/microsoft.graph.networkaccess.getApplicationUsageAnalytics(startDateTime={startDateTime},endDateTime={endDateTime},aggregatedBy='{aggregatedBy}')")]
    [Cmdlet(VerbsCommon.Get, "MgNetworkAccessReportGetApplicationUsageAnalyticsWithStartDateTimeWithEndDateTimeWithAggregatedBy")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.NetworkAccess.Client.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetApplicationUsageAnalyticsWithStartDateTimeWithEndDateTimeWithAggregatedBy.GetApplicationUsageAnalyticsWithStartDateTimeWithEndDateTimeWithAggregatedByGetResponse))]
    public class GetMgNetworkAccessReportGetApplicationUsageAnalyticsWithStartDateTimeWithEndDateTimeWithAggregatedByCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'startDateTime' parameter of this OData function.")]
        public string StartDateTime { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'endDateTime' parameter of this OData function.")]
        public string EndDateTime { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 2,
            HelpMessage = "Value for the 'aggregatedBy' parameter of this OData function.")]
        public string AggregatedBy { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }

        [Parameter(Mandatory = false)]
        public int Top { get; set; }

        [Parameter(Mandatory = false)]
        public int Skip { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter Count { get; set; }




        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "startDateTime", StartDateTime },
            { "endDateTime", EndDateTime },
            { "aggregatedBy", AggregatedBy },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.NetworkAccess.Client.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetApplicationUsageAnalyticsWithStartDateTimeWithEndDateTimeWithAggregatedBy.MicrosoftGraphNetworkaccessGetApplicationUsageAnalyticsWithStartDateTimeWithEndDateTimeWithAggregatedByRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.NetworkAccess.Client.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetApplicationUsageAnalyticsWithStartDateTimeWithEndDateTimeWithAggregatedBy.GetApplicationUsageAnalyticsWithStartDateTimeWithEndDateTimeWithAggregatedByGetResponse? result;
            try
            {
                result = requestBuilder.GetAsGetApplicationUsageAnalyticsWithStartDateTimeWithEndDateTimeWithAggregatedByGetResponseAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                    if (this.IsParameterBound(nameof(Top)))
                        requestConfiguration.QueryParameters.Top = Top;

                    if (this.IsParameterBound(nameof(Skip)))
                        requestConfiguration.QueryParameters.Skip = Skip;

                    if (Count.IsPresent)
                        requestConfiguration.QueryParameters.Count = true;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
