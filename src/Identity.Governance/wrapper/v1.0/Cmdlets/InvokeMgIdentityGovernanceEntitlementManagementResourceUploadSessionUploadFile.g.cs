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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/resources/{accessPackageResource-id}/uploadSessions/{customDataProvidedResourceUploadSession-id}/uploadFile")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgIdentityGovernanceEntitlementManagementResourceUploadSessionUploadFile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomDataProvidedResourceUploadSession))]
    public class InvokeMgIdentityGovernanceEntitlementManagementResourceUploadSessionUploadFileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
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
                result = client.IdentityGovernance.EntitlementManagement.Resources[AccessPackageResourceId].UploadSessions[CustomDataProvidedResourceUploadSessionId].UploadFile.PostAsync(requestConfiguration =>
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
