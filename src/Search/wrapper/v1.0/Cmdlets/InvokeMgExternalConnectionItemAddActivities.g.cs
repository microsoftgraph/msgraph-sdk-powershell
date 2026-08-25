#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Search.Client;
using Microsoft.Graph.PowerShell.Search.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Search
{
    [GraphRoute("POST", "/external/connections/{externalConnection-id}/items/{externalItem-id}/microsoft.graph.externalConnectors.addActivities")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgExternalConnectionItemAddActivities", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Search.Client.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostResponse))]
    public class InvokeMgExternalConnectionItemAddActivitiesCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ExternalConnectionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ExternalItemId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.ExternalActivity[]? Activities { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ExternalItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Search.Client.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostRequestBody();

    if (this.IsParameterBound(nameof(Activities)))
        body.Activities = Activities!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Search.Client.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostResponse? result;
            try
            {
                result = client.External.Connections[ExternalConnectionId].Items[ExternalItemId].MicrosoftGraphExternalConnectorsAddActivities.PostAsAddActivitiesPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ExternalItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
