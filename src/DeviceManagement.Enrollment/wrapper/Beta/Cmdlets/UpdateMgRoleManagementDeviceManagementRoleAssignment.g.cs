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
    [GraphRoute("PATCH", "/roleManagement/deviceManagement/roleAssignments/{unifiedRoleAssignmentMultiple-id}")]
    [Cmdlet(VerbsData.Update, "MgRoleManagementDeviceManagementRoleAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UnifiedRoleAssignmentMultiple))]
    public class UpdateMgRoleManagementDeviceManagementRoleAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UnifiedRoleAssignmentMultipleId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? AppScopeIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? Condition { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? DirectoryScopeIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? PrincipalIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleDefinitionId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UnifiedRoleAssignmentMultipleId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UnifiedRoleAssignmentMultiple();

    if (this.IsParameterBound(nameof(AppScopeIds)))
        body.AppScopeIds = AppScopeIds!.ToList();

    if (this.IsParameterBound(nameof(Condition)))
        body.Condition = Condition;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DirectoryScopeIds)))
        body.DirectoryScopeIds = DirectoryScopeIds!.ToList();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(PrincipalIds)))
        body.PrincipalIds = PrincipalIds!.ToList();

    if (this.IsParameterBound(nameof(RoleDefinitionId)))
        body.RoleDefinitionId = RoleDefinitionId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UnifiedRoleAssignmentMultiple? result;
            try
            {
                result = client.RoleManagement.DeviceManagement.RoleAssignments[UnifiedRoleAssignmentMultipleId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UnifiedRoleAssignmentMultipleId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.RoleManagement.DeviceManagement.RoleAssignments[UnifiedRoleAssignmentMultipleId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UnifiedRoleAssignmentMultipleId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
