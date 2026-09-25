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
    [GraphRoute("PATCH", "/directory/tenantGovernance/governanceInvitations/{governanceInvitation-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryTenantGovernanceInvitation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.GovernanceInvitation))]
    public class UpdateMgDirectoryTenantGovernanceInvitationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GovernanceInvitationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? GovernedTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? GovernedTenantName { get; set; }

        [Parameter(Mandatory = false)]
        public string? GoverningTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? GoverningTenantName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GovernanceInvitationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.GovernanceInvitation();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(GovernedTenantId)))
        body.GovernedTenantId = GovernedTenantId;

    if (this.IsParameterBound(nameof(GovernedTenantName)))
        body.GovernedTenantName = GovernedTenantName;

    if (this.IsParameterBound(nameof(GoverningTenantId)))
        body.GoverningTenantId = GoverningTenantId;

    if (this.IsParameterBound(nameof(GoverningTenantName)))
        body.GoverningTenantName = GoverningTenantName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.GovernanceInvitation? result;
            try
            {
                result = client.Directory.TenantGovernance.GovernanceInvitations[GovernanceInvitationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GovernanceInvitationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.TenantGovernance.GovernanceInvitations[GovernanceInvitationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, GovernanceInvitationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
