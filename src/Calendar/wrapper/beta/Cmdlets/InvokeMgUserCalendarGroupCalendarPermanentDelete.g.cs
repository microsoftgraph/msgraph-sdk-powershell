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
    [GraphRoute("POST", "/users/{user-id}/calendarGroups/{calendarGroup-id}/calendars/{calendar-id}/permanentDelete")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserCalendarGroupCalendarPermanentDelete", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgUserCalendarGroupCalendarPermanentDeleteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CalendarGroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CalendarId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CalendarId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].CalendarGroups[CalendarGroupId].Calendars[CalendarId].PermanentDelete.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CalendarId);
                return;
            }

        }
    }
}
