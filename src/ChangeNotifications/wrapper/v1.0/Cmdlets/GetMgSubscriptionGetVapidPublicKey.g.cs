#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/subscriptions/getVapidPublicKey()")]
    [Cmdlet(VerbsCommon.Get, "MgSubscriptionGetVapidPublicKey")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.ChangeNotifications.Client.Subscriptions.GetVapidPublicKey.GetVapidPublicKeyGetResponse))]
    public class GetMgSubscriptionGetVapidPublicKeyCommand : GraphClientCmdlet
    {










        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.ChangeNotifications.Client.Subscriptions.GetVapidPublicKey.GetVapidPublicKeyGetResponse? result;
            try
            {
                result = client.Subscriptions.GetVapidPublicKey.GetAsGetVapidPublicKeyGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
