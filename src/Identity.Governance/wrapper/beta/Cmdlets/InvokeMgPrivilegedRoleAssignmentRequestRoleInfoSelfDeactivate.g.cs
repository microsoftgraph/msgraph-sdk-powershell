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
    [GraphRoute("POST", "/privilegedRoleAssignmentRequests/{privilegedRoleAssignmentRequest-id}/roleInfo/selfDeactivate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgPrivilegedRoleAssignmentRequestRoleInfoSelfDeactivate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignment))]
    public class InvokeMgPrivilegedRoleAssignmentRequestRoleInfoSelfDeactivateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedRoleAssignmentRequestId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrivilegedRoleAssignmentRequestId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignment? result;
            try
            {
                result = client.PrivilegedRoleAssignmentRequests[PrivilegedRoleAssignmentRequestId].RoleInfo.SelfDeactivate.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrivilegedRoleAssignmentRequestId);
                return;
            }

            WriteObject(result);
        }
    }
}
