#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("PATCH", "/groups/{group-id}/team/permissionGrants/{resourceSpecificPermissionGrant-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupTeamPermissionGrant", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.ResourceSpecificPermissionGrant))]
    public class UpdateMgGroupTeamPermissionGrantCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ResourceSpecificPermissionGrantId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClientAppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClientId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Permission { get; set; }

        [Parameter(Mandatory = false)]
        public string? PermissionType { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceAppId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ResourceSpecificPermissionGrantId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.ResourceSpecificPermissionGrant();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(ClientAppId)))
        body.ClientAppId = ClientAppId;

    if (this.IsParameterBound(nameof(ClientId)))
        body.ClientId = ClientId;

    if (this.IsParameterBound(nameof(Permission)))
        body.Permission = Permission;

    if (this.IsParameterBound(nameof(PermissionType)))
        body.PermissionType = PermissionType;

    if (this.IsParameterBound(nameof(ResourceAppId)))
        body.ResourceAppId = ResourceAppId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.ResourceSpecificPermissionGrant? result;
            try
            {
                result = client.Groups[GroupId].Team.PermissionGrants[ResourceSpecificPermissionGrantId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ResourceSpecificPermissionGrantId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Team.PermissionGrants[ResourceSpecificPermissionGrantId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ResourceSpecificPermissionGrantId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
