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
    [GraphRoute("POST", "/privilegedAccess/{privilegedAccess-id}/resources/{governanceResource-id}/roleAssignmentRequests/{governanceRoleAssignmentRequest-id}/cancel")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgPrivilegedAccessResourceRoleAssignmentRequestCancel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgPrivilegedAccessResourceRoleAssignmentRequestCancelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedAccessId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string GovernanceResourceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string GovernanceRoleAssignmentRequestId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GovernanceRoleAssignmentRequestId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.PrivilegedAccess[PrivilegedAccessId].Resources[GovernanceResourceId].RoleAssignmentRequests[GovernanceRoleAssignmentRequestId].Cancel.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GovernanceRoleAssignmentRequestId);
                return;
            }

        }
    }
}
