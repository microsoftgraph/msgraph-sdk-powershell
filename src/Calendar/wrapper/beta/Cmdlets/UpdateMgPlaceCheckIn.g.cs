#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Calendar.Client;
using Microsoft.Graph.PowerShell.Calendar.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Calendar
{
    [GraphRoute("PATCH", "/places/{place-id}/checkIns/{checkInClaim-calendarEventId}")]
    [Cmdlet(VerbsData.Update, "MgPlaceCheckIn", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.CheckInClaim))]
    public class UpdateMgPlaceCheckInCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlaceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CheckInClaimCalendarEventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CalendarEventId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.CheckInMethod? CheckInMethod { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CheckInClaimCalendarEventId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.CheckInClaim();

    if (this.IsParameterBound(nameof(CalendarEventId)))
        body.CalendarEventId = CalendarEventId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CheckInMethod)))
        body.CheckInMethod = CheckInMethod;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.CheckInClaim? result;
            try
            {
                result = client.Places[PlaceId].CheckIns[CheckInClaimCalendarEventId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CheckInClaimCalendarEventId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Places[PlaceId].CheckIns[CheckInClaimCalendarEventId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CheckInClaimCalendarEventId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
