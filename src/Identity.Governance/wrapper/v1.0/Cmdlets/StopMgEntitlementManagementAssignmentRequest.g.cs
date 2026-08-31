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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/assignmentRequests/{accessPackageAssignmentRequest-id}/cancel")]
    [Cmdlet(VerbsLifecycle.Stop, "MgEntitlementManagementAssignmentRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class StopMgEntitlementManagementAssignmentRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageAssignmentRequestId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageAssignmentRequestId, "Stop"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.EntitlementManagement.AssignmentRequests[AccessPackageAssignmentRequestId].Cancel.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageAssignmentRequestId);
                return;
            }

        }
    }
}
