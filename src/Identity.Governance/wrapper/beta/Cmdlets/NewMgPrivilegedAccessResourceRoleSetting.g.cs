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
    [GraphRoute("POST", "/privilegedAccess/{privilegedAccess-id}/resources/{governanceResource-id}/roleSettings")]
    [Cmdlet(VerbsCommon.New, "MgPrivilegedAccessResourceRoleSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRoleSetting))]
    public class NewMgPrivilegedAccessResourceRoleSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedAccessId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string GovernanceResourceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsDefault { get; set; }

        [Parameter(Mandatory = false)]
        public string? LastUpdatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRuleSetting[]? AdminEligibleSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRuleSetting[]? AdminMemberSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRuleSetting[]? UserEligibleSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRuleSetting[]? UserMemberSettings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GovernanceResourceId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRoleSetting();

    if (this.IsParameterBound(nameof(IsDefault)))
        body.IsDefault = IsDefault;

    if (this.IsParameterBound(nameof(LastUpdatedBy)))
        body.LastUpdatedBy = LastUpdatedBy;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(ResourceId)))
        body.ResourceId = ResourceId;

    if (this.IsParameterBound(nameof(RoleDefinitionId)))
        body.RoleDefinitionId = RoleDefinitionId;

    if (this.IsParameterBound(nameof(AdminEligibleSettings)))
        body.AdminEligibleSettings = AdminEligibleSettings!.ToList();

    if (this.IsParameterBound(nameof(AdminMemberSettings)))
        body.AdminMemberSettings = AdminMemberSettings!.ToList();

    if (this.IsParameterBound(nameof(UserEligibleSettings)))
        body.UserEligibleSettings = UserEligibleSettings!.ToList();

    if (this.IsParameterBound(nameof(UserMemberSettings)))
        body.UserMemberSettings = UserMemberSettings!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRoleSetting? result;
            try
            {
                result = client.PrivilegedAccess[PrivilegedAccessId].Resources[GovernanceResourceId].RoleSettings.PostAsync(body, requestConfiguration =>
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
