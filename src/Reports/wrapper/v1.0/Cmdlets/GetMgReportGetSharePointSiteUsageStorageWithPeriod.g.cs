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
    [GraphRoute("GET", "/reports/getSharePointSiteUsageStorage(period='{period}')")]
    [Cmdlet(VerbsCommon.Get, "MgReportGetSharePointSiteUsageStorageWithPeriod")]
    [OutputType(typeof(byte[]))]
    public class GetMgReportGetSharePointSiteUsageStorageWithPeriodCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'period' parameter of this OData function.")]
        public string Period { get; set; } = string.Empty;








        [Parameter(Mandatory = false,
            HelpMessage = "Writes the response content to this path instead of returning it as bytes.")]
        public string? OutFile { get; set; }

        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "period", Period },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Reports.Client.Reports.GetSharePointSiteUsageStorageWithPeriod.GetSharePointSiteUsageStorageWithPeriodRequestBuilder(pathParameters, requestAdapter);

            System.IO.Stream? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

        if (result is not null)
        {
            using (result)
            {
                if (this.IsParameterBound(nameof(OutFile)))
                {
                    using var file = System.IO.File.Create(OutFile!);
                    result.CopyTo(file);
                }
                else
                {
                    using var buffer = new System.IO.MemoryStream();
                    result.CopyTo(buffer);
                    WriteObject(buffer.ToArray());
                }
            }
        }
        }
    }
}
