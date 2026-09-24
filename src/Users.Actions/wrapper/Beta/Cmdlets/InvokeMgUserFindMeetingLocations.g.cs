#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Actions.Client;
using Microsoft.Graph.PowerShell.Users.Actions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users.Actions
{
    [GraphRoute("POST", "/users/{user-id}/findMeetingLocations")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserFindMeetingLocations", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Actions.Client.Models.MeetingLocationSuggestionsResult))]
    public class InvokeMgUserFindMeetingLocationsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Query { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowFreeOnly { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? MeetingDuration { get; set; }

        [Parameter(Mandatory = false)]
        public int? MaxCandidates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Actions.Client.Models.AttendeeBase[]? Attendees { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Actions.Client.Models.TimeConstraint? TimeConstraint { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.FindMeetingLocations.FindMeetingLocationsPostRequestBody();

    if (this.IsParameterBound(nameof(Query)))
        body.Query = Query;

    if (this.IsParameterBound(nameof(AllowFreeOnly)))
        body.AllowFreeOnly = AllowFreeOnly;

    if (this.IsParameterBound(nameof(MeetingDuration)))
        body.MeetingDuration = MeetingDuration;

    if (this.IsParameterBound(nameof(MaxCandidates)))
        body.MaxCandidates = MaxCandidates;
    if (this.IsParameterBound(nameof(Attendees)))
        body.Attendees = Attendees!.ToList();

    if (this.IsParameterBound(nameof(TimeConstraint)))
        body.TimeConstraint = TimeConstraint;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Actions.Client.Models.MeetingLocationSuggestionsResult? result;
            try
            {
                result = client.Users[UserId].FindMeetingLocations.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
