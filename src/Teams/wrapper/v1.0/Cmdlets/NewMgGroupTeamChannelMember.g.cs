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
    [GraphRoute("POST", "/groups/{group-id}/team/channels/{channel-id}/allMembers")]
    [Cmdlet(VerbsCommon.New, "MgGroupTeamChannelMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.ConversationMember))]
    public class NewMgGroupTeamChannelMemberCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChannelId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Roles { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? VisibleHistoryStartDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChannelId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.ConversationMember();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Roles)))
        body.Roles = Roles!.ToList();

    if (this.IsParameterBound(nameof(VisibleHistoryStartDateTime)))
        body.VisibleHistoryStartDateTime = VisibleHistoryStartDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.ConversationMember? result;
            try
            {
                result = client.Groups[GroupId].Team.Channels[ChannelId].AllMembers.PostAsync(body, requestConfiguration =>
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
