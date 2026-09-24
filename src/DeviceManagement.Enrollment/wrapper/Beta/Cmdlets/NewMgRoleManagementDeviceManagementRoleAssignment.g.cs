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
    [GraphRoute("POST", "/roleManagement/deviceManagement/roleAssignments")]
    [Cmdlet(VerbsCommon.New, "MgRoleManagementDeviceManagementRoleAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UnifiedRoleAssignmentMultiple))]
    public class NewMgRoleManagementDeviceManagementRoleAssignmentCommand : GraphClientCmdlet
    {


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
            if (!ShouldProcess(null, "New"))
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
                result = client.RoleManagement.DeviceManagement.RoleAssignments.PostAsync(body, requestConfiguration =>
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
