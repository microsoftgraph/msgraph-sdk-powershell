#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("POST", "/deviceManagement/depOnboardingSettings/{depOnboardingSetting-id}/enrollmentProfiles")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementDepOnboardingSettingEnrollmentProfile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.EnrollmentProfile))]
    public class NewMgDeviceManagementDepOnboardingSettingEnrollmentProfileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DepOnboardingSettingId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ConfigurationEndpointUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? EnableAuthenticationViaCompanyPortal { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RequireCompanyPortalOnSetupAssistantEnrolledDevices { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RequiresUserAuthentication { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DepOnboardingSettingId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.EnrollmentProfile();

    if (this.IsParameterBound(nameof(ConfigurationEndpointUrl)))
        body.ConfigurationEndpointUrl = ConfigurationEndpointUrl;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EnableAuthenticationViaCompanyPortal)))
        body.EnableAuthenticationViaCompanyPortal = EnableAuthenticationViaCompanyPortal;

    if (this.IsParameterBound(nameof(RequireCompanyPortalOnSetupAssistantEnrolledDevices)))
        body.RequireCompanyPortalOnSetupAssistantEnrolledDevices = RequireCompanyPortalOnSetupAssistantEnrolledDevices;

    if (this.IsParameterBound(nameof(RequiresUserAuthentication)))
        body.RequiresUserAuthentication = RequiresUserAuthentication;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.EnrollmentProfile? result;
            try
            {
                result = client.DeviceManagement.DepOnboardingSettings[DepOnboardingSettingId].EnrollmentProfiles.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
