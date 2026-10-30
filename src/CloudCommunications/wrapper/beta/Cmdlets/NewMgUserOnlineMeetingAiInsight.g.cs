#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("POST", "/users/{user-id}/onlineMeetings/{onlineMeeting-id}/aiInsights")]
    [Cmdlet(VerbsCommon.New, "MgUserOnlineMeetingAiInsight", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallAiInsight))]
    public class NewMgUserOnlineMeetingAiInsightCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnlineMeetingId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CallId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentCorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecapUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ActionItem[]? ActionItems { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MeetingNote[]? MeetingNotes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallAiInsightViewPoint? Viewpoint { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnlineMeetingId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallAiInsight();

    if (this.IsParameterBound(nameof(CallId)))
        body.CallId = CallId;

    if (this.IsParameterBound(nameof(ContentCorrelationId)))
        body.ContentCorrelationId = ContentCorrelationId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(RecapUrl)))
        body.RecapUrl = RecapUrl;

    if (this.IsParameterBound(nameof(ActionItems)))
        body.ActionItems = ActionItems!.ToList();

    if (this.IsParameterBound(nameof(MeetingNotes)))
        body.MeetingNotes = MeetingNotes!.ToList();

    if (this.IsParameterBound(nameof(Viewpoint)))
        body.Viewpoint = Viewpoint;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallAiInsight? result;
            try
            {
                result = client.Users[UserId].OnlineMeetings[OnlineMeetingId].AiInsights.PostAsync(body, requestConfiguration =>
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
