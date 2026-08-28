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
    [GraphRoute("POST", "/deviceAppManagement/managedAppRegistrations")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementManagedAppRegistration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRegistration))]
    public class NewMgDeviceAppManagementManagedAppRegistrationCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? ApplicationVersion { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceTag { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceType { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagementSdkVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlatformVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppIdentifier? AppIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppFlaggedReason?[]? FlaggedReasons { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRegistration();

    if (this.IsParameterBound(nameof(ApplicationVersion)))
        body.ApplicationVersion = ApplicationVersion;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(DeviceTag)))
        body.DeviceTag = DeviceTag;

    if (this.IsParameterBound(nameof(DeviceType)))
        body.DeviceType = DeviceType;

    if (this.IsParameterBound(nameof(LastSyncDateTime)))
        body.LastSyncDateTime = LastSyncDateTime;

    if (this.IsParameterBound(nameof(ManagementSdkVersion)))
        body.ManagementSdkVersion = ManagementSdkVersion;

    if (this.IsParameterBound(nameof(PlatformVersion)))
        body.PlatformVersion = PlatformVersion;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(AppIdentifier)))
        body.AppIdentifier = AppIdentifier;

    if (this.IsParameterBound(nameof(FlaggedReasons)))
        body.FlaggedReasons = FlaggedReasons!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRegistration? result;
            try
            {
                result = client.DeviceAppManagement.ManagedAppRegistrations.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
