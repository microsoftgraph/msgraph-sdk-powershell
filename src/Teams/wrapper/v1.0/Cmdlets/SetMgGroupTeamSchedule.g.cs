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
    [GraphRoute("PUT", "/groups/{group-id}/team/schedule")]
    [Cmdlet(VerbsCommon.Set, "MgGroupTeamSchedule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.Schedule))]
    public class SetMgGroupTeamScheduleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? Enabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsActivitiesIncludedWhenCopyingShiftsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OfferShiftRequestsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OpenShiftsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SwapShiftsRequestsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? TimeClockEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? TimeOffRequestsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeZone { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? WorkforceIntegrationIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.DayOfWeekObject? StartDayOfWeek { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TimeClockSettings? TimeClockSettings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Set"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.Schedule();

    if (this.IsParameterBound(nameof(Enabled)))
        body.Enabled = Enabled;

    if (this.IsParameterBound(nameof(IsActivitiesIncludedWhenCopyingShiftsEnabled)))
        body.IsActivitiesIncludedWhenCopyingShiftsEnabled = IsActivitiesIncludedWhenCopyingShiftsEnabled;

    if (this.IsParameterBound(nameof(OfferShiftRequestsEnabled)))
        body.OfferShiftRequestsEnabled = OfferShiftRequestsEnabled;

    if (this.IsParameterBound(nameof(OpenShiftsEnabled)))
        body.OpenShiftsEnabled = OpenShiftsEnabled;

    if (this.IsParameterBound(nameof(SwapShiftsRequestsEnabled)))
        body.SwapShiftsRequestsEnabled = SwapShiftsRequestsEnabled;

    if (this.IsParameterBound(nameof(TimeClockEnabled)))
        body.TimeClockEnabled = TimeClockEnabled;

    if (this.IsParameterBound(nameof(TimeOffRequestsEnabled)))
        body.TimeOffRequestsEnabled = TimeOffRequestsEnabled;

    if (this.IsParameterBound(nameof(TimeZone)))
        body.TimeZone = TimeZone;

    if (this.IsParameterBound(nameof(WorkforceIntegrationIds)))
        body.WorkforceIntegrationIds = WorkforceIntegrationIds!.ToList();

    if (this.IsParameterBound(nameof(StartDayOfWeek)))
        body.StartDayOfWeek = StartDayOfWeek;

    if (this.IsParameterBound(nameof(TimeClockSettings)))
        body.TimeClockSettings = TimeClockSettings;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.Schedule? result;
            try
            {
                result = client.Groups[GroupId].Team.Schedule.PutAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }


            if (result is not null)
                WriteObject(result);
        }
    }
}
