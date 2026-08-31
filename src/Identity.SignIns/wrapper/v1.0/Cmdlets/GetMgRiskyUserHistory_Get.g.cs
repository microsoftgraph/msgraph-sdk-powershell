#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("GET", "/identityProtection/riskyUsers/{riskyUser-id}/history/{riskyUserHistoryItem-id}")]
    [Cmdlet(VerbsCommon.Get, "MgRiskyUserHistory_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyUserHistoryItem))]
    public class GetMgRiskyUserHistory_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RiskyUserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string RiskyUserHistoryItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyUserHistoryItem? result;
            try
            {
                result = client.IdentityProtection.RiskyUsers[RiskyUserId].History[RiskyUserHistoryItemId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, RiskyUserHistoryItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
