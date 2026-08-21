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
    [GraphRoute("PATCH", "/deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfiguration-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceEnrollmentConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DeviceEnrollmentConfiguration))]
    public class UpdateMgDeviceManagementDeviceEnrollmentConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceEnrollmentConfigurationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? Priority { get; set; }

        [Parameter(Mandatory = false)]
        public int? Version { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceEnrollmentConfigurationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DeviceEnrollmentConfiguration();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Priority)))
        body.Priority = Priority;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DeviceEnrollmentConfiguration? result;
            try
            {
                result = client.DeviceManagement.DeviceEnrollmentConfigurations[DeviceEnrollmentConfigurationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DeviceEnrollmentConfigurationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceEnrollmentConfigurations[DeviceEnrollmentConfigurationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, DeviceEnrollmentConfigurationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
