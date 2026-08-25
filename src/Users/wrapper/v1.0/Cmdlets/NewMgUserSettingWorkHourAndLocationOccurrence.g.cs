#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("POST", "/users/{user-id}/settings/workHoursAndLocations/occurrences")]
    [Cmdlet(VerbsCommon.New, "MgUserSettingWorkHourAndLocationOccurrence", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.WorkPlanOccurrence))]
    public class NewMgUserSettingWorkHourAndLocationOccurrenceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? PlaceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecurrenceId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.DateTimeTimeZone? End { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.DateTimeTimeZone? Start { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.TimeOffDetails? TimeOffDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.WorkLocationType? WorkLocationType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.WorkPlanOccurrence();

    if (this.IsParameterBound(nameof(PlaceId)))
        body.PlaceId = PlaceId;

    if (this.IsParameterBound(nameof(RecurrenceId)))
        body.RecurrenceId = RecurrenceId;

    if (this.IsParameterBound(nameof(End)))
        body.End = End;

    if (this.IsParameterBound(nameof(Start)))
        body.Start = Start;

    if (this.IsParameterBound(nameof(TimeOffDetails)))
        body.TimeOffDetails = TimeOffDetails;

    if (this.IsParameterBound(nameof(WorkLocationType)))
        body.WorkLocationType = WorkLocationType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.WorkPlanOccurrence? result;
            try
            {
                result = client.Users[UserId].Settings.WorkHoursAndLocations.Occurrences.PostAsync(body, requestConfiguration =>
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
