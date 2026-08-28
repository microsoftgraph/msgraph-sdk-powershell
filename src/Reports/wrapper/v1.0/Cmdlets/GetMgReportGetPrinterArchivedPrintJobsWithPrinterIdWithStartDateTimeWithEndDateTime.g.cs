#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("GET", "/reports/getPrinterArchivedPrintJobs(printerId='{printerId}',startDateTime={startDateTime},endDateTime={endDateTime})")]
    [Cmdlet(VerbsCommon.Get, "MgReportGetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Reports.Client.Reports.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeGetResponse))]
    public class GetMgReportGetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'printerId' parameter of this OData function.")]
        public string PrinterId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'startDateTime' parameter of this OData function.")]
        public string StartDateTime { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 2,
            HelpMessage = "Value for the 'endDateTime' parameter of this OData function.")]
        public string EndDateTime { get; set; } = string.Empty;



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
            { "printerId", PrinterId },
            { "startDateTime", StartDateTime },
            { "endDateTime", EndDateTime },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Reports.Client.Reports.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.Reports.Client.Reports.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeGetResponse? result;
            try
            {
                result = requestBuilder.GetAsGetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeGetResponseAsync(requestConfiguration =>
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
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
