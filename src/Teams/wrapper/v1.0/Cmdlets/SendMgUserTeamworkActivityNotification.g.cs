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
    [GraphRoute("POST", "/users/{user-id}/teamwork/sendActivityNotification")]
    [Cmdlet(VerbsCommunications.Send, "MgUserTeamworkActivityNotification", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SendMgUserTeamworkActivityNotificationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

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






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Send"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Users.Item.Teamwork.SendActivityNotification.SendActivityNotificationPostRequestBody();

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

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].Teamwork.SendActivityNotification.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

        }
    }
}
