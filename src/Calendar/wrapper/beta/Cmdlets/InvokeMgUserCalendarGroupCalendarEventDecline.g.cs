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
    [GraphRoute("POST", "/users/{user-id}/calendarGroups/{calendarGroup-id}/calendars/{calendar-id}/events/{event-id}/decline")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserCalendarGroupCalendarEventDecline", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgUserCalendarGroupCalendarEventDeclineCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CalendarGroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CalendarId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string EventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? SendResponse { get; set; }

        [Parameter(Mandatory = false)]
        public string? Comment { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.TimeSlot? ProposedNewTime { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EventId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Calendar.Client.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Decline.DeclinePostRequestBody();

    if (this.IsParameterBound(nameof(SendResponse)))
        body.SendResponse = SendResponse;

    if (this.IsParameterBound(nameof(Comment)))
        body.Comment = Comment;
    if (this.IsParameterBound(nameof(ProposedNewTime)))
        body.ProposedNewTime = ProposedNewTime;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].CalendarGroups[CalendarGroupId].Calendars[CalendarId].Events[EventId].Decline.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EventId);
                return;
            }

        }
    }
}
