#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/lists/{list-id}/subscriptions/{subscription-id}/reauthorize")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgReauthorizeGroupSiteListSubscription", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgReauthorizeGroupSiteListSubscriptionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string SubscriptionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SubscriptionId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Groups[GroupId].Sites[SiteId].Lists[ListId].Subscriptions[SubscriptionId].Reauthorize.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SubscriptionId);
                return;
            }

        }
    }
}
