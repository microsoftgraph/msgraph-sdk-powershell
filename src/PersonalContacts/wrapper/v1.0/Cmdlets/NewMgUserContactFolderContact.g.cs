#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.PersonalContacts.Client;
using Microsoft.Graph.PowerShell.PersonalContacts.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.PersonalContacts
{
    [GraphRoute("POST", "/users/{user-id}/contactFolders/{contactFolder-id}/contacts")]
    [Cmdlet(VerbsCommon.New, "MgUserContactFolderContact", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.Contact))]
    public class NewMgUserContactFolderContactCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContactFolderId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Categories { get; set; }

        [Parameter(Mandatory = false)]
        public string? ChangeKey { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? AssistantName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? Birthday { get; set; }

        [Parameter(Mandatory = false)]
        public string? BusinessHomePage { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? BusinessPhones { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Children { get; set; }

        [Parameter(Mandatory = false)]
        public string? CompanyName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Department { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? FileAs { get; set; }

        [Parameter(Mandatory = false)]
        public string? Generation { get; set; }

        [Parameter(Mandatory = false)]
        public string? GivenName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? HomePhones { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ImAddresses { get; set; }

        [Parameter(Mandatory = false)]
        public string? Initials { get; set; }

        [Parameter(Mandatory = false)]
        public string? JobTitle { get; set; }

        [Parameter(Mandatory = false)]
        public string? Manager { get; set; }

        [Parameter(Mandatory = false)]
        public string? MiddleName { get; set; }

        [Parameter(Mandatory = false)]
        public string? MobilePhone { get; set; }

        [Parameter(Mandatory = false)]
        public string? NickName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OfficeLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? ParentFolderId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PersonalNotes { get; set; }

        [Parameter(Mandatory = false)]
        public string? Profession { get; set; }

        [Parameter(Mandatory = false)]
        public string? SpouseName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Surname { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public string? YomiCompanyName { get; set; }

        [Parameter(Mandatory = false)]
        public string? YomiGivenName { get; set; }

        [Parameter(Mandatory = false)]
        public string? YomiSurname { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.PhysicalAddress? BusinessAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.EmailAddress[]? EmailAddresses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.PhysicalAddress? HomeAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.PhysicalAddress? OtherAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.EmailAddress? PrimaryEmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.EmailAddress? SecondaryEmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.EmailAddress? TertiaryEmailAddress { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ContactFolderId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.Contact();

    if (this.IsParameterBound(nameof(Categories)))
        body.Categories = Categories!.ToList();

    if (this.IsParameterBound(nameof(ChangeKey)))
        body.ChangeKey = ChangeKey;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(AssistantName)))
        body.AssistantName = AssistantName;

    if (this.IsParameterBound(nameof(Birthday)))
        body.Birthday = Birthday;

    if (this.IsParameterBound(nameof(BusinessHomePage)))
        body.BusinessHomePage = BusinessHomePage;

    if (this.IsParameterBound(nameof(BusinessPhones)))
        body.BusinessPhones = BusinessPhones!.ToList();

    if (this.IsParameterBound(nameof(Children)))
        body.Children = Children!.ToList();

    if (this.IsParameterBound(nameof(CompanyName)))
        body.CompanyName = CompanyName;

    if (this.IsParameterBound(nameof(Department)))
        body.Department = Department;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(FileAs)))
        body.FileAs = FileAs;

    if (this.IsParameterBound(nameof(Generation)))
        body.Generation = Generation;

    if (this.IsParameterBound(nameof(GivenName)))
        body.GivenName = GivenName;

    if (this.IsParameterBound(nameof(HomePhones)))
        body.HomePhones = HomePhones!.ToList();

    if (this.IsParameterBound(nameof(ImAddresses)))
        body.ImAddresses = ImAddresses!.ToList();

    if (this.IsParameterBound(nameof(Initials)))
        body.Initials = Initials;

    if (this.IsParameterBound(nameof(JobTitle)))
        body.JobTitle = JobTitle;

    if (this.IsParameterBound(nameof(Manager)))
        body.Manager = Manager;

    if (this.IsParameterBound(nameof(MiddleName)))
        body.MiddleName = MiddleName;

    if (this.IsParameterBound(nameof(MobilePhone)))
        body.MobilePhone = MobilePhone;

    if (this.IsParameterBound(nameof(NickName)))
        body.NickName = NickName;

    if (this.IsParameterBound(nameof(OfficeLocation)))
        body.OfficeLocation = OfficeLocation;

    if (this.IsParameterBound(nameof(ParentFolderId)))
        body.ParentFolderId = ParentFolderId;

    if (this.IsParameterBound(nameof(PersonalNotes)))
        body.PersonalNotes = PersonalNotes;

    if (this.IsParameterBound(nameof(Profession)))
        body.Profession = Profession;

    if (this.IsParameterBound(nameof(SpouseName)))
        body.SpouseName = SpouseName;

    if (this.IsParameterBound(nameof(Surname)))
        body.Surname = Surname;

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(YomiCompanyName)))
        body.YomiCompanyName = YomiCompanyName;

    if (this.IsParameterBound(nameof(YomiGivenName)))
        body.YomiGivenName = YomiGivenName;

    if (this.IsParameterBound(nameof(YomiSurname)))
        body.YomiSurname = YomiSurname;

    if (this.IsParameterBound(nameof(BusinessAddress)))
        body.BusinessAddress = BusinessAddress;

    if (this.IsParameterBound(nameof(EmailAddresses)))
        body.EmailAddresses = EmailAddresses!.ToList();

    if (this.IsParameterBound(nameof(HomeAddress)))
        body.HomeAddress = HomeAddress;

    if (this.IsParameterBound(nameof(OtherAddress)))
        body.OtherAddress = OtherAddress;

    if (this.IsParameterBound(nameof(PrimaryEmailAddress)))
        body.PrimaryEmailAddress = PrimaryEmailAddress;

    if (this.IsParameterBound(nameof(SecondaryEmailAddress)))
        body.SecondaryEmailAddress = SecondaryEmailAddress;

    if (this.IsParameterBound(nameof(TertiaryEmailAddress)))
        body.TertiaryEmailAddress = TertiaryEmailAddress;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.Contact? result;
            try
            {
                result = client.Users[UserId].ContactFolders[ContactFolderId].Contacts.PostAsync(body, requestConfiguration =>
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
