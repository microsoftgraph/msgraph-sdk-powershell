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
    [GraphRoute("POST", "/groups/{group-id}/team/clone")]
    [Cmdlet(VerbsCommon.Copy, "MgGroupTeam", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class CopyMgGroupTeamCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? MailNickname { get; set; }

        [Parameter(Mandatory = false)]
        public string? Classification { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamVisibilityType? Visibility { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ClonableTeamParts? PartsToClone { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Copy"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Groups.Item.Team.Clone.ClonePostRequestBody();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(MailNickname)))
        body.MailNickname = MailNickname;

    if (this.IsParameterBound(nameof(Classification)))
        body.Classification = Classification;
    if (this.IsParameterBound(nameof(Visibility)))
        body.Visibility = Visibility;

    if (this.IsParameterBound(nameof(PartsToClone)))
        body.PartsToClone = PartsToClone;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Groups[GroupId].Team.Clone.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }

        }
    }
}
