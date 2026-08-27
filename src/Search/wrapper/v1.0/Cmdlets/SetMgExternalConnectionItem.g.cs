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
    [GraphRoute("PUT", "/external/connections/{externalConnection-id}/items/{externalItem-id}")]
    [Cmdlet(VerbsCommon.Set, "MgExternalConnectionItem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.ExternalItem))]
    public class SetMgExternalConnectionItemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ExternalConnectionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ExternalItemId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.Acl[]? Acl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.ExternalItemContent? Content { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.Properties? Properties { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ExternalItemId, "Set"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.ExternalItem();


    if (this.IsParameterBound(nameof(Acl)))
        body.Acl = Acl!.ToList();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(Properties)))
        body.Properties = Properties;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.ExternalItem? result;
            try
            {
                result = client.External.Connections[ExternalConnectionId].Items[ExternalItemId].PutAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ExternalItemId);
                return;
            }


            if (result is not null)
                WriteObject(result);
        }
    }
}
