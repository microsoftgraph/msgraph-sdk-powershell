#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/resourceRoleScopes/{accessPackageResourceRoleScope-id}/role/resource/uploadSessions")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernanceEntitlementManagementResourceRoleScopeRoleResourceUploadSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourceUploadSession))]
    public class NewMgIdentityGovernanceEntitlementManagementResourceRoleScopeRoleResourceUploadSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceRoleScopeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsUploadDone { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReferenceId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourcePayloads.Data? Data { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourceUploadStats? Stats { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourceUploadStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageResourceRoleScopeId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourceUploadSession();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(IsUploadDone)))
        body.IsUploadDone = IsUploadDone;

    if (this.IsParameterBound(nameof(ReferenceId)))
        body.ReferenceId = ReferenceId;

    if (this.IsParameterBound(nameof(Data)))
        body.Data = Data;

    if (this.IsParameterBound(nameof(Stats)))
        body.Stats = Stats;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourceUploadSession? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.ResourceRoleScopes[AccessPackageResourceRoleScopeId].Role.Resource.UploadSessions.PostAsync(body, requestConfiguration =>
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
