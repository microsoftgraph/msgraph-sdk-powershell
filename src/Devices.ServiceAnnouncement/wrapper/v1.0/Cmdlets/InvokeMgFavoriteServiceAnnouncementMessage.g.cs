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
    [GraphRoute("POST", "/admin/serviceAnnouncement/messages/favorite")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgFavoriteServiceAnnouncementMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Admin.ServiceAnnouncement.Messages.Favorite.FavoritePostResponse))]
    public class InvokeMgFavoriteServiceAnnouncementMessageCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? MessageIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Admin.ServiceAnnouncement.Messages.Favorite.FavoritePostRequestBody();

    if (this.IsParameterBound(nameof(MessageIds)))
        body.MessageIds = MessageIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Admin.ServiceAnnouncement.Messages.Favorite.FavoritePostResponse? result;
            try
            {
                result = client.Admin.ServiceAnnouncement.Messages.Favorite.PostAsFavoritePostResponseAsync(body, requestConfiguration =>
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
