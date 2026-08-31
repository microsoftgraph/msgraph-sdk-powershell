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
    [GraphRoute("POST", "/groups/{group-id}/team/schedule/timeCards/clockIn")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgClockGroupTeamScheduleTimeCardIn", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TimeCard))]
    public class InvokeMgClockGroupTeamScheduleTimeCardInCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsAtApprovedLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnBehalfOfUserId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ItemBody? Notes { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Groups.Item.Team.Schedule.TimeCards.ClockIn.ClockInPostRequestBody();

    if (this.IsParameterBound(nameof(IsAtApprovedLocation)))
        body.IsAtApprovedLocation = IsAtApprovedLocation;

    if (this.IsParameterBound(nameof(OnBehalfOfUserId)))
        body.OnBehalfOfUserId = OnBehalfOfUserId;
    if (this.IsParameterBound(nameof(Notes)))
        body.Notes = Notes;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TimeCard? result;
            try
            {
                result = client.Groups[GroupId].Team.Schedule.TimeCards.ClockIn.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }

            WriteObject(result);
        }
    }
}
