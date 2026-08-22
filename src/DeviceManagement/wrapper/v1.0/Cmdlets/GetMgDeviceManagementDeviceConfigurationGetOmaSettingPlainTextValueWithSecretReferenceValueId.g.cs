#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("GET", "/deviceManagement/deviceConfigurations/{deviceConfiguration-id}/getOmaSettingPlainTextValue(secretReferenceValueId='{secretReferenceValueId}')")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementDeviceConfigurationGetOmaSettingPlainTextValueWithSecretReferenceValueId")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceConfigurations.Item.GetOmaSettingPlainTextValueWithSecretReferenceValueId.GetOmaSettingPlainTextValueWithSecretReferenceValueIdGetResponse))]
    public class GetMgDeviceManagementDeviceConfigurationGetOmaSettingPlainTextValueWithSecretReferenceValueIdCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceConfigurationId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'secretReferenceValueId' parameter of this OData function.")]
        public string SecretReferenceValueId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "deviceConfiguration%2Did", DeviceConfigurationId },
            { "secretReferenceValueId", SecretReferenceValueId },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceConfigurations.Item.GetOmaSettingPlainTextValueWithSecretReferenceValueId.GetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceConfigurations.Item.GetOmaSettingPlainTextValueWithSecretReferenceValueId.GetOmaSettingPlainTextValueWithSecretReferenceValueIdGetResponse? result;
            try
            {
                result = requestBuilder.GetAsGetOmaSettingPlainTextValueWithSecretReferenceValueIdGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DeviceConfigurationId);
                return;
            }

            WriteObject(result);
        }
    }
}
