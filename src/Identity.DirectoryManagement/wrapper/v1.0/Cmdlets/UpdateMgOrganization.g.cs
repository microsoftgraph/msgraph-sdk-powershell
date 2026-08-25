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
    [GraphRoute("PATCH", "/organization/{organization-id}")]
    [Cmdlet(VerbsData.Update, "MgOrganization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Organization))]
    public class UpdateMgOrganizationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrganizationId { get; set; } = string.Empty;

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






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrganizationId, "Update"))
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


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Organization? result;
            try
            {
                result = client.Organization[OrganizationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, OrganizationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Organization[OrganizationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, OrganizationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
