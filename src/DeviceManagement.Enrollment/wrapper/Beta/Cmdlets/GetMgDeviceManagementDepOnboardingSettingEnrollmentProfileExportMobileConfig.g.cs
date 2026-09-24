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
    [GraphRoute("GET", "/deviceManagement/depOnboardingSettings/{depOnboardingSetting-id}/enrollmentProfiles/{enrollmentProfile-id}/exportMobileConfig()")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementDepOnboardingSettingEnrollmentProfileExportMobileConfig")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.Item.EnrollmentProfiles.Item.ExportMobileConfig.ExportMobileConfigGetResponse))]
    public class GetMgDeviceManagementDepOnboardingSettingEnrollmentProfileExportMobileConfigCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DepOnboardingSettingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EnrollmentProfileId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.Item.EnrollmentProfiles.Item.ExportMobileConfig.ExportMobileConfigGetResponse? result;
            try
            {
                result = client.DeviceManagement.DepOnboardingSettings[DepOnboardingSettingId].EnrollmentProfiles[EnrollmentProfileId].ExportMobileConfig.GetAsExportMobileConfigGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EnrollmentProfileId);
                return;
            }

            WriteObject(result);
        }
    }
}
