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
    [GraphRoute("PATCH", "/admin/serviceAnnouncement/messages/{serviceUpdateMessage-id}")]
    [Cmdlet(VerbsData.Update, "MgAdminServiceAnnouncementMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceUpdateMessage))]
    public class UpdateMgAdminServiceAnnouncementMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServiceUpdateMessageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ActionRequiredByDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? AttachmentsArchive { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasAttachments { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMajorChange { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Services { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Tags { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.KeyValuePair[]? Details { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ItemBody? Body { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceUpdateCategory? Category { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceUpdateSeverity? Severity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceUpdateMessageViewpoint? ViewPoint { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServiceUpdateMessageId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceUpdateMessage();

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(ActionRequiredByDateTime)))
        body.ActionRequiredByDateTime = ActionRequiredByDateTime;

    if (this.IsParameterBound(nameof(AttachmentsArchive)))
        body.AttachmentsArchive = AttachmentsArchive;

    if (this.IsParameterBound(nameof(HasAttachments)))
        body.HasAttachments = HasAttachments;

    if (this.IsParameterBound(nameof(IsMajorChange)))
        body.IsMajorChange = IsMajorChange;

    if (this.IsParameterBound(nameof(Services)))
        body.Services = Services!.ToList();

    if (this.IsParameterBound(nameof(Tags)))
        body.Tags = Tags!.ToList();

    if (this.IsParameterBound(nameof(Details)))
        body.Details = Details!.ToList();

    if (this.IsParameterBound(nameof(Body)))
        body.Body = Body;

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(Severity)))
        body.Severity = Severity;

    if (this.IsParameterBound(nameof(ViewPoint)))
        body.ViewPoint = ViewPoint;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceUpdateMessage? result;
            try
            {
                result = client.Admin.ServiceAnnouncement.Messages[ServiceUpdateMessageId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ServiceUpdateMessageId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.ServiceAnnouncement.Messages[ServiceUpdateMessageId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ServiceUpdateMessageId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
