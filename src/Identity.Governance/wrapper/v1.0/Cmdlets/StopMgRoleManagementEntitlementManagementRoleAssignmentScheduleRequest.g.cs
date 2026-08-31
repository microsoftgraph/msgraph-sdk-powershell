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
    [GraphRoute("POST", "/roleManagement/entitlementManagement/roleAssignmentScheduleRequests/{unifiedRoleAssignmentScheduleRequest-id}/cancel")]
    [Cmdlet(VerbsLifecycle.Stop, "MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class StopMgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UnifiedRoleAssignmentScheduleRequestId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UnifiedRoleAssignmentScheduleRequestId, "Stop"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.RoleManagement.EntitlementManagement.RoleAssignmentScheduleRequests[UnifiedRoleAssignmentScheduleRequestId].Cancel.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UnifiedRoleAssignmentScheduleRequestId);
                return;
            }

        }
    }
}
