#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("PATCH", "/groups/{group-id}/appRoleAssignments/{appRoleAssignment-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupAppRoleAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.AppRoleAssignment))]
    public class UpdateMgGroupAppRoleAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AppRoleAssignmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? AppRoleId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? PrincipalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalType { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? ResourceId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AppRoleAssignmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.AppRoleAssignment();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(AppRoleId)))
        body.AppRoleId = AppRoleId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(PrincipalDisplayName)))
        body.PrincipalDisplayName = PrincipalDisplayName;

    if (this.IsParameterBound(nameof(PrincipalId)))
        body.PrincipalId = PrincipalId;

    if (this.IsParameterBound(nameof(PrincipalType)))
        body.PrincipalType = PrincipalType;

    if (this.IsParameterBound(nameof(ResourceDisplayName)))
        body.ResourceDisplayName = ResourceDisplayName;

    if (this.IsParameterBound(nameof(ResourceId)))
        body.ResourceId = ResourceId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.AppRoleAssignment? result;
            try
            {
                result = client.Groups[GroupId].AppRoleAssignments[AppRoleAssignmentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AppRoleAssignmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].AppRoleAssignments[AppRoleAssignmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, AppRoleAssignmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
