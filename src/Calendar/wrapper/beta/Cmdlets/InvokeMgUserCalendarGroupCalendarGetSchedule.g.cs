#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Calendar.Client;
using Microsoft.Graph.PowerShell.Calendar.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Calendar
{
    [GraphRoute("POST", "/users/{user-id}/calendarGroups/{calendarGroup-id}/calendars/{calendar-id}/getSchedule")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserCalendarGroupCalendarGetSchedule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Calendar.Client.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostResponse))]
    public class InvokeMgUserCalendarGroupCalendarGetScheduleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CalendarGroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CalendarId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Schedules { get; set; }

        [Parameter(Mandatory = false)]
        public int? AvailabilityViewInterval { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.DateTimeTimeZone? EndTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.DateTimeTimeZone? StartTime { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CalendarId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Calendar.Client.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostRequestBody();

    if (this.IsParameterBound(nameof(Schedules)))
        body.Schedules = Schedules!.ToList();

    if (this.IsParameterBound(nameof(AvailabilityViewInterval)))
        body.AvailabilityViewInterval = AvailabilityViewInterval;
    if (this.IsParameterBound(nameof(EndTime)))
        body.EndTime = EndTime;

    if (this.IsParameterBound(nameof(StartTime)))
        body.StartTime = StartTime;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Calendar.Client.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostResponse? result;
            try
            {
                result = client.Users[UserId].CalendarGroups[CalendarGroupId].Calendars[CalendarId].GetSchedule.PostAsGetSchedulePostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CalendarId);
                return;
            }

            WriteObject(result);
        }
    }
}
