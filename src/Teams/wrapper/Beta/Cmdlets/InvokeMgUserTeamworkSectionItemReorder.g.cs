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
    [GraphRoute("POST", "/users/{user-id}/teamwork/sections/{teamworkSection-id}/items/reorder")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserTeamworkSectionItemReorder", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Teams.Client.Users.Item.Teamwork.Sections.Item.Items.Reorder.ReorderPostResponse))]
    public class InvokeMgUserTeamworkSectionItemReorderCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TeamworkSectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? ItemsOrder { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamworkSectionId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Users.Item.Teamwork.Sections.Item.Items.Reorder.ReorderPostRequestBody();

    if (this.IsParameterBound(nameof(ItemsOrder)))
        body.ItemsOrder = ItemsOrder!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Teams.Client.Users.Item.Teamwork.Sections.Item.Items.Reorder.ReorderPostResponse? result;
            try
            {
                result = client.Users[UserId].Teamwork.Sections[TeamworkSectionId].Items.Reorder.PostAsReorderPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TeamworkSectionId);
                return;
            }

            WriteObject(result);
        }
    }
}
