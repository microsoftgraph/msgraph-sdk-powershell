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
    [GraphRoute("GET", "/reports/managedDeviceEnrollmentFailureDetails(skip={skip},top={top},filter='{filter}',skipToken='{skipToken}')")]
    [Cmdlet(VerbsCommon.Get, "MgReportManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.Report))]
    public class GetMgReportManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'skip' parameter of this OData function.")]
        public string Skip { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'top' parameter of this OData function.")]
        public string Top { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 2,
            HelpMessage = "Value for the 'filter' parameter of this OData function.")]
        public string Filter { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 3,
            HelpMessage = "Value for the 'skipToken' parameter of this OData function.")]
        public string SkipToken { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "skip", Skip },
            { "top", Top },
            { "filter", Filter },
            { "skipToken", SkipToken },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Reports.Client.Reports.ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken.ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.Report? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

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
