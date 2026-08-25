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
    [GraphRoute("PATCH", "/external/connections/{externalConnection-id}/schema")]
    [Cmdlet(VerbsData.Update, "MgExternalConnectionSchema", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.Schema))]
    public class UpdateMgExternalConnectionSchemaCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ExternalConnectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? BaseType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.Property[]? Properties { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ExternalConnectionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.Schema();

    if (this.IsParameterBound(nameof(BaseType)))
        body.BaseType = BaseType;

    if (this.IsParameterBound(nameof(Properties)))
        body.Properties = Properties!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.Schema? result;
            try
            {
                result = client.External.Connections[ExternalConnectionId].Schema.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ExternalConnectionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.External.Connections[ExternalConnectionId].Schema.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ExternalConnectionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
