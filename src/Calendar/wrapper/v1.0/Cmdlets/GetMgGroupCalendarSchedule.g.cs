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
    [GraphRoute("POST", "/groups/{group-id}/calendar/getSchedule")]
    [Cmdlet(VerbsCommon.Get, "MgGroupCalendarSchedule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Calendar.Client.Groups.Item.Calendar.GetSchedule.GetSchedulePostResponse))]
    public class GetMgGroupCalendarScheduleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

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
            if (!ShouldProcess(GroupId, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Calendar.Client.Groups.Item.Calendar.GetSchedule.GetSchedulePostRequestBody();

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

            global::Microsoft.Graph.PowerShell.Calendar.Client.Groups.Item.Calendar.GetSchedule.GetSchedulePostResponse? result;
            try
            {
                result = client.Groups[GroupId].Calendar.GetSchedule.PostAsGetSchedulePostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }

            WriteObject(result);
        }
    }
}
