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
    [GraphRoute("PATCH", "/teams/{team-id}/schedule/swapShiftsChangeRequests/{swapShiftsChangeRequest-id}")]
    [Cmdlet(VerbsData.Update, "MgTeamScheduleSwapShiftChangeRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.SwapShiftsChangeRequest))]
    public class UpdateMgTeamScheduleSwapShiftChangeRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SwapShiftsChangeRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ManagerActionMessage { get; set; }

        [Parameter(Mandatory = false)]
        public string? SenderMessage { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecipientActionMessage { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecipientUserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SenderShiftId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecipientShiftId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ScheduleChangeRequestActor? AssignedTo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ScheduleChangeState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SwapShiftsChangeRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.SwapShiftsChangeRequest();

    if (this.IsParameterBound(nameof(ManagerActionMessage)))
        body.ManagerActionMessage = ManagerActionMessage;

    if (this.IsParameterBound(nameof(SenderMessage)))
        body.SenderMessage = SenderMessage;

    if (this.IsParameterBound(nameof(RecipientActionMessage)))
        body.RecipientActionMessage = RecipientActionMessage;

    if (this.IsParameterBound(nameof(RecipientUserId)))
        body.RecipientUserId = RecipientUserId;

    if (this.IsParameterBound(nameof(SenderShiftId)))
        body.SenderShiftId = SenderShiftId;

    if (this.IsParameterBound(nameof(RecipientShiftId)))
        body.RecipientShiftId = RecipientShiftId;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(AssignedTo)))
        body.AssignedTo = AssignedTo;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.SwapShiftsChangeRequest? result;
            try
            {
                result = client.Teams[TeamId].Schedule.SwapShiftsChangeRequests[SwapShiftsChangeRequestId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SwapShiftsChangeRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Teams[TeamId].Schedule.SwapShiftsChangeRequests[SwapShiftsChangeRequestId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SwapShiftsChangeRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
