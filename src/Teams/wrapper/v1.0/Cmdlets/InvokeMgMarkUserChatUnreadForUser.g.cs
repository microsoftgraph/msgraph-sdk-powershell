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
    [GraphRoute("POST", "/users/{user-id}/chats/{chat-id}/markChatUnreadForUser")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgMarkUserChatUnreadForUser", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgMarkUserChatUnreadForUserCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChatId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastMessageReadDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkUserIdentity? User { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Users.Item.Chats.Item.MarkChatUnreadForUser.MarkChatUnreadForUserPostRequestBody();

    if (this.IsParameterBound(nameof(LastMessageReadDateTime)))
        body.LastMessageReadDateTime = LastMessageReadDateTime;
    if (this.IsParameterBound(nameof(User)))
        body.User = User;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].Chats[ChatId].MarkChatUnreadForUser.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ChatId);
                return;
            }

        }
    }
}
