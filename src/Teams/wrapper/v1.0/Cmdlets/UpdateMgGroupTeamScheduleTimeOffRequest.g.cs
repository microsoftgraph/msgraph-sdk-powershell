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
    [GraphRoute("PATCH", "/groups/{group-id}/team/schedule/timeOffRequests/{timeOffRequest-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupTeamScheduleTimeOffRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TimeOffRequest))]
    public class UpdateMgGroupTeamScheduleTimeOffRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TimeOffRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ManagerActionMessage { get; set; }

        [Parameter(Mandatory = false)]
        public string? SenderMessage { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeOffReasonId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ScheduleChangeRequestActor? AssignedTo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ScheduleChangeState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TimeOffRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.TimeOffRequest();

    if (this.IsParameterBound(nameof(ManagerActionMessage)))
        body.ManagerActionMessage = ManagerActionMessage;

    if (this.IsParameterBound(nameof(SenderMessage)))
        body.SenderMessage = SenderMessage;

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(TimeOffReasonId)))
        body.TimeOffReasonId = TimeOffReasonId;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(AssignedTo)))
        body.AssignedTo = AssignedTo;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TimeOffRequest? result;
            try
            {
                result = client.Groups[GroupId].Team.Schedule.TimeOffRequests[TimeOffRequestId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TimeOffRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Team.Schedule.TimeOffRequests[TimeOffRequestId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, TimeOffRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
