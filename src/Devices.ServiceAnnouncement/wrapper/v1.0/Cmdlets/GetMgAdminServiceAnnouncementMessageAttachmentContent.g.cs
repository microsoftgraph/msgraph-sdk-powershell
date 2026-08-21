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
    [GraphRoute("GET", "/admin/serviceAnnouncement/messages/{serviceUpdateMessage-id}/attachments/{serviceAnnouncementAttachment-id}/content")]
    [Cmdlet(VerbsCommon.Get, "MgAdminServiceAnnouncementMessageAttachmentContent")]
    [OutputType(typeof(byte[]))]
    public class GetMgAdminServiceAnnouncementMessageAttachmentContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServiceUpdateMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ServiceAnnouncementAttachmentId { get; set; } = string.Empty;






        [Parameter(Mandatory = false,
            HelpMessage = "Writes the response content to this path instead of returning it as bytes.")]
        public string? OutFile { get; set; }

        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            System.IO.Stream? result;
            try
            {
                result = client.Admin.ServiceAnnouncement.Messages[ServiceUpdateMessageId].Attachments[ServiceAnnouncementAttachmentId].Content.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ServiceAnnouncementAttachmentId);
                return;
            }

        if (result is not null)
        {
            using (result)
            {
                if (this.IsParameterBound(nameof(OutFile)))
                {
                    using var file = System.IO.File.Create(OutFile!);
                    result.CopyTo(file);
                }
                else
                {
                    using var buffer = new System.IO.MemoryStream();
                    result.CopyTo(buffer);
                    WriteObject(buffer.ToArray());
                }
            }
        }
        }
    }
}
