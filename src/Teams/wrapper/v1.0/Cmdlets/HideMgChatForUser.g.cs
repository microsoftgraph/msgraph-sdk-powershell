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
    [GraphRoute("POST", "/chats/{chat-id}/hideForUser")]
    [Cmdlet(VerbsCommon.Hide, "MgChatForUser", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class HideMgChatForUserCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ChatId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkUserIdentity? User { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatId, "Hide"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Chats.Item.HideForUser.HideForUserPostRequestBody();

    if (this.IsParameterBound(nameof(User)))
        body.User = User;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Chats[ChatId].HideForUser.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ChatId);
                return;
            }

        }
    }
}
