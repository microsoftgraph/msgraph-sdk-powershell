#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("GET", "/deviceManagement/depOnboardingSettings/getExpiringVppTokenCount(expiringBeforeDateTime='{expiringBeforeDateTime}')")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementDepOnboardingSettingGetExpiringVppTokenCountWithExpiringBeforeDateTime")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.GetExpiringVppTokenCountWithExpiringBeforeDateTime.GetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponse))]
    public class GetMgDeviceManagementDepOnboardingSettingGetExpiringVppTokenCountWithExpiringBeforeDateTimeCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'expiringBeforeDateTime' parameter of this OData function.")]
        public string ExpiringBeforeDateTime { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "expiringBeforeDateTime", ExpiringBeforeDateTime },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.GetExpiringVppTokenCountWithExpiringBeforeDateTime.GetExpiringVppTokenCountWithExpiringBeforeDateTimeRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.GetExpiringVppTokenCountWithExpiringBeforeDateTime.GetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponse? result;
            try
            {
                result = requestBuilder.GetAsGetExpiringVppTokenCountWithExpiringBeforeDateTimeGetResponseAsync(requestConfiguration =>
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
