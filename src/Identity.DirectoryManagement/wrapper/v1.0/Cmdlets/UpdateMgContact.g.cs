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
    [GraphRoute("PATCH", "/contacts/{orgContact-id}")]
    [Cmdlet(VerbsData.Update, "MgContact", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrgContact))]
    public class UpdateMgContactCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrgContactId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? CompanyName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Department { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? GivenName { get; set; }

        [Parameter(Mandatory = false)]
        public string? JobTitle { get; set; }

        [Parameter(Mandatory = false)]
        public string? Mail { get; set; }

        [Parameter(Mandatory = false)]
        public string? MailNickname { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OnPremisesSyncEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ProxyAddresses { get; set; }

        [Parameter(Mandatory = false)]
        public string? Surname { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.PhysicalOfficeAddress[]? Addresses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OnPremisesProvisioningError[]? OnPremisesProvisioningErrors { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Phone[]? Phones { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ServiceProvisioningError[]? ServiceProvisioningErrors { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrgContactId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrgContact();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(CompanyName)))
        body.CompanyName = CompanyName;

    if (this.IsParameterBound(nameof(Department)))
        body.Department = Department;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(GivenName)))
        body.GivenName = GivenName;

    if (this.IsParameterBound(nameof(JobTitle)))
        body.JobTitle = JobTitle;

    if (this.IsParameterBound(nameof(Mail)))
        body.Mail = Mail;

    if (this.IsParameterBound(nameof(MailNickname)))
        body.MailNickname = MailNickname;

    if (this.IsParameterBound(nameof(OnPremisesLastSyncDateTime)))
        body.OnPremisesLastSyncDateTime = OnPremisesLastSyncDateTime;

    if (this.IsParameterBound(nameof(OnPremisesSyncEnabled)))
        body.OnPremisesSyncEnabled = OnPremisesSyncEnabled;

    if (this.IsParameterBound(nameof(ProxyAddresses)))
        body.ProxyAddresses = ProxyAddresses!.ToList();

    if (this.IsParameterBound(nameof(Surname)))
        body.Surname = Surname;

    if (this.IsParameterBound(nameof(Addresses)))
        body.Addresses = Addresses!.ToList();

    if (this.IsParameterBound(nameof(OnPremisesProvisioningErrors)))
        body.OnPremisesProvisioningErrors = OnPremisesProvisioningErrors!.ToList();

    if (this.IsParameterBound(nameof(Phones)))
        body.Phones = Phones!.ToList();

    if (this.IsParameterBound(nameof(ServiceProvisioningErrors)))
        body.ServiceProvisioningErrors = ServiceProvisioningErrors!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrgContact? result;
            try
            {
                result = client.Contacts[OrgContactId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, OrgContactId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Contacts[OrgContactId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, OrgContactId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
