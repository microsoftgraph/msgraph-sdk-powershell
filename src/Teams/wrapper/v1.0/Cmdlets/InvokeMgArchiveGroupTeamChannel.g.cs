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
    [GraphRoute("POST", "/groups/{group-id}/team/channels/{channel-id}/archive")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgArchiveGroupTeamChannel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgArchiveGroupTeamChannelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChannelId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? ShouldSetSpoSiteReadOnlyForMembers { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChannelId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Groups.Item.Team.Channels.Item.Archive.ArchivePostRequestBody();

    if (this.IsParameterBound(nameof(ShouldSetSpoSiteReadOnlyForMembers)))
        body.ShouldSetSpoSiteReadOnlyForMembers = ShouldSetSpoSiteReadOnlyForMembers;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Groups[GroupId].Team.Channels[ChannelId].Archive.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ChannelId);
                return;
            }

        }
    }
}
