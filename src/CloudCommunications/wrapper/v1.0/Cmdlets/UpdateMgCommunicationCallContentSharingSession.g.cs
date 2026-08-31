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
    [GraphRoute("PATCH", "/communications/calls/{call-id}/contentSharingSessions/{contentSharingSession-id}")]
    [Cmdlet(VerbsData.Update, "MgCommunicationCallContentSharingSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ContentSharingSession))]
    public class UpdateMgCommunicationCallContentSharingSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContentSharingSessionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ContentSharingSessionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ContentSharingSession();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ContentSharingSession? result;
            try
            {
                result = client.Communications.Calls[CallId].ContentSharingSessions[ContentSharingSessionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ContentSharingSessionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Communications.Calls[CallId].ContentSharingSessions[ContentSharingSessionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ContentSharingSessionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
