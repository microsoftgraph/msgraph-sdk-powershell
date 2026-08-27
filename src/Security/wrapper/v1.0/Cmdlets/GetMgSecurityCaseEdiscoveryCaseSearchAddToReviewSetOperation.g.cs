#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("GET", "/security/cases/ediscoveryCases/{ediscoveryCase-id}/searches/{ediscoverySearch-id}/addToReviewSetOperation")]
    [Cmdlet(VerbsCommon.Get, "MgSecurityCaseEdiscoveryCaseSearchAddToReviewSetOperation")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryAddToReviewSetOperation))]
    public class GetMgSecurityCaseEdiscoveryCaseSearchAddToReviewSetOperationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EdiscoveryCaseId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EdiscoverySearchId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryAddToReviewSetOperation? result;
            try
            {
                result = client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].Searches[EdiscoverySearchId].AddToReviewSetOperation.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, EdiscoverySearchId);
                return;
            }

            WriteObject(result);
        }
    }
}
