#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("PATCH", "/groups/{group-id}")]
    [Cmdlet(VerbsData.Update, "MgGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.Group))]
    public class UpdateMgGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowExternalSenders { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AutoSubscribeNewMembers { get; set; }

        [Parameter(Mandatory = false)]
        public string? Classification { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? GroupTypes { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasMembersWithLicenseErrors { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HideFromAddressLists { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HideFromOutlookClients { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? InfoCatalogs { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsArchived { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAssignableToRole { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsFavorite { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsManagementRestricted { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSubscribedByMail { get; set; }

        [Parameter(Mandatory = false)]
        public string? Mail { get; set; }

        [Parameter(Mandatory = false)]
        public bool? MailEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? MailNickname { get; set; }

        [Parameter(Mandatory = false)]
        public string? MembershipRule { get; set; }

        [Parameter(Mandatory = false)]
        public string? MembershipRuleProcessingState { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesDomainName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesNetBiosName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesSamAccountName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesSecurityIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OnPremisesSyncEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredDataLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredLanguage { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ProxyAddresses { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RenewedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ResourceBehaviorOptions { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ResourceProvisioningOptions { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SecurityEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? SecurityIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? Theme { get; set; }

        [Parameter(Mandatory = false)]
        public string? UniqueName { get; set; }

        [Parameter(Mandatory = false)]
        public int? UnseenConversationsCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? UnseenCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? UnseenMessagesCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? Visibility { get; set; }

        [Parameter(Mandatory = false)]
        public bool? WelcomeMessageEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.GroupAccessType? AccessType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.AssignedLabel[]? AssignedLabels { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.AssignedLicense[]? AssignedLicenses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.LicenseProcessingState? LicenseProcessingState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.OnPremisesExtensionAttributes? OnPremisesExtensionAttributes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.OnPremisesProvisioningError[]? OnPremisesProvisioningErrors { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.ServiceProvisioningError[]? ServiceProvisioningErrors { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Groups.Client.Models.Group();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(AllowExternalSenders)))
        body.AllowExternalSenders = AllowExternalSenders;

    if (this.IsParameterBound(nameof(AutoSubscribeNewMembers)))
        body.AutoSubscribeNewMembers = AutoSubscribeNewMembers;

    if (this.IsParameterBound(nameof(Classification)))
        body.Classification = Classification;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(GroupTypes)))
        body.GroupTypes = GroupTypes!.ToList();

    if (this.IsParameterBound(nameof(HasMembersWithLicenseErrors)))
        body.HasMembersWithLicenseErrors = HasMembersWithLicenseErrors;

    if (this.IsParameterBound(nameof(HideFromAddressLists)))
        body.HideFromAddressLists = HideFromAddressLists;

    if (this.IsParameterBound(nameof(HideFromOutlookClients)))
        body.HideFromOutlookClients = HideFromOutlookClients;

    if (this.IsParameterBound(nameof(InfoCatalogs)))
        body.InfoCatalogs = InfoCatalogs!.ToList();

    if (this.IsParameterBound(nameof(IsArchived)))
        body.IsArchived = IsArchived;

    if (this.IsParameterBound(nameof(IsAssignableToRole)))
        body.IsAssignableToRole = IsAssignableToRole;

    if (this.IsParameterBound(nameof(IsFavorite)))
        body.IsFavorite = IsFavorite;

    if (this.IsParameterBound(nameof(IsManagementRestricted)))
        body.IsManagementRestricted = IsManagementRestricted;

    if (this.IsParameterBound(nameof(IsSubscribedByMail)))
        body.IsSubscribedByMail = IsSubscribedByMail;

    if (this.IsParameterBound(nameof(Mail)))
        body.Mail = Mail;

    if (this.IsParameterBound(nameof(MailEnabled)))
        body.MailEnabled = MailEnabled;

    if (this.IsParameterBound(nameof(MailNickname)))
        body.MailNickname = MailNickname;

    if (this.IsParameterBound(nameof(MembershipRule)))
        body.MembershipRule = MembershipRule;

    if (this.IsParameterBound(nameof(MembershipRuleProcessingState)))
        body.MembershipRuleProcessingState = MembershipRuleProcessingState;

    if (this.IsParameterBound(nameof(OnPremisesDomainName)))
        body.OnPremisesDomainName = OnPremisesDomainName;

    if (this.IsParameterBound(nameof(OnPremisesLastSyncDateTime)))
        body.OnPremisesLastSyncDateTime = OnPremisesLastSyncDateTime;

    if (this.IsParameterBound(nameof(OnPremisesNetBiosName)))
        body.OnPremisesNetBiosName = OnPremisesNetBiosName;

    if (this.IsParameterBound(nameof(OnPremisesSamAccountName)))
        body.OnPremisesSamAccountName = OnPremisesSamAccountName;

    if (this.IsParameterBound(nameof(OnPremisesSecurityIdentifier)))
        body.OnPremisesSecurityIdentifier = OnPremisesSecurityIdentifier;

    if (this.IsParameterBound(nameof(OnPremisesSyncEnabled)))
        body.OnPremisesSyncEnabled = OnPremisesSyncEnabled;

    if (this.IsParameterBound(nameof(PreferredDataLocation)))
        body.PreferredDataLocation = PreferredDataLocation;

    if (this.IsParameterBound(nameof(PreferredLanguage)))
        body.PreferredLanguage = PreferredLanguage;

    if (this.IsParameterBound(nameof(ProxyAddresses)))
        body.ProxyAddresses = ProxyAddresses!.ToList();

    if (this.IsParameterBound(nameof(RenewedDateTime)))
        body.RenewedDateTime = RenewedDateTime;

    if (this.IsParameterBound(nameof(ResourceBehaviorOptions)))
        body.ResourceBehaviorOptions = ResourceBehaviorOptions!.ToList();

    if (this.IsParameterBound(nameof(ResourceProvisioningOptions)))
        body.ResourceProvisioningOptions = ResourceProvisioningOptions!.ToList();

    if (this.IsParameterBound(nameof(SecurityEnabled)))
        body.SecurityEnabled = SecurityEnabled;

    if (this.IsParameterBound(nameof(SecurityIdentifier)))
        body.SecurityIdentifier = SecurityIdentifier;

    if (this.IsParameterBound(nameof(Theme)))
        body.Theme = Theme;

    if (this.IsParameterBound(nameof(UniqueName)))
        body.UniqueName = UniqueName;

    if (this.IsParameterBound(nameof(UnseenConversationsCount)))
        body.UnseenConversationsCount = UnseenConversationsCount;

    if (this.IsParameterBound(nameof(UnseenCount)))
        body.UnseenCount = UnseenCount;

    if (this.IsParameterBound(nameof(UnseenMessagesCount)))
        body.UnseenMessagesCount = UnseenMessagesCount;

    if (this.IsParameterBound(nameof(Visibility)))
        body.Visibility = Visibility;

    if (this.IsParameterBound(nameof(WelcomeMessageEnabled)))
        body.WelcomeMessageEnabled = WelcomeMessageEnabled;

    if (this.IsParameterBound(nameof(AccessType)))
        body.AccessType = AccessType;

    if (this.IsParameterBound(nameof(AssignedLabels)))
        body.AssignedLabels = AssignedLabels!.ToList();

    if (this.IsParameterBound(nameof(AssignedLicenses)))
        body.AssignedLicenses = AssignedLicenses!.ToList();

    if (this.IsParameterBound(nameof(LicenseProcessingState)))
        body.LicenseProcessingState = LicenseProcessingState;

    if (this.IsParameterBound(nameof(OnPremisesExtensionAttributes)))
        body.OnPremisesExtensionAttributes = OnPremisesExtensionAttributes;

    if (this.IsParameterBound(nameof(OnPremisesProvisioningErrors)))
        body.OnPremisesProvisioningErrors = OnPremisesProvisioningErrors!.ToList();

    if (this.IsParameterBound(nameof(ServiceProvisioningErrors)))
        body.ServiceProvisioningErrors = ServiceProvisioningErrors!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.Group? result;
            try
            {
                result = client.Groups[GroupId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, GroupId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
