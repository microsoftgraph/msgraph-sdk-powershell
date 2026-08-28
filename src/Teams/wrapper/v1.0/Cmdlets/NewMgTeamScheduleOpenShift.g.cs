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
    [GraphRoute("POST", "/teams/{team-id}/schedule/openShifts")]
    [Cmdlet(VerbsCommon.New, "MgTeamScheduleOpenShift", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.OpenShift))]
    public class NewMgTeamScheduleOpenShiftCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;

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
            if (!ShouldProcess(TeamId, "New"))
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
                result = client.Teams[TeamId].Schedule.OpenShifts.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
