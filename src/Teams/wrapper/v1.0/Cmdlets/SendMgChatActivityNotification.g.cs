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
    [GraphRoute("POST", "/chats/{chat-id}/sendActivityNotification")]
    [Cmdlet(VerbsCommunications.Send, "MgChatActivityNotification", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SendMgChatActivityNotificationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ChatId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ActivityType { get; set; }

        [Parameter(Mandatory = false)]
        public long? ChainId { get; set; }

        [Parameter(Mandatory = false)]
        public string? TeamsAppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? IconId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkActivityTopic? Topic { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ItemBody? PreviewText { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.KeyValuePair[]? TemplateParameters { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkNotificationRecipient? Recipient { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatId, "Send"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Chats.Item.SendActivityNotification.SendActivityNotificationPostRequestBody();

    if (this.IsParameterBound(nameof(ActivityType)))
        body.ActivityType = ActivityType;

    if (this.IsParameterBound(nameof(ChainId)))
        body.ChainId = ChainId;

    if (this.IsParameterBound(nameof(TeamsAppId)))
        body.TeamsAppId = TeamsAppId;

    if (this.IsParameterBound(nameof(IconId)))
        body.IconId = IconId;
    if (this.IsParameterBound(nameof(Topic)))
        body.Topic = Topic;

    if (this.IsParameterBound(nameof(PreviewText)))
        body.PreviewText = PreviewText;

    if (this.IsParameterBound(nameof(TemplateParameters)))
        body.TemplateParameters = TemplateParameters!.ToList();

    if (this.IsParameterBound(nameof(Recipient)))
        body.Recipient = Recipient;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Chats[ChatId].SendActivityNotification.PostAsync(body, requestConfiguration =>
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
