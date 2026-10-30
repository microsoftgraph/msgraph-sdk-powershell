#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/deviceAppManagement/mobileApps/{mobileApp-id}/graph.iosVppApp/assignedLicenses/{iosVppAppAssignedLicense-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementMobileAppAsIosVppAppAssignedLicense", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosVppAppAssignedLicense))]
    public class UpdateMgDeviceAppManagementMobileAppAsIosVppAppAssignedLicenseCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string IosVppAppAssignedLicenseId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? UserEmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IosVppAppAssignedLicenseId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosVppAppAssignedLicense();

    if (this.IsParameterBound(nameof(UserEmailAddress)))
        body.UserEmailAddress = UserEmailAddress;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserName)))
        body.UserName = UserName;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosVppAppAssignedLicense? result;
            try
            {
                result = client.DeviceAppManagement.MobileApps[MobileAppId].GraphIosVppApp.AssignedLicenses[IosVppAppAssignedLicenseId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, IosVppAppAssignedLicenseId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.MobileApps[MobileAppId].GraphIosVppApp.AssignedLicenses[IosVppAppAssignedLicenseId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, IosVppAppAssignedLicenseId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
