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
    [GraphRoute("POST", "/roleManagement/directory/roleEligibilityScheduleInstances")]
    [Cmdlet(VerbsCommon.New, "MgRoleManagementDirectoryRoleEligibilityScheduleInstance", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleEligibilityScheduleInstance))]
    public class NewMgRoleManagementDirectoryRoleEligibilityScheduleInstanceCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AppScopeId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DirectoryScopeId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? MemberType { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleEligibilityScheduleId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleEligibilityScheduleInstance();

    if (this.IsParameterBound(nameof(AppScopeId)))
        body.AppScopeId = AppScopeId;

    if (this.IsParameterBound(nameof(DirectoryScopeId)))
        body.DirectoryScopeId = DirectoryScopeId;

    if (this.IsParameterBound(nameof(PrincipalId)))
        body.PrincipalId = PrincipalId;

    if (this.IsParameterBound(nameof(RoleDefinitionId)))
        body.RoleDefinitionId = RoleDefinitionId;

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(MemberType)))
        body.MemberType = MemberType;

    if (this.IsParameterBound(nameof(RoleEligibilityScheduleId)))
        body.RoleEligibilityScheduleId = RoleEligibilityScheduleId;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleEligibilityScheduleInstance? result;
            try
            {
                result = client.RoleManagement.Directory.RoleEligibilityScheduleInstances.PostAsync(body, requestConfiguration =>
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
