#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/devices")]
    [Cmdlet(VerbsCommon.New, "MgDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Device))]
    public class NewMgDeviceCommand : PSCmdlet
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




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

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


        // ── Choose HttpClient + auth provider ─────────────────────────────
        HttpClient httpClient;
        IAuthenticationProvider authProvider;

        if (this.IsParameterBound(nameof(AccessToken)))
        {
            httpClient = new HttpClient();
            authProvider = new StaticBearerTokenAuthenticationProvider(AccessToken!);
        }
        else
        {
            WriteVerbose("No -AccessToken supplied, using the active Connect-MgGraph session.");
            try
            {
                httpClient = HttpHelpers.GetGraphHttpClient();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(
                    new InvalidOperationException(
                        "No active Graph session. Run Connect-MgGraph first, or supply -AccessToken.", ex),
                    "NoGraphSession",
                    ErrorCategory.AuthenticationError,
                    null));
                return;
            }
            authProvider = new AnonymousAuthenticationProvider();
        }

        var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Device? result;
            try
            {
                result = client.Devices.PostAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(Headers)))
                        {
                            foreach (System.Collections.DictionaryEntry entry in Headers!)
                                requestConfiguration.Headers.Add(entry.Key.ToString()!, entry.Value?.ToString() ?? string.Empty);
                        }
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, body));
                return;
            }

            WriteObject(result);
        }
    }
}
