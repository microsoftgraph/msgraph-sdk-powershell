#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("POST", "/sites/{site-id}/termStore/sets/{set-id}/terms/{term-id}/children/{term-id1}/relations")]
    [Cmdlet(VerbsCommon.New, "MgSiteTermStoreSetTermChildRelation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.Relation))]
    public class NewMgSiteTermStoreSetTermChildRelationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TermId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string TermId1 { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.RelationType? Relationship { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TermId1, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.Relation();


    if (this.IsParameterBound(nameof(Relationship)))
        body.Relationship = Relationship;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.Relation? result;
            try
            {
                result = client.Sites[SiteId].TermStore.Sets[SetId].Terms[TermId].Children[TermId1].Relations.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
