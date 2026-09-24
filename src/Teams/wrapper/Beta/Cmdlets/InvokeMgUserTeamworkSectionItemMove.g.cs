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
    [GraphRoute("POST", "/users/{user-id}/teamwork/sections/{teamworkSection-id}/items/{teamworkSectionItem-id}/move")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserTeamworkSectionItemMove", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkSectionItem))]
    public class InvokeMgUserTeamworkSectionItemMoveCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TeamworkSectionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TeamworkSectionItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? TargetSectionId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamworkSectionItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Users.Item.Teamwork.Sections.Item.Items.Item.Move.MovePostRequestBody();

    if (this.IsParameterBound(nameof(TargetSectionId)))
        body.TargetSectionId = TargetSectionId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkSectionItem? result;
            try
            {
                result = client.Users[UserId].Teamwork.Sections[TeamworkSectionId].Items[TeamworkSectionItemId].Move.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TeamworkSectionItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
