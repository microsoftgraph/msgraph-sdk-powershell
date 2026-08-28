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
    [GraphRoute("PATCH", "/teams/{team-id}/schedule/openShiftChangeRequests/{openShiftChangeRequest-id}")]
    [Cmdlet(VerbsData.Update, "MgTeamScheduleOpenShiftChangeRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.OpenShiftChangeRequest))]
    public class UpdateMgTeamScheduleOpenShiftChangeRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OpenShiftChangeRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ManagerActionMessage { get; set; }

        [Parameter(Mandatory = false)]
        public string? SenderMessage { get; set; }

        [Parameter(Mandatory = false)]
        public string? OpenShiftId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ScheduleChangeRequestActor? AssignedTo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ScheduleChangeState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OpenShiftChangeRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.OpenShiftChangeRequest();

    if (this.IsParameterBound(nameof(ManagerActionMessage)))
        body.ManagerActionMessage = ManagerActionMessage;

    if (this.IsParameterBound(nameof(SenderMessage)))
        body.SenderMessage = SenderMessage;

    if (this.IsParameterBound(nameof(OpenShiftId)))
        body.OpenShiftId = OpenShiftId;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(AssignedTo)))
        body.AssignedTo = AssignedTo;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.OpenShiftChangeRequest? result;
            try
            {
                result = client.Teams[TeamId].Schedule.OpenShiftChangeRequests[OpenShiftChangeRequestId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, OpenShiftChangeRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Teams[TeamId].Schedule.OpenShiftChangeRequests[OpenShiftChangeRequestId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, OpenShiftChangeRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
