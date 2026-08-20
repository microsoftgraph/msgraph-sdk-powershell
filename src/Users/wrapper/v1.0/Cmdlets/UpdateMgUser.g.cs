#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("PATCH", "/users/{user-id}")]
    [Cmdlet(VerbsData.Update, "MgUser", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.User))]
    public class UpdateMgUserCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? AboutMe { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AccountEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? AgeGroup { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? Birthday { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? BusinessPhones { get; set; }

        [Parameter(Mandatory = false)]
        public string? City { get; set; }

        [Parameter(Mandatory = false)]
        public string? CompanyName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ConsentProvidedForMinor { get; set; }

        [Parameter(Mandatory = false)]
        public string? Country { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? CreationType { get; set; }

        [Parameter(Mandatory = false)]
        public string? Department { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeviceEnrollmentLimit { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EmployeeHireDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? EmployeeId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EmployeeLeaveDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? EmployeeType { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalUserState { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExternalUserStateChangeDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? FaxNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? GivenName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? HireDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? IdentityParentId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ImAddresses { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Interests { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsManagementRestricted { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsResourceAccount { get; set; }

        [Parameter(Mandatory = false)]
        public string? JobTitle { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastPasswordChangeDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? LegalAgeGroupClassification { get; set; }

        [Parameter(Mandatory = false)]
        public string? Mail { get; set; }

        [Parameter(Mandatory = false)]
        public string? MailNickname { get; set; }

        [Parameter(Mandatory = false)]
        public string? MobilePhone { get; set; }

        [Parameter(Mandatory = false)]
        public string? MySite { get; set; }

        [Parameter(Mandatory = false)]
        public string? OfficeLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesDistinguishedName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesDomainName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesImmutableId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesSamAccountName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesSecurityIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OnPremisesSyncEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesUserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? OtherMails { get; set; }

        [Parameter(Mandatory = false)]
        public string? PasswordPolicies { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? PastProjects { get; set; }

        [Parameter(Mandatory = false)]
        public string? PostalCode { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredDataLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredLanguage { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ProxyAddresses { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Responsibilities { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Schools { get; set; }

        [Parameter(Mandatory = false)]
        public string? SecurityIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowInAddressList { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? SignInSessionsValidFromDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Skills { get; set; }

        [Parameter(Mandatory = false)]
        public string? State { get; set; }

        [Parameter(Mandatory = false)]
        public string? StreetAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? Surname { get; set; }

        [Parameter(Mandatory = false)]
        public string? UsageLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.AssignedLicense[]? AssignedLicenses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.AssignedPlan[]? AssignedPlans { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.AuthorizationInfo? AuthorizationInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.CustomSecurityAttributeValue? CustomSecurityAttributes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.EmployeeOrgData? EmployeeOrgData { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.ObjectIdentity[]? Identities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.LicenseAssignmentState[]? LicenseAssignmentStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.MailboxSettings? MailboxSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.OnPremisesExtensionAttributes? OnPremisesExtensionAttributes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.OnPremisesProvisioningError[]? OnPremisesProvisioningErrors { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.PasswordProfile? PasswordProfile { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.UserPrint? Print { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.ProvisionedPlan[]? ProvisionedPlans { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.ServiceProvisioningError[]? ServiceProvisioningErrors { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.SignInActivity? SignInActivity { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.User();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(AboutMe)))
        body.AboutMe = AboutMe;

    if (this.IsParameterBound(nameof(AccountEnabled)))
        body.AccountEnabled = AccountEnabled;

    if (this.IsParameterBound(nameof(AgeGroup)))
        body.AgeGroup = AgeGroup;

    if (this.IsParameterBound(nameof(Birthday)))
        body.Birthday = Birthday;

    if (this.IsParameterBound(nameof(BusinessPhones)))
        body.BusinessPhones = BusinessPhones!.ToList();

    if (this.IsParameterBound(nameof(City)))
        body.City = City;

    if (this.IsParameterBound(nameof(CompanyName)))
        body.CompanyName = CompanyName;

    if (this.IsParameterBound(nameof(ConsentProvidedForMinor)))
        body.ConsentProvidedForMinor = ConsentProvidedForMinor;

    if (this.IsParameterBound(nameof(Country)))
        body.Country = Country;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CreationType)))
        body.CreationType = CreationType;

    if (this.IsParameterBound(nameof(Department)))
        body.Department = Department;

    if (this.IsParameterBound(nameof(DeviceEnrollmentLimit)))
        body.DeviceEnrollmentLimit = DeviceEnrollmentLimit;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EmployeeHireDate)))
        body.EmployeeHireDate = EmployeeHireDate;

    if (this.IsParameterBound(nameof(EmployeeId)))
        body.EmployeeId = EmployeeId;

    if (this.IsParameterBound(nameof(EmployeeLeaveDateTime)))
        body.EmployeeLeaveDateTime = EmployeeLeaveDateTime;

    if (this.IsParameterBound(nameof(EmployeeType)))
        body.EmployeeType = EmployeeType;

    if (this.IsParameterBound(nameof(ExternalUserState)))
        body.ExternalUserState = ExternalUserState;

    if (this.IsParameterBound(nameof(ExternalUserStateChangeDateTime)))
        body.ExternalUserStateChangeDateTime = ExternalUserStateChangeDateTime;

    if (this.IsParameterBound(nameof(FaxNumber)))
        body.FaxNumber = FaxNumber;

    if (this.IsParameterBound(nameof(GivenName)))
        body.GivenName = GivenName;

    if (this.IsParameterBound(nameof(HireDate)))
        body.HireDate = HireDate;

    if (this.IsParameterBound(nameof(IdentityParentId)))
        body.IdentityParentId = IdentityParentId;

    if (this.IsParameterBound(nameof(ImAddresses)))
        body.ImAddresses = ImAddresses!.ToList();

    if (this.IsParameterBound(nameof(Interests)))
        body.Interests = Interests!.ToList();

    if (this.IsParameterBound(nameof(IsManagementRestricted)))
        body.IsManagementRestricted = IsManagementRestricted;

    if (this.IsParameterBound(nameof(IsResourceAccount)))
        body.IsResourceAccount = IsResourceAccount;

    if (this.IsParameterBound(nameof(JobTitle)))
        body.JobTitle = JobTitle;

    if (this.IsParameterBound(nameof(LastPasswordChangeDateTime)))
        body.LastPasswordChangeDateTime = LastPasswordChangeDateTime;

    if (this.IsParameterBound(nameof(LegalAgeGroupClassification)))
        body.LegalAgeGroupClassification = LegalAgeGroupClassification;

    if (this.IsParameterBound(nameof(Mail)))
        body.Mail = Mail;

    if (this.IsParameterBound(nameof(MailNickname)))
        body.MailNickname = MailNickname;

    if (this.IsParameterBound(nameof(MobilePhone)))
        body.MobilePhone = MobilePhone;

    if (this.IsParameterBound(nameof(MySite)))
        body.MySite = MySite;

    if (this.IsParameterBound(nameof(OfficeLocation)))
        body.OfficeLocation = OfficeLocation;

    if (this.IsParameterBound(nameof(OnPremisesDistinguishedName)))
        body.OnPremisesDistinguishedName = OnPremisesDistinguishedName;

    if (this.IsParameterBound(nameof(OnPremisesDomainName)))
        body.OnPremisesDomainName = OnPremisesDomainName;

    if (this.IsParameterBound(nameof(OnPremisesImmutableId)))
        body.OnPremisesImmutableId = OnPremisesImmutableId;

    if (this.IsParameterBound(nameof(OnPremisesLastSyncDateTime)))
        body.OnPremisesLastSyncDateTime = OnPremisesLastSyncDateTime;

    if (this.IsParameterBound(nameof(OnPremisesSamAccountName)))
        body.OnPremisesSamAccountName = OnPremisesSamAccountName;

    if (this.IsParameterBound(nameof(OnPremisesSecurityIdentifier)))
        body.OnPremisesSecurityIdentifier = OnPremisesSecurityIdentifier;

    if (this.IsParameterBound(nameof(OnPremisesSyncEnabled)))
        body.OnPremisesSyncEnabled = OnPremisesSyncEnabled;

    if (this.IsParameterBound(nameof(OnPremisesUserPrincipalName)))
        body.OnPremisesUserPrincipalName = OnPremisesUserPrincipalName;

    if (this.IsParameterBound(nameof(OtherMails)))
        body.OtherMails = OtherMails!.ToList();

    if (this.IsParameterBound(nameof(PasswordPolicies)))
        body.PasswordPolicies = PasswordPolicies;

    if (this.IsParameterBound(nameof(PastProjects)))
        body.PastProjects = PastProjects!.ToList();

    if (this.IsParameterBound(nameof(PostalCode)))
        body.PostalCode = PostalCode;

    if (this.IsParameterBound(nameof(PreferredDataLocation)))
        body.PreferredDataLocation = PreferredDataLocation;

    if (this.IsParameterBound(nameof(PreferredLanguage)))
        body.PreferredLanguage = PreferredLanguage;

    if (this.IsParameterBound(nameof(PreferredName)))
        body.PreferredName = PreferredName;

    if (this.IsParameterBound(nameof(ProxyAddresses)))
        body.ProxyAddresses = ProxyAddresses!.ToList();

    if (this.IsParameterBound(nameof(Responsibilities)))
        body.Responsibilities = Responsibilities!.ToList();

    if (this.IsParameterBound(nameof(Schools)))
        body.Schools = Schools!.ToList();

    if (this.IsParameterBound(nameof(SecurityIdentifier)))
        body.SecurityIdentifier = SecurityIdentifier;

    if (this.IsParameterBound(nameof(ShowInAddressList)))
        body.ShowInAddressList = ShowInAddressList;

    if (this.IsParameterBound(nameof(SignInSessionsValidFromDateTime)))
        body.SignInSessionsValidFromDateTime = SignInSessionsValidFromDateTime;

    if (this.IsParameterBound(nameof(Skills)))
        body.Skills = Skills!.ToList();

    if (this.IsParameterBound(nameof(State)))
        body.State = State;

    if (this.IsParameterBound(nameof(StreetAddress)))
        body.StreetAddress = StreetAddress;

    if (this.IsParameterBound(nameof(Surname)))
        body.Surname = Surname;

    if (this.IsParameterBound(nameof(UsageLocation)))
        body.UsageLocation = UsageLocation;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(UserType)))
        body.UserType = UserType;

    if (this.IsParameterBound(nameof(AssignedLicenses)))
        body.AssignedLicenses = AssignedLicenses!.ToList();

    if (this.IsParameterBound(nameof(AssignedPlans)))
        body.AssignedPlans = AssignedPlans!.ToList();

    if (this.IsParameterBound(nameof(AuthorizationInfo)))
        body.AuthorizationInfo = AuthorizationInfo;

    if (this.IsParameterBound(nameof(CustomSecurityAttributes)))
        body.CustomSecurityAttributes = CustomSecurityAttributes;

    if (this.IsParameterBound(nameof(EmployeeOrgData)))
        body.EmployeeOrgData = EmployeeOrgData;

    if (this.IsParameterBound(nameof(Identities)))
        body.Identities = Identities!.ToList();

    if (this.IsParameterBound(nameof(LicenseAssignmentStates)))
        body.LicenseAssignmentStates = LicenseAssignmentStates!.ToList();

    if (this.IsParameterBound(nameof(MailboxSettings)))
        body.MailboxSettings = MailboxSettings;

    if (this.IsParameterBound(nameof(OnPremisesExtensionAttributes)))
        body.OnPremisesExtensionAttributes = OnPremisesExtensionAttributes;

    if (this.IsParameterBound(nameof(OnPremisesProvisioningErrors)))
        body.OnPremisesProvisioningErrors = OnPremisesProvisioningErrors!.ToList();

    if (this.IsParameterBound(nameof(PasswordProfile)))
        body.PasswordProfile = PasswordProfile;

    if (this.IsParameterBound(nameof(Print)))
        body.Print = Print;

    if (this.IsParameterBound(nameof(ProvisionedPlans)))
        body.ProvisionedPlans = ProvisionedPlans!.ToList();

    if (this.IsParameterBound(nameof(ServiceProvisioningErrors)))
        body.ServiceProvisioningErrors = ServiceProvisioningErrors!.ToList();

    if (this.IsParameterBound(nameof(SignInActivity)))
        body.SignInActivity = SignInActivity;


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

            Microsoft.Graph.PowerShell.Users.Client.Models.User? result;
            try
            {
                result = client.Users[UserId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, UserId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, UserId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
