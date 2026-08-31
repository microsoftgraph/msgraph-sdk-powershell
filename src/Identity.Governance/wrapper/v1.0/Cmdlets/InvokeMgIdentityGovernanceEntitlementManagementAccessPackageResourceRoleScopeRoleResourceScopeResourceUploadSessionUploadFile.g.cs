#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/accessPackages/{accessPackage-id}/resourceRoleScopes/{accessPackageResourceRoleScope-id}/role/resource/scopes/{accessPackageResourceScope-id}/resource/uploadSessions/{customDataProvidedResourceUploadSession-id}/uploadFile")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgIdentityGovernanceEntitlementManagementAccessPackageResourceRoleScopeRoleResourceScopeResourceUploadSessionUploadFile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourceUploadSession))]
    public class InvokeMgIdentityGovernanceEntitlementManagementAccessPackageResourceRoleScopeRoleResourceScopeResourceUploadSessionUploadFileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessPackageResourceRoleScopeId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AccessPackageResourceScopeId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string CustomDataProvidedResourceUploadSessionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomDataProvidedResourceUploadSessionId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourceUploadSession? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.AccessPackages[AccessPackageId].ResourceRoleScopes[AccessPackageResourceRoleScopeId].Role.Resource.Scopes[AccessPackageResourceScopeId].Resource.UploadSessions[CustomDataProvidedResourceUploadSessionId].UploadFile.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CustomDataProvidedResourceUploadSessionId);
                return;
            }

            WriteObject(result);
        }
    }
}
