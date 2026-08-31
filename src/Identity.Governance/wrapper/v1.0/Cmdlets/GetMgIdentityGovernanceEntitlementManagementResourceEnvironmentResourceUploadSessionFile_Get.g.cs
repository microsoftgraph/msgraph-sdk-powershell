#nullable enable

using System;
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
    [GraphRoute("GET", "/identityGovernance/entitlementManagement/resourceEnvironments/{accessPackageResourceEnvironment-id}/resources/{accessPackageResource-id}/uploadSessions/{customDataProvidedResourceUploadSession-id}/files/{customDataProvidedResourceFile-id}")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityGovernanceEntitlementManagementResourceEnvironmentResourceUploadSessionFile_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourceFile))]
    public class GetMgIdentityGovernanceEntitlementManagementResourceEnvironmentResourceUploadSessionFile_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceEnvironmentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessPackageResourceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CustomDataProvidedResourceUploadSessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string CustomDataProvidedResourceFileId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourceFile? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.ResourceEnvironments[AccessPackageResourceEnvironmentId].Resources[AccessPackageResourceId].UploadSessions[CustomDataProvidedResourceUploadSessionId].Files[CustomDataProvidedResourceFileId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CustomDataProvidedResourceFileId);
                return;
            }

            WriteObject(result);
        }
    }
}
