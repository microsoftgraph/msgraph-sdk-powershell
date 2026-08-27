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
    [GraphRoute("PATCH", "/groups/{group-id}/team/schedule/openShifts/{openShift-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupTeamScheduleOpenShift", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.OpenShift))]
    public class UpdateMgGroupTeamScheduleOpenShiftCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OpenShiftId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsStagedForDeletion { get; set; }

        [Parameter(Mandatory = false)]
        public string? SchedulingGroupId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.OpenShiftItem? DraftOpenShift { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.OpenShiftItem? SharedOpenShift { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OpenShiftId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.OpenShift();

    if (this.IsParameterBound(nameof(IsStagedForDeletion)))
        body.IsStagedForDeletion = IsStagedForDeletion;

    if (this.IsParameterBound(nameof(SchedulingGroupId)))
        body.SchedulingGroupId = SchedulingGroupId;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(DraftOpenShift)))
        body.DraftOpenShift = DraftOpenShift;

    if (this.IsParameterBound(nameof(SharedOpenShift)))
        body.SharedOpenShift = SharedOpenShift;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.OpenShift? result;
            try
            {
                result = client.Groups[GroupId].Team.Schedule.OpenShifts[OpenShiftId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, OpenShiftId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Team.Schedule.OpenShifts[OpenShiftId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, OpenShiftId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
