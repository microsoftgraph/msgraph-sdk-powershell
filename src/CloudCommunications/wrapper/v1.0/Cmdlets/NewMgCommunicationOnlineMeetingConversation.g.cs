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
    [GraphRoute("POST", "/communications/onlineMeetingConversations")]
    [Cmdlet(VerbsCommon.New, "MgCommunicationOnlineMeetingConversation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.OnlineMeetingEngagementConversation))]
    public class NewMgCommunicationOnlineMeetingConversationCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? StarterId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnlineMeetingId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementCreationMode? CreationMode { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationMessage? Starter { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationModerationState? ModerationState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementIdentitySet? Organizer { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.OnlineMeeting? OnlineMeeting { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.OnlineMeetingEngagementConversation();

    if (this.IsParameterBound(nameof(StarterId)))
        body.StarterId = StarterId;

    if (this.IsParameterBound(nameof(OnlineMeetingId)))
        body.OnlineMeetingId = OnlineMeetingId;

    if (this.IsParameterBound(nameof(CreationMode)))
        body.CreationMode = CreationMode;

    if (this.IsParameterBound(nameof(Starter)))
        body.Starter = Starter;

    if (this.IsParameterBound(nameof(ModerationState)))
        body.ModerationState = ModerationState;

    if (this.IsParameterBound(nameof(Organizer)))
        body.Organizer = Organizer;

    if (this.IsParameterBound(nameof(OnlineMeeting)))
        body.OnlineMeeting = OnlineMeeting;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.OnlineMeetingEngagementConversation? result;
            try
            {
                result = client.Communications.OnlineMeetingConversations.PostAsync(body, requestConfiguration =>
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
