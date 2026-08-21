#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement
{
    [GraphRoute("PUT", "/admin/serviceAnnouncement/messages/{serviceUpdateMessage-id}/attachments/{serviceAnnouncementAttachment-id}/content")]
    [Cmdlet(VerbsCommon.Set, "MgAdminServiceAnnouncementMessageAttachmentContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceAnnouncementAttachment))]
    public class SetMgAdminServiceAnnouncementMessageAttachmentContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServiceUpdateMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ServiceAnnouncementAttachmentId { get; set; } = string.Empty;

                [Parameter(Mandatory = true,
                    HelpMessage = "Path to the file whose contents are uploaded.")]
                public string InFile { get; set; } = string.Empty;






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServiceAnnouncementAttachmentId, "Set"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceAnnouncementAttachment? result;
            try
            {
                using var content = System.IO.File.OpenRead(InFile);
                result = client.Admin.ServiceAnnouncement.Messages[ServiceUpdateMessageId].Attachments[ServiceAnnouncementAttachmentId].Content.PutAsync(content, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ServiceAnnouncementAttachmentId);
                return;
            }

            WriteObject(result);
        }
    }
}
