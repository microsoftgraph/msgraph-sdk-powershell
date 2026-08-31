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
    [GraphRoute("DELETE", "/identityGovernance/entitlementManagement/resourceRequests/{accessPackageResourceRequest-id}/resource/scopes/{accessPackageResourceScope-id}/resource/uploadSessions/{customDataProvidedResourceUploadSession-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgIdentityGovernanceEntitlementManagementResourceRequestResourceScopeResourceUploadSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgIdentityGovernanceEntitlementManagementResourceRequestResourceScopeResourceUploadSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceRequestId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessPackageResourceScopeId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CustomDataProvidedResourceUploadSessionId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomDataProvidedResourceUploadSessionId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.IdentityGovernance.EntitlementManagement.ResourceRequests[AccessPackageResourceRequestId].Resource.Scopes[AccessPackageResourceScopeId].Resource.UploadSessions[CustomDataProvidedResourceUploadSessionId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CustomDataProvidedResourceUploadSessionId);
                return;
            }
        }
    }
}
