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
    [GraphRoute("PATCH", "/groups/{group-id}/team/tags/{teamworkTag-id}/members/{teamworkTagMember-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupTeamTagMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkTagMember))]
    public class UpdateMgGroupTeamTagMemberCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TeamworkTagId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TeamworkTagMemberId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamworkTagMemberId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkTagMember();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkTagMember? result;
            try
            {
                result = client.Groups[GroupId].Team.Tags[TeamworkTagId].Members[TeamworkTagMemberId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TeamworkTagMemberId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Team.Tags[TeamworkTagId].Members[TeamworkTagMemberId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, TeamworkTagMemberId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
