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
    [GraphRoute("POST", "/chats/{chat-id}/startMigration")]
    [Cmdlet(VerbsLifecycle.Start, "MgChatMigration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class StartMgChatMigrationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ChatId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ConversationCreationDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatId, "Start"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Chats.Item.StartMigration.StartMigrationPostRequestBody();

    if (this.IsParameterBound(nameof(ConversationCreationDateTime)))
        body.ConversationCreationDateTime = ConversationCreationDateTime;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Chats[ChatId].StartMigration.PostAsync(body, requestConfiguration =>
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
