#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("DELETE", "/sites/{site-id}/termStore/sets/{set-id}/parentGroup/sets/{set-id1}/terms/{term-id}/children/{term-id1}/relations/{relation-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgSiteTermStoreSetParentGroupSetTermChildRelation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgSiteTermStoreSetParentGroupSetTermChildRelationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SetId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string TermId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string TermId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 5)]
        public string RelationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RelationId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.Sites[SiteId].TermStore.Sets[SetId].ParentGroup.Sets[SetId1].Terms[TermId].Children[TermId1].Relations[RelationId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, RelationId);
                return;
            }
        }
    }
}
