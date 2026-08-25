#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/security/cases/ediscoveryCases/{ediscoveryCase-id}/tags/microsoft.graph.security.asHierarchy()")]
    [Cmdlet(VerbsCommon.Get, "MgSecurityCaseEdiscoveryCaseTagAsHierarchy")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Security.Client.Security.Cases.EdiscoveryCases.Item.Tags.MicrosoftGraphSecurityAsHierarchy.AsHierarchyGetResponse))]
    public class GetMgSecurityCaseEdiscoveryCaseTagAsHierarchyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EdiscoveryCaseId { get; set; } = string.Empty;




        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }

        [Parameter(Mandatory = false)]
        public int Top { get; set; }

        [Parameter(Mandatory = false)]
        public int Skip { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter Count { get; set; }




        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.Security.Client.Security.Cases.EdiscoveryCases.Item.Tags.MicrosoftGraphSecurityAsHierarchy.AsHierarchyGetResponse? result;
            try
            {
                result = client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].Tags.MicrosoftGraphSecurityAsHierarchy.GetAsAsHierarchyGetResponseAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;

                    if (this.IsParameterBound(nameof(Sort)))
                        requestConfiguration.QueryParameters.Orderby = Sort;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                    if (this.IsParameterBound(nameof(Top)))
                        requestConfiguration.QueryParameters.Top = Top;

                    if (this.IsParameterBound(nameof(Skip)))
                        requestConfiguration.QueryParameters.Skip = Skip;

                    if (Count.IsPresent)
                        requestConfiguration.QueryParameters.Count = true;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EdiscoveryCaseId);
                return;
            }

            WriteObject(result);
        }
    }
}
