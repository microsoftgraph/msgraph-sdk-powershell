#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.People.Client;
using Microsoft.Graph.PowerShell.People.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.People
{
    [GraphRoute("POST", "/users/{user-id}/analytics/activityStatistics")]
    [Cmdlet(VerbsCommon.New, "MgUserAnalyticActivityStatistics", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.People.Client.Models.ActivityStatistics))]
    public class NewMgUserAnalyticActivityStatisticsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? Duration { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? EndDate { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? StartDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeZoneUsed { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.AnalyticsActivityType? Activity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.People.Client.Models.ActivityStatistics();

    if (this.IsParameterBound(nameof(Duration)))
        body.Duration = Duration;

    if (this.IsParameterBound(nameof(EndDate)))
        body.EndDate = EndDate;

    if (this.IsParameterBound(nameof(StartDate)))
        body.StartDate = StartDate;

    if (this.IsParameterBound(nameof(TimeZoneUsed)))
        body.TimeZoneUsed = TimeZoneUsed;

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.People.Client.Models.ActivityStatistics? result;
            try
            {
                result = client.Users[UserId].Analytics.ActivityStatistics.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
