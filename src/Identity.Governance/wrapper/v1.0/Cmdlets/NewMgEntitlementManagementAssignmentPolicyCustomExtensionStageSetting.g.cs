#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/assignmentPolicies/{accessPackageAssignmentPolicy-id}/customExtensionStageSettings")]
    [Cmdlet(VerbsCommon.New, "MgEntitlementManagementAssignmentPolicyCustomExtensionStageSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomExtensionStageSetting))]
    public class NewMgEntitlementManagementAssignmentPolicyCustomExtensionStageSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageAssignmentPolicyId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageCustomExtensionStage? Stage { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageAssignmentPolicyId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomExtensionStageSetting();


    if (this.IsParameterBound(nameof(Stage)))
        body.Stage = Stage;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomExtensionStageSetting? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.AssignmentPolicies[AccessPackageAssignmentPolicyId].CustomExtensionStageSettings.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
