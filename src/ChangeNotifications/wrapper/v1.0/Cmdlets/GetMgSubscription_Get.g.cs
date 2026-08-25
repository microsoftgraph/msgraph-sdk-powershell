#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.ChangeNotifications.Client;
using Microsoft.Graph.PowerShell.ChangeNotifications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.ChangeNotifications
{
    [GraphRoute("GET", "/subscriptions/{subscription-id}")]
    [Cmdlet(VerbsCommon.Get, "MgSubscription_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.ChangeNotifications.Client.Models.Subscription))]
    public class GetMgSubscription_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SubscriptionId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.ChangeNotifications.Client.Models.Subscription? result;
            try
            {
                result = client.Subscriptions[SubscriptionId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SubscriptionId);
                return;
            }

            WriteObject(result);
        }
    }
}
