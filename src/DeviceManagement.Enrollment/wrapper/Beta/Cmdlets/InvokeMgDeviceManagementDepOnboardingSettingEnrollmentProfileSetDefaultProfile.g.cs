#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/deviceManagement/depOnboardingSettings/{depOnboardingSetting-id}/enrollmentProfiles/{enrollmentProfile-id}/setDefaultProfile")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementDepOnboardingSettingEnrollmentProfileSetDefaultProfile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementDepOnboardingSettingEnrollmentProfileSetDefaultProfileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DepOnboardingSettingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EnrollmentProfileId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EnrollmentProfileId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.DepOnboardingSettings[DepOnboardingSettingId].EnrollmentProfiles[EnrollmentProfileId].SetDefaultProfile.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EnrollmentProfileId);
                return;
            }

        }
    }
}
