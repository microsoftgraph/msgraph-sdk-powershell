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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/assignmentRequests/{accessPackageAssignmentRequest-id}/resume")]
    [Cmdlet(VerbsLifecycle.Resume, "MgEntitlementManagementAssignmentRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class ResumeMgEntitlementManagementAssignmentRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageAssignmentRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Source { get; set; }

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomExtensionData? Data { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageAssignmentRequestId, "Resume"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.EntitlementManagement.AssignmentRequests.Item.Resume.ResumePostRequestBody();

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;
    if (this.IsParameterBound(nameof(Data)))
        body.Data = Data;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.EntitlementManagement.AssignmentRequests[AccessPackageAssignmentRequestId].Resume.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AccessPackageAssignmentRequestId);
                return;
            }

        }
    }
}
