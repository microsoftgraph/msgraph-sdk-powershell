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
    [GraphRoute("POST", "/communications/calls")]
    [Cmdlet(VerbsCommon.New, "MgCommunicationCall", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Call))]
    public class NewMgCommunicationCallCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? CallbackUri { get; set; }

        [Parameter(Mandatory = false)]
        public string? CallChainId { get; set; }

        [Parameter(Mandatory = false)]
        public string? MyParticipantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subject { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallOptions? CallOptions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRoute[]? CallRoutes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ChatInfo? ChatInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallDirection? Direction { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.IncomingContext? IncomingContext { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MediaConfig? MediaConfig { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallMediaState? MediaState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MeetingInfo? MeetingInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Modality?[]? RequestedModalities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ResultInfo? ResultInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ParticipantInfo? Source { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallState? State { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.InvitationParticipantInfo[]? Targets { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ToneInfo? ToneInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallTranscriptionInfo? Transcription { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Call();

    if (this.IsParameterBound(nameof(CallbackUri)))
        body.CallbackUri = CallbackUri;

    if (this.IsParameterBound(nameof(CallChainId)))
        body.CallChainId = CallChainId;

    if (this.IsParameterBound(nameof(MyParticipantId)))
        body.MyParticipantId = MyParticipantId;

    if (this.IsParameterBound(nameof(Subject)))
        body.Subject = Subject;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(CallOptions)))
        body.CallOptions = CallOptions;

    if (this.IsParameterBound(nameof(CallRoutes)))
        body.CallRoutes = CallRoutes!.ToList();

    if (this.IsParameterBound(nameof(ChatInfo)))
        body.ChatInfo = ChatInfo;

    if (this.IsParameterBound(nameof(Direction)))
        body.Direction = Direction;

    if (this.IsParameterBound(nameof(IncomingContext)))
        body.IncomingContext = IncomingContext;

    if (this.IsParameterBound(nameof(MediaConfig)))
        body.MediaConfig = MediaConfig;

    if (this.IsParameterBound(nameof(MediaState)))
        body.MediaState = MediaState;

    if (this.IsParameterBound(nameof(MeetingInfo)))
        body.MeetingInfo = MeetingInfo;

    if (this.IsParameterBound(nameof(RequestedModalities)))
        body.RequestedModalities = RequestedModalities!.ToList();

    if (this.IsParameterBound(nameof(ResultInfo)))
        body.ResultInfo = ResultInfo;

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;

    if (this.IsParameterBound(nameof(Targets)))
        body.Targets = Targets!.ToList();

    if (this.IsParameterBound(nameof(ToneInfo)))
        body.ToneInfo = ToneInfo;

    if (this.IsParameterBound(nameof(Transcription)))
        body.Transcription = Transcription;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Call? result;
            try
            {
                result = client.Communications.Calls.PostAsync(body, requestConfiguration =>
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
