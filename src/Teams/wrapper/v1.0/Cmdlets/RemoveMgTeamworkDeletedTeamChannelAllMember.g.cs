#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/teamwork/deletedTeams/{deletedTeam-id}/channels/{channel-id}/allMembers/remove")]
    [Cmdlet(VerbsCommon.Remove, "MgTeamworkDeletedTeamChannelAllMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Teams.Client.Teamwork.DeletedTeams.Item.Channels.Item.AllMembers.Remove.RemovePostResponse))]
    public class RemoveMgTeamworkDeletedTeamChannelAllMemberCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeletedTeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChannelId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ConversationMember[]? Values { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChannelId, "Remove"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Teamwork.DeletedTeams.Item.Channels.Item.AllMembers.Remove.RemovePostRequestBody();

    if (this.IsParameterBound(nameof(Values)))
        body.Values = Values!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Teams.Client.Teamwork.DeletedTeams.Item.Channels.Item.AllMembers.Remove.RemovePostResponse? result;
            try
            {
                result = client.Teamwork.DeletedTeams[DeletedTeamId].Channels[ChannelId].AllMembers.Remove.PostAsRemovePostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ChannelId);
                return;
            }

            WriteObject(result);
        }
    }
}
