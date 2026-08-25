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
    [GraphRoute("PATCH", "/groups/{group-id}/sites/{site-id}/termStore/groups/{group-id1}/sets/{set-id}/children/{term-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupSiteTermStoreGroupSetChild", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.Term))]
    public class UpdateMgGroupSiteTermStoreGroupSetChildCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string GroupId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string SetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string TermId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.LocalizedDescription[]? Descriptions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.LocalizedLabel[]? Labels { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.KeyValue[]? Properties { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TermId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.Term();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Descriptions)))
        body.Descriptions = Descriptions!.ToList();

    if (this.IsParameterBound(nameof(Labels)))
        body.Labels = Labels!.ToList();

    if (this.IsParameterBound(nameof(Properties)))
        body.Properties = Properties!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.TermStore.Term? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].TermStore.Groups[GroupId1].Sets[SetId].Children[TermId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TermId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Sites[SiteId].TermStore.Groups[GroupId1].Sets[SetId].Children[TermId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, TermId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
