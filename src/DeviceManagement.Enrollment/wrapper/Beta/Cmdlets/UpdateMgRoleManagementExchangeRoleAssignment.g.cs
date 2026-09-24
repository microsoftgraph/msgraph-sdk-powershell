#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("PATCH", "/roleManagement/exchange/roleAssignments/{unifiedRoleAssignment-id}")]
    [Cmdlet(VerbsData.Update, "MgRoleManagementExchangeRoleAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UnifiedRoleAssignment))]
    public class UpdateMgRoleManagementExchangeRoleAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UnifiedRoleAssignmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppScopeId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Condition { get; set; }

        [Parameter(Mandatory = false)]
        public string? DirectoryScopeId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalOrganizationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceScope { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleDefinitionId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UnifiedRoleAssignmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UnifiedRoleAssignment();

    if (this.IsParameterBound(nameof(AppScopeId)))
        body.AppScopeId = AppScopeId;

    if (this.IsParameterBound(nameof(Condition)))
        body.Condition = Condition;

    if (this.IsParameterBound(nameof(DirectoryScopeId)))
        body.DirectoryScopeId = DirectoryScopeId;

    if (this.IsParameterBound(nameof(PrincipalId)))
        body.PrincipalId = PrincipalId;

    if (this.IsParameterBound(nameof(PrincipalOrganizationId)))
        body.PrincipalOrganizationId = PrincipalOrganizationId;

    if (this.IsParameterBound(nameof(ResourceScope)))
        body.ResourceScope = ResourceScope;

    if (this.IsParameterBound(nameof(RoleDefinitionId)))
        body.RoleDefinitionId = RoleDefinitionId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UnifiedRoleAssignment? result;
            try
            {
                result = client.RoleManagement.Exchange.RoleAssignments[UnifiedRoleAssignmentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UnifiedRoleAssignmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.RoleManagement.Exchange.RoleAssignments[UnifiedRoleAssignmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UnifiedRoleAssignmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
