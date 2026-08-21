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
    [GraphRoute("POST", "/users/{user-id}/teamwork/deleteTargetedMessage")]
    [Cmdlet(VerbsCommon.Remove, "MgUserTeamworkTargetedMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RemoveMgUserTeamworkTargetedMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? TeamId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ChannelId { get; set; }

        [Parameter(Mandatory = false)]
        public string? MessageId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Remove"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Users.Item.Teamwork.DeleteTargetedMessage.DeleteTargetedMessagePostRequestBody();

    if (this.IsParameterBound(nameof(TeamId)))
        body.TeamId = TeamId;

    if (this.IsParameterBound(nameof(ChannelId)))
        body.ChannelId = ChannelId;

    if (this.IsParameterBound(nameof(MessageId)))
        body.MessageId = MessageId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].Teamwork.DeleteTargetedMessage.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

        }
    }
}
