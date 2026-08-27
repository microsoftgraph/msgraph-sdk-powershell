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
    [GraphRoute("POST", "/roleManagement/directory/roleEligibilitySchedules")]
    [Cmdlet(VerbsCommon.New, "MgRoleManagementDirectoryRoleEligibilitySchedule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleEligibilitySchedule))]
    public class NewMgRoleManagementDirectoryRoleEligibilityScheduleCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AppScopeId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? CreatedUsing { get; set; }

        [Parameter(Mandatory = false)]
        public string? DirectoryScopeId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public string? MemberType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.RequestSchedule? ScheduleInfo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleEligibilitySchedule();

    if (this.IsParameterBound(nameof(AppScopeId)))
        body.AppScopeId = AppScopeId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CreatedUsing)))
        body.CreatedUsing = CreatedUsing;

    if (this.IsParameterBound(nameof(DirectoryScopeId)))
        body.DirectoryScopeId = DirectoryScopeId;

    if (this.IsParameterBound(nameof(ModifiedDateTime)))
        body.ModifiedDateTime = ModifiedDateTime;

    if (this.IsParameterBound(nameof(PrincipalId)))
        body.PrincipalId = PrincipalId;

    if (this.IsParameterBound(nameof(RoleDefinitionId)))
        body.RoleDefinitionId = RoleDefinitionId;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(MemberType)))
        body.MemberType = MemberType;

    if (this.IsParameterBound(nameof(ScheduleInfo)))
        body.ScheduleInfo = ScheduleInfo;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleEligibilitySchedule? result;
            try
            {
                result = client.RoleManagement.Directory.RoleEligibilitySchedules.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
