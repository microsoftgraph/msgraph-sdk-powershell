#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("GET", "/sites/{site-id}/termStore/sets/{set-id}/parentGroup/sets/{set-id1}/children/{term-id}")]
    [Cmdlet(VerbsCommon.Get, "MgSiteTermStoreSetParentGroupSetChild_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.Term))]
    public class GetMgSiteTermStoreSetParentGroupSetChild_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SetId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string TermId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.Term? result;
            try
            {
                result = client.Sites[SiteId].TermStore.Sets[SetId].ParentGroup.Sets[SetId1].Children[TermId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TermId);
                return;
            }

            WriteObject(result);
        }
    }
}
