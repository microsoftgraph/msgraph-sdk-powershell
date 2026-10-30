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
    [GraphRoute("POST", "/directory/tenantGovernance/governanceRelationships")]
    [Cmdlet(VerbsCommon.New, "MgDirectoryTenantGovernanceRelationship", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.GovernanceRelationship))]
    public class NewMgDirectoryTenantGovernanceRelationshipCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? GovernedTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? GovernedTenantName { get; set; }

        [Parameter(Mandatory = false)]
        public string? GoverningTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? GoverningTenantName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RelationshipCreationType? CreatedType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RelationshipPolicy? PolicySnapshot { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RelationshipStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.GovernanceRelationship();

    if (this.IsParameterBound(nameof(CreationDateTime)))
        body.CreationDateTime = CreationDateTime;

    if (this.IsParameterBound(nameof(GovernedTenantId)))
        body.GovernedTenantId = GovernedTenantId;

    if (this.IsParameterBound(nameof(GovernedTenantName)))
        body.GovernedTenantName = GovernedTenantName;

    if (this.IsParameterBound(nameof(GoverningTenantId)))
        body.GoverningTenantId = GoverningTenantId;

    if (this.IsParameterBound(nameof(GoverningTenantName)))
        body.GoverningTenantName = GoverningTenantName;

    if (this.IsParameterBound(nameof(CreatedType)))
        body.CreatedType = CreatedType;

    if (this.IsParameterBound(nameof(PolicySnapshot)))
        body.PolicySnapshot = PolicySnapshot;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.GovernanceRelationship? result;
            try
            {
                result = client.Directory.TenantGovernance.GovernanceRelationships.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
