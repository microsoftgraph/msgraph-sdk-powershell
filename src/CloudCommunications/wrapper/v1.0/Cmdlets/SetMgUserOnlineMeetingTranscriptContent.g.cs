#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("PUT", "/users/{user-id}/onlineMeetings/{onlineMeeting-id}/transcripts/{callTranscript-id}/content")]
    [Cmdlet(VerbsCommon.Set, "MgUserOnlineMeetingTranscriptContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallTranscript))]
    public class SetMgUserOnlineMeetingTranscriptContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnlineMeetingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CallTranscriptId { get; set; } = string.Empty;

                [Parameter(Mandatory = true,
                    HelpMessage = "Path to the file whose contents are uploaded.")]
                public string InFile { get; set; } = string.Empty;






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallTranscriptId, "Set"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallTranscript? result;
            try
            {
                using var content = System.IO.File.OpenRead(InFile);
                result = client.Users[UserId].OnlineMeetings[OnlineMeetingId].Transcripts[CallTranscriptId].Content.PutAsync(content, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CallTranscriptId);
                return;
            }

            WriteObject(result);
        }
    }
}
