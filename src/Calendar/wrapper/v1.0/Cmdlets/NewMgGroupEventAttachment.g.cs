#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Calendar.Client;
using Microsoft.Graph.PowerShell.Calendar.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Calendar
{
    [GraphRoute("POST", "/groups/{group-id}/events/{event-id}/attachments")]
    [Cmdlet(VerbsCommon.New, "MgGroupEventAttachment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.Attachment))]
    public class NewMgGroupEventAttachmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ContentType { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsInline { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public int? Size { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EventId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.Attachment();

    if (this.IsParameterBound(nameof(ContentType)))
        body.ContentType = ContentType;

    if (this.IsParameterBound(nameof(IsInline)))
        body.IsInline = IsInline;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Size)))
        body.Size = Size;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.Attachment? result;
            try
            {
                result = client.Groups[GroupId].Events[EventId].Attachments.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
