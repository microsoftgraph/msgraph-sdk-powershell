#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement
{
    [GraphRoute("PATCH", "/admin/serviceAnnouncement/messages/{serviceUpdateMessage-id}/attachments/{serviceAnnouncementAttachment-id}")]
    [Cmdlet(VerbsData.Update, "MgAdminServiceAnnouncementMessageAttachment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceAnnouncementAttachment))]
    public class UpdateMgAdminServiceAnnouncementMessageAttachmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServiceUpdateMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ServiceAnnouncementAttachmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public byte[]? Content { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentType { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public int? Size { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServiceAnnouncementAttachmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceAnnouncementAttachment();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(ContentType)))
        body.ContentType = ContentType;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Size)))
        body.Size = Size;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceAnnouncementAttachment? result;
            try
            {
                result = client.Admin.ServiceAnnouncement.Messages[ServiceUpdateMessageId].Attachments[ServiceAnnouncementAttachmentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ServiceAnnouncementAttachmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.ServiceAnnouncement.Messages[ServiceUpdateMessageId].Attachments[ServiceAnnouncementAttachmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ServiceAnnouncementAttachmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
