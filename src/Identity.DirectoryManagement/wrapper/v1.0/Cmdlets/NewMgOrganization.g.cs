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
    [GraphRoute("POST", "/organization")]
    [Cmdlet(VerbsCommon.New, "MgOrganization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Organization))]
    public class NewMgOrganizationCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? BusinessPhones { get; set; }

        [Parameter(Mandatory = false)]
        public string? City { get; set; }

        [Parameter(Mandatory = false)]
        public string? Country { get; set; }

        [Parameter(Mandatory = false)]
        public string? CountryLetterCode { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DefaultUsageLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? MarketingNotificationEmails { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OnPremisesSyncEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? PostalCode { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredLanguage { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SecurityComplianceNotificationMails { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SecurityComplianceNotificationPhones { get; set; }

        [Parameter(Mandatory = false)]
        public string? State { get; set; }

        [Parameter(Mandatory = false)]
        public string? Street { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? TechnicalNotificationMails { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AssignedPlan[]? AssignedPlans { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.MdmAuthority? MobileDeviceManagementAuthority { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.PartnerTenantType? PartnerTenantType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.PrivacyProfile? PrivacyProfile { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ProvisionedPlan[]? ProvisionedPlans { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.VerifiedDomain[]? VerifiedDomains { get; set; }




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

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Organization();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(BusinessPhones)))
        body.BusinessPhones = BusinessPhones!.ToList();

    if (this.IsParameterBound(nameof(City)))
        body.City = City;

    if (this.IsParameterBound(nameof(Country)))
        body.Country = Country;

    if (this.IsParameterBound(nameof(CountryLetterCode)))
        body.CountryLetterCode = CountryLetterCode;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DefaultUsageLocation)))
        body.DefaultUsageLocation = DefaultUsageLocation;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(MarketingNotificationEmails)))
        body.MarketingNotificationEmails = MarketingNotificationEmails!.ToList();

    if (this.IsParameterBound(nameof(OnPremisesLastSyncDateTime)))
        body.OnPremisesLastSyncDateTime = OnPremisesLastSyncDateTime;

    if (this.IsParameterBound(nameof(OnPremisesSyncEnabled)))
        body.OnPremisesSyncEnabled = OnPremisesSyncEnabled;

    if (this.IsParameterBound(nameof(PostalCode)))
        body.PostalCode = PostalCode;

    if (this.IsParameterBound(nameof(PreferredLanguage)))
        body.PreferredLanguage = PreferredLanguage;

    if (this.IsParameterBound(nameof(SecurityComplianceNotificationMails)))
        body.SecurityComplianceNotificationMails = SecurityComplianceNotificationMails!.ToList();

    if (this.IsParameterBound(nameof(SecurityComplianceNotificationPhones)))
        body.SecurityComplianceNotificationPhones = SecurityComplianceNotificationPhones!.ToList();

    if (this.IsParameterBound(nameof(State)))
        body.State = State;

    if (this.IsParameterBound(nameof(Street)))
        body.Street = Street;

    if (this.IsParameterBound(nameof(TechnicalNotificationMails)))
        body.TechnicalNotificationMails = TechnicalNotificationMails!.ToList();

    if (this.IsParameterBound(nameof(TenantType)))
        body.TenantType = TenantType;

    if (this.IsParameterBound(nameof(AssignedPlans)))
        body.AssignedPlans = AssignedPlans!.ToList();

    if (this.IsParameterBound(nameof(MobileDeviceManagementAuthority)))
        body.MobileDeviceManagementAuthority = MobileDeviceManagementAuthority;

    if (this.IsParameterBound(nameof(PartnerTenantType)))
        body.PartnerTenantType = PartnerTenantType;

    if (this.IsParameterBound(nameof(PrivacyProfile)))
        body.PrivacyProfile = PrivacyProfile;

    if (this.IsParameterBound(nameof(ProvisionedPlans)))
        body.ProvisionedPlans = ProvisionedPlans!.ToList();

    if (this.IsParameterBound(nameof(VerifiedDomains)))
        body.VerifiedDomains = VerifiedDomains!.ToList();


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

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Organization? result;
            try
            {
                result = client.Organization.PostAsync(body, requestConfiguration =>
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
