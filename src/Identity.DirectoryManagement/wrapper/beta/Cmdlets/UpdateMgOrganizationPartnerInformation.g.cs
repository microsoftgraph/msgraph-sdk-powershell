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
    [GraphRoute("PATCH", "/organization/{organization-id}/partnerInformation")]
    [Cmdlet(VerbsData.Update, "MgOrganizationPartnerInformation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.PartnerInformation))]
    public class UpdateMgOrganizationPartnerInformationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrganizationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CommerceUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? CompanyName { get; set; }

        [Parameter(Mandatory = false)]
        public string? HelpUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? PartnerTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SupportEmails { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SupportTelephones { get; set; }

        [Parameter(Mandatory = false)]
        public string? SupportUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.PartnerTenantType? CompanyType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrganizationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.PartnerInformation();

    if (this.IsParameterBound(nameof(CommerceUrl)))
        body.CommerceUrl = CommerceUrl;

    if (this.IsParameterBound(nameof(CompanyName)))
        body.CompanyName = CompanyName;

    if (this.IsParameterBound(nameof(HelpUrl)))
        body.HelpUrl = HelpUrl;

    if (this.IsParameterBound(nameof(PartnerTenantId)))
        body.PartnerTenantId = PartnerTenantId;

    if (this.IsParameterBound(nameof(SupportEmails)))
        body.SupportEmails = SupportEmails!.ToList();

    if (this.IsParameterBound(nameof(SupportTelephones)))
        body.SupportTelephones = SupportTelephones!.ToList();

    if (this.IsParameterBound(nameof(SupportUrl)))
        body.SupportUrl = SupportUrl;

    if (this.IsParameterBound(nameof(CompanyType)))
        body.CompanyType = CompanyType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.PartnerInformation? result;
            try
            {
                result = client.Organization[OrganizationId].PartnerInformation.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OrganizationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Organization[OrganizationId].PartnerInformation.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
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
