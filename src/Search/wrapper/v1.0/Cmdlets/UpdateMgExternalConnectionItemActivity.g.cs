#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Search.Client;
using Microsoft.Graph.PowerShell.Search.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Search
{
    [GraphRoute("PATCH", "/external/connections/{externalConnection-id}/items/{externalItem-id}/activities/{externalActivity-id}")]
    [Cmdlet(VerbsData.Update, "MgExternalConnectionItemActivity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.ExternalActivity))]
    public class UpdateMgExternalConnectionItemActivityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ExternalConnectionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ExternalItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ExternalActivityId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.ExternalActivityType? Type { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ExternalActivityId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.ExternalActivity();

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.ExternalActivity? result;
            try
            {
                result = client.External.Connections[ExternalConnectionId].Items[ExternalItemId].Activities[ExternalActivityId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ExternalActivityId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.External.Connections[ExternalConnectionId].Items[ExternalItemId].Activities[ExternalActivityId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ExternalActivityId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
