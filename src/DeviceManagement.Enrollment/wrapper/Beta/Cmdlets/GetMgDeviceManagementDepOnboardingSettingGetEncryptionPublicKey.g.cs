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
    [GraphRoute("GET", "/deviceManagement/depOnboardingSettings/{depOnboardingSetting-id}/getEncryptionPublicKey()")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementDepOnboardingSettingGetEncryptionPublicKey")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.Item.GetEncryptionPublicKey.GetEncryptionPublicKeyGetResponse))]
    public class GetMgDeviceManagementDepOnboardingSettingGetEncryptionPublicKeyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DepOnboardingSettingId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.Item.GetEncryptionPublicKey.GetEncryptionPublicKeyGetResponse? result;
            try
            {
                result = client.DeviceManagement.DepOnboardingSettings[DepOnboardingSettingId].GetEncryptionPublicKey.GetAsGetEncryptionPublicKeyGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DepOnboardingSettingId);
                return;
            }

            WriteObject(result);
        }
    }
}
