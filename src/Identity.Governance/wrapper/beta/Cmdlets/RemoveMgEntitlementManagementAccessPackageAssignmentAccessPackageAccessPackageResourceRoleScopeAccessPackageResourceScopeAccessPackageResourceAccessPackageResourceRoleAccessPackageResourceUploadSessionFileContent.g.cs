#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("DELETE", "/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment-id}/accessPackage/accessPackageResourceRoleScopes/{accessPackageResourceRoleScope-id}/accessPackageResourceScope/accessPackageResource/accessPackageResourceRoles/{accessPackageResourceRole-id}/accessPackageResource/uploadSessions/{customDataProvidedResourceUploadSession-id}/files/{customDataProvidedResourceFile-id}/$value")]
    [Cmdlet(VerbsCommon.Remove, "MgEntitlementManagementAccessPackageAssignmentAccessPackageAccessPackageResourceRoleScopeAccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoleAccessPackageResourceUploadSessionFileContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgEntitlementManagementAccessPackageAssignmentAccessPackageAccessPackageResourceRoleScopeAccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoleAccessPackageResourceUploadSessionFileContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageAssignmentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessPackageResourceRoleScopeId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AccessPackageResourceRoleId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string CustomDataProvidedResourceUploadSessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string CustomDataProvidedResourceFileId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomDataProvidedResourceFileId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.IdentityGovernance.EntitlementManagement.AccessPackageAssignments[AccessPackageAssignmentId].AccessPackage.AccessPackageResourceRoleScopes[AccessPackageResourceRoleScopeId].AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles[AccessPackageResourceRoleId].AccessPackageResource.UploadSessions[CustomDataProvidedResourceUploadSessionId].Files[CustomDataProvidedResourceFileId].Content.DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CustomDataProvidedResourceFileId);
                return;
            }
        }
    }
}
