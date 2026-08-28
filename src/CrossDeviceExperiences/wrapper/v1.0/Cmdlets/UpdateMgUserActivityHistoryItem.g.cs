#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client;
using Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CrossDeviceExperiences
{
    [GraphRoute("PATCH", "/users/{user-id}/activities/{userActivity-id}/historyItems/{activityHistoryItem-id}")]
    [Cmdlet(VerbsData.Update, "MgUserActivityHistoryItem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.ActivityHistoryItem))]
    public class UpdateMgUserActivityHistoryItemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UserActivityId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ActivityHistoryItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? ActiveDurationSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastActiveDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserTimezone { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.Status? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.UserActivity? Activity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ActivityHistoryItemId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.ActivityHistoryItem();

    if (this.IsParameterBound(nameof(ActiveDurationSeconds)))
        body.ActiveDurationSeconds = ActiveDurationSeconds;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(LastActiveDateTime)))
        body.LastActiveDateTime = LastActiveDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(StartedDateTime)))
        body.StartedDateTime = StartedDateTime;

    if (this.IsParameterBound(nameof(UserTimezone)))
        body.UserTimezone = UserTimezone;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.ActivityHistoryItem? result;
            try
            {
                result = client.Users[UserId].Activities[UserActivityId].HistoryItems[ActivityHistoryItemId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ActivityHistoryItemId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Activities[UserActivityId].HistoryItems[ActivityHistoryItemId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ActivityHistoryItemId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
