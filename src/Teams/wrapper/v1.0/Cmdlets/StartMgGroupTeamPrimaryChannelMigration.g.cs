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
    [GraphRoute("POST", "/groups/{group-id}/team/primaryChannel/startMigration")]
    [Cmdlet(VerbsLifecycle.Start, "MgGroupTeamPrimaryChannelMigration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class StartMgGroupTeamPrimaryChannelMigrationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ConversationCreationDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Start"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Groups.Item.Team.PrimaryChannel.StartMigration.StartMigrationPostRequestBody();

    if (this.IsParameterBound(nameof(ConversationCreationDateTime)))
        body.ConversationCreationDateTime = ConversationCreationDateTime;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Groups[GroupId].Team.PrimaryChannel.StartMigration.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }

        }
    }
}
