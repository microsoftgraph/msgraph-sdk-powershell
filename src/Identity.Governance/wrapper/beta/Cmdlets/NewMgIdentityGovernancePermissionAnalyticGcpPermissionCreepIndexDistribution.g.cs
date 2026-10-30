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
    [GraphRoute("POST", "/identityGovernance/permissionsAnalytics/gcp/permissionsCreepIndexDistributions")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernancePermissionAnalyticGcpPermissionCreepIndexDistribution", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PermissionsCreepIndexDistribution))]
    public class NewMgIdentityGovernancePermissionAnalyticGcpPermissionCreepIndexDistributionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.RiskProfile? HighRiskProfile { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.RiskProfile? LowRiskProfile { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.RiskProfile? MediumRiskProfile { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AuthorizationSystem? AuthorizationSystem { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PermissionsCreepIndexDistribution();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(HighRiskProfile)))
        body.HighRiskProfile = HighRiskProfile;

    if (this.IsParameterBound(nameof(LowRiskProfile)))
        body.LowRiskProfile = LowRiskProfile;

    if (this.IsParameterBound(nameof(MediumRiskProfile)))
        body.MediumRiskProfile = MediumRiskProfile;

    if (this.IsParameterBound(nameof(AuthorizationSystem)))
        body.AuthorizationSystem = AuthorizationSystem;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PermissionsCreepIndexDistribution? result;
            try
            {
                result = client.IdentityGovernance.PermissionsAnalytics.Gcp.PermissionsCreepIndexDistributions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
