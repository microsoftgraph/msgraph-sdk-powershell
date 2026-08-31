#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/teams/{team-id}/members")]
    [Cmdlet(VerbsCommon.New, "MgTeamMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.ConversationMember))]
    public class NewMgTeamMemberCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Roles { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? VisibleHistoryStartDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.ConversationMember();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Roles)))
        body.Roles = Roles!.ToList();

    if (this.IsParameterBound(nameof(VisibleHistoryStartDateTime)))
        body.VisibleHistoryStartDateTime = VisibleHistoryStartDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.ConversationMember? result;
            try
            {
                result = client.Teams[TeamId].Members.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
