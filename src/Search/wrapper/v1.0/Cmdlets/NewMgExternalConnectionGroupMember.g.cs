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
    [GraphRoute("POST", "/external/connections/{externalConnection-id}/groups/{externalGroup-id}/members")]
    [Cmdlet(VerbsCommon.New, "MgExternalConnectionGroupMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.Identity))]
    public class NewMgExternalConnectionGroupMemberCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ExternalConnectionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ExternalGroupId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.IdentityType? Type { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ExternalGroupId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.Identity();


    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.ExternalConnectors.Identity? result;
            try
            {
                result = client.External.Connections[ExternalConnectionId].Groups[ExternalGroupId].Members.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
