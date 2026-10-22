#nullable enable

using System;
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
    [GraphRoute("GET", "/users/{user-id}/calendarGroups/{calendarGroup-id}/calendars/{calendar-id}/events/{event-id}/attachments/{attachment-id}")]
    [Cmdlet(VerbsCommon.Get, "MgUserCalendarGroupCalendarEventAttachment_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.Attachment))]
    public class GetMgUserCalendarGroupCalendarEventAttachment_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CalendarGroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CalendarId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string EventId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string AttachmentId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.Attachment? result;
            try
            {
                result = client.Users[UserId].CalendarGroups[CalendarGroupId].Calendars[CalendarId].Events[EventId].Attachments[AttachmentId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AttachmentId);
                return;
            }

            WriteObject(result);
        }
    }
}
