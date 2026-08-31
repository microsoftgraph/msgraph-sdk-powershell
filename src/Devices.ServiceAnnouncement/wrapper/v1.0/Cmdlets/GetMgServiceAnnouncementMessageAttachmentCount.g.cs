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
    [GraphRoute("GET", "/admin/serviceAnnouncement/messages/{serviceUpdateMessage-id}/attachments/$count")]
    [Cmdlet(VerbsCommon.Get, "MgServiceAnnouncementMessageAttachmentCount")]
    [OutputType(typeof(int))]
    public class GetMgServiceAnnouncementMessageAttachmentCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServiceUpdateMessageId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.Admin.ServiceAnnouncement.Messages[ServiceUpdateMessageId].Attachments.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ServiceUpdateMessageId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
