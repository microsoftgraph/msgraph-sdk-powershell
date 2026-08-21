#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement
{
    [GraphRoute("POST", "/admin/serviceAnnouncement/messages/unarchive")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUnarchiveServiceAnnouncementMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Admin.ServiceAnnouncement.Messages.Unarchive.UnarchivePostResponse))]
    public class InvokeMgUnarchiveServiceAnnouncementMessageCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? MessageIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Admin.ServiceAnnouncement.Messages.Unarchive.UnarchivePostRequestBody();

    if (this.IsParameterBound(nameof(MessageIds)))
        body.MessageIds = MessageIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Admin.ServiceAnnouncement.Messages.Unarchive.UnarchivePostResponse? result;
            try
            {
                result = client.Admin.ServiceAnnouncement.Messages.Unarchive.PostAsUnarchivePostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
