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
    [GraphRoute("POST", "/users/{user-id}/events/{event-id}/attachments/createUploadSession")]
    [Cmdlet(VerbsCommon.New, "MgUserEventAttachmentUploadSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.UploadSession))]
    public class NewMgUserEventAttachmentUploadSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EventId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.AttachmentItem? AttachmentItem { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EventId, "New"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Calendar.Client.Users.Item.Events.Item.Attachments.CreateUploadSession.CreateUploadSessionPostRequestBody();

    if (this.IsParameterBound(nameof(AttachmentItem)))
        body.AttachmentItem = AttachmentItem;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.UploadSession? result;
            try
            {
                result = client.Users[UserId].Events[EventId].Attachments.CreateUploadSession.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EventId);
                return;
            }

            WriteObject(result);
        }
    }
}
