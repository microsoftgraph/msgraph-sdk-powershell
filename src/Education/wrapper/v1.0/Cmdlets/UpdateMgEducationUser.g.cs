#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Education.Client;
using Microsoft.Graph.PowerShell.Education.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Education
{
    [GraphRoute("PATCH", "/education/users/{educationUser-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationUser", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationUser))]
    public class UpdateMgEducationUserCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationUserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? AccountEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? BusinessPhones { get; set; }

        [Parameter(Mandatory = false)]
        public string? Department { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalSourceDetail { get; set; }

        [Parameter(Mandatory = false)]
        public string? GivenName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Mail { get; set; }

        [Parameter(Mandatory = false)]
        public string? MailNickname { get; set; }

        [Parameter(Mandatory = false)]
        public string? MiddleName { get; set; }

        [Parameter(Mandatory = false)]
        public string? MobilePhone { get; set; }

        [Parameter(Mandatory = false)]
        public string? OfficeLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? PasswordPolicies { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredLanguage { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RefreshTokensValidFromDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowInAddressList { get; set; }

        [Parameter(Mandatory = false)]
        public string? Surname { get; set; }

        [Parameter(Mandatory = false)]
        public string? UsageLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.AssignedLicense[]? AssignedLicenses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.AssignedPlan[]? AssignedPlans { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationExternalSource? ExternalSource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.PhysicalAddress? MailingAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationOnPremisesInfo? OnPremisesInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.PasswordProfile? PasswordProfile { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationUserRole? PrimaryRole { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.ProvisionedPlan[]? ProvisionedPlans { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.RelatedContact[]? RelatedContacts { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.PhysicalAddress? ResidenceAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationStudent? Student { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationTeacher? Teacher { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationUserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationUser();

    if (this.IsParameterBound(nameof(AccountEnabled)))
        body.AccountEnabled = AccountEnabled;

    if (this.IsParameterBound(nameof(BusinessPhones)))
        body.BusinessPhones = BusinessPhones!.ToList();

    if (this.IsParameterBound(nameof(Department)))
        body.Department = Department;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExternalSourceDetail)))
        body.ExternalSourceDetail = ExternalSourceDetail;

    if (this.IsParameterBound(nameof(GivenName)))
        body.GivenName = GivenName;

    if (this.IsParameterBound(nameof(Mail)))
        body.Mail = Mail;

    if (this.IsParameterBound(nameof(MailNickname)))
        body.MailNickname = MailNickname;

    if (this.IsParameterBound(nameof(MiddleName)))
        body.MiddleName = MiddleName;

    if (this.IsParameterBound(nameof(MobilePhone)))
        body.MobilePhone = MobilePhone;

    if (this.IsParameterBound(nameof(OfficeLocation)))
        body.OfficeLocation = OfficeLocation;

    if (this.IsParameterBound(nameof(PasswordPolicies)))
        body.PasswordPolicies = PasswordPolicies;

    if (this.IsParameterBound(nameof(PreferredLanguage)))
        body.PreferredLanguage = PreferredLanguage;

    if (this.IsParameterBound(nameof(RefreshTokensValidFromDateTime)))
        body.RefreshTokensValidFromDateTime = RefreshTokensValidFromDateTime;

    if (this.IsParameterBound(nameof(ShowInAddressList)))
        body.ShowInAddressList = ShowInAddressList;

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

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(ExternalSource)))
        body.ExternalSource = ExternalSource;

    if (this.IsParameterBound(nameof(MailingAddress)))
        body.MailingAddress = MailingAddress;

    if (this.IsParameterBound(nameof(OnPremisesInfo)))
        body.OnPremisesInfo = OnPremisesInfo;

    if (this.IsParameterBound(nameof(PasswordProfile)))
        body.PasswordProfile = PasswordProfile;

    if (this.IsParameterBound(nameof(PrimaryRole)))
        body.PrimaryRole = PrimaryRole;

    if (this.IsParameterBound(nameof(ProvisionedPlans)))
        body.ProvisionedPlans = ProvisionedPlans!.ToList();

    if (this.IsParameterBound(nameof(RelatedContacts)))
        body.RelatedContacts = RelatedContacts!.ToList();

    if (this.IsParameterBound(nameof(ResidenceAddress)))
        body.ResidenceAddress = ResidenceAddress;

    if (this.IsParameterBound(nameof(Student)))
        body.Student = Student;

    if (this.IsParameterBound(nameof(Teacher)))
        body.Teacher = Teacher;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationUser? result;
            try
            {
                result = client.Education.Users[EducationUserId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, EducationUserId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Users[EducationUserId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, EducationUserId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
