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
    [GraphRoute("GET", "/reports/deviceConfigurationUserActivity()")]
    [Cmdlet(VerbsCommon.Get, "MgReportDeviceConfigurationUserActivity")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.Report))]
    public class GetMgReportDeviceConfigurationUserActivityCommand : GraphClientCmdlet
    {










        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Reports.Client.Models.Report? result;
            try
            {
                result = client.Reports.DeviceConfigurationUserActivity.GetAsync(requestConfiguration =>
                {

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
