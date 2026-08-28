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
    [GraphRoute("POST", "/teams/{team-id}/primaryChannel/allMembers/add")]
    [Cmdlet(VerbsCommon.Add, "MgTeamPrimaryChannelAllMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Teams.Client.Teams.Item.PrimaryChannel.AllMembers.Add.AddPostResponse))]
    public class AddMgTeamPrimaryChannelAllMemberCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ConversationMember[]? Values { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamId, "Add"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Teams.Item.PrimaryChannel.AllMembers.Add.AddPostRequestBody();

    if (this.IsParameterBound(nameof(Values)))
        body.Values = Values!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Teams.Client.Teams.Item.PrimaryChannel.AllMembers.Add.AddPostResponse? result;
            try
            {
                result = client.Teams[TeamId].PrimaryChannel.AllMembers.Add.PostAsAddPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TeamId);
                return;
            }

            WriteObject(result);
        }
    }
}
