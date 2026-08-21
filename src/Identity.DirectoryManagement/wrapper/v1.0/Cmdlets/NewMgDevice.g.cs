#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/devices")]
    [Cmdlet(VerbsCommon.New, "MgDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Device))]
    public class NewMgDeviceCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AccountEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ApproximateLastSignInDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ComplianceExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceCategory { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceMetadata { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceOwnership { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeviceVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? EnrollmentProfileName { get; set; }

        [Parameter(Mandatory = false)]
        public string? EnrollmentType { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCompliant { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsManaged { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsManagementRestricted { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRooted { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagementType { get; set; }

        [Parameter(Mandatory = false)]
        public string? Manufacturer { get; set; }

        [Parameter(Mandatory = false)]
        public string? MdmAppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Model { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesSecurityIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OnPremisesSyncEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? OperatingSystem { get; set; }

        [Parameter(Mandatory = false)]
        public string? OperatingSystemVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? PhysicalIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? ProfileType { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RegistrationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SystemLabels { get; set; }

        [Parameter(Mandatory = false)]
        public string? TrustType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AlternativeSecurityId[]? AlternativeSecurityIds { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Device();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(AccountEnabled)))
        body.AccountEnabled = AccountEnabled;

    if (this.IsParameterBound(nameof(ApproximateLastSignInDateTime)))
        body.ApproximateLastSignInDateTime = ApproximateLastSignInDateTime;

    if (this.IsParameterBound(nameof(ComplianceExpirationDateTime)))
        body.ComplianceExpirationDateTime = ComplianceExpirationDateTime;

    if (this.IsParameterBound(nameof(DeviceCategory)))
        body.DeviceCategory = DeviceCategory;

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceMetadata)))
        body.DeviceMetadata = DeviceMetadata;

    if (this.IsParameterBound(nameof(DeviceOwnership)))
        body.DeviceOwnership = DeviceOwnership;

    if (this.IsParameterBound(nameof(DeviceVersion)))
        body.DeviceVersion = DeviceVersion;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EnrollmentProfileName)))
        body.EnrollmentProfileName = EnrollmentProfileName;

    if (this.IsParameterBound(nameof(EnrollmentType)))
        body.EnrollmentType = EnrollmentType;

    if (this.IsParameterBound(nameof(IsCompliant)))
        body.IsCompliant = IsCompliant;

    if (this.IsParameterBound(nameof(IsManaged)))
        body.IsManaged = IsManaged;

    if (this.IsParameterBound(nameof(IsManagementRestricted)))
        body.IsManagementRestricted = IsManagementRestricted;

    if (this.IsParameterBound(nameof(IsRooted)))
        body.IsRooted = IsRooted;

    if (this.IsParameterBound(nameof(ManagementType)))
        body.ManagementType = ManagementType;

    if (this.IsParameterBound(nameof(Manufacturer)))
        body.Manufacturer = Manufacturer;

    if (this.IsParameterBound(nameof(MdmAppId)))
        body.MdmAppId = MdmAppId;

    if (this.IsParameterBound(nameof(Model)))
        body.Model = Model;

    if (this.IsParameterBound(nameof(OnPremisesLastSyncDateTime)))
        body.OnPremisesLastSyncDateTime = OnPremisesLastSyncDateTime;

    if (this.IsParameterBound(nameof(OnPremisesSecurityIdentifier)))
        body.OnPremisesSecurityIdentifier = OnPremisesSecurityIdentifier;

    if (this.IsParameterBound(nameof(OnPremisesSyncEnabled)))
        body.OnPremisesSyncEnabled = OnPremisesSyncEnabled;

    if (this.IsParameterBound(nameof(OperatingSystem)))
        body.OperatingSystem = OperatingSystem;

    if (this.IsParameterBound(nameof(OperatingSystemVersion)))
        body.OperatingSystemVersion = OperatingSystemVersion;

    if (this.IsParameterBound(nameof(PhysicalIds)))
        body.PhysicalIds = PhysicalIds!.ToList();

    if (this.IsParameterBound(nameof(ProfileType)))
        body.ProfileType = ProfileType;

    if (this.IsParameterBound(nameof(RegistrationDateTime)))
        body.RegistrationDateTime = RegistrationDateTime;

    if (this.IsParameterBound(nameof(SystemLabels)))
        body.SystemLabels = SystemLabels!.ToList();

    if (this.IsParameterBound(nameof(TrustType)))
        body.TrustType = TrustType;

    if (this.IsParameterBound(nameof(AlternativeSecurityIds)))
        body.AlternativeSecurityIds = AlternativeSecurityIds!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Device? result;
            try
            {
                result = client.Devices.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
