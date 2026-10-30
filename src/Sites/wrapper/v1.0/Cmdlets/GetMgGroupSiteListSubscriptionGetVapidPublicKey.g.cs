#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("GET", "/groups/{group-id}/sites/{site-id}/lists/{list-id}/subscriptions/getVapidPublicKey()")]
    [Cmdlet(VerbsCommon.Get, "MgGroupSiteListSubscriptionGetVapidPublicKey")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.Item.Lists.Item.Subscriptions.GetVapidPublicKey.GetVapidPublicKeyGetResponse))]
    public class GetMgGroupSiteListSubscriptionGetVapidPublicKeyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ListId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.Item.Lists.Item.Subscriptions.GetVapidPublicKey.GetVapidPublicKeyGetResponse? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].Lists[ListId].Subscriptions.GetVapidPublicKey.GetAsGetVapidPublicKeyGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ListId);
                return;
            }

            WriteObject(result);
        }
    }
}
