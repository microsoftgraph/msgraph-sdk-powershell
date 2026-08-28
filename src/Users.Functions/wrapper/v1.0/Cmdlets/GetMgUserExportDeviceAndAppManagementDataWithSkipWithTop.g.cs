#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Functions.Client;
using Microsoft.Graph.PowerShell.Users.Functions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users.Functions
{
    [GraphRoute("GET", "/users/{user-id}/exportDeviceAndAppManagementData(skip={skip},top={top})")]
    [Cmdlet(VerbsCommon.Get, "MgUserExportDeviceAndAppManagementDataWithSkipWithTop")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Functions.Client.Models.DeviceAndAppManagementData))]
    public class GetMgUserExportDeviceAndAppManagementDataWithSkipWithTopCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'skip' parameter of this OData function.")]
        public string Skip { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 2,
            HelpMessage = "Value for the 'top' parameter of this OData function.")]
        public string Top { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "user%2Did", UserId },
            { "skip", Skip },
            { "top", Top },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Users.Functions.Client.Users.Item.ExportDeviceAndAppManagementDataWithSkipWithTop.ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Users.Functions.Client.Models.DeviceAndAppManagementData? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
