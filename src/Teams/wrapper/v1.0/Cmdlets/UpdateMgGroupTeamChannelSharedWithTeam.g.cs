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
    [GraphRoute("PATCH", "/groups/{group-id}/team/channels/{channel-id}/sharedWithTeams/{sharedWithChannelTeamInfo-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupTeamChannelSharedWithTeam", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.SharedWithChannelTeamInfo))]
    public class UpdateMgGroupTeamChannelSharedWithTeamCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChannelId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SharedWithChannelTeamInfoId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsHostTeam { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SharedWithChannelTeamInfoId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.SharedWithChannelTeamInfo();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(IsHostTeam)))
        body.IsHostTeam = IsHostTeam;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.SharedWithChannelTeamInfo? result;
            try
            {
                result = client.Groups[GroupId].Team.Channels[ChannelId].SharedWithTeams[SharedWithChannelTeamInfoId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, SharedWithChannelTeamInfoId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Team.Channels[ChannelId].SharedWithTeams[SharedWithChannelTeamInfoId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, SharedWithChannelTeamInfoId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
