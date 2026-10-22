#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("PATCH", "/admin/windows/updates/products/{product-id}/knownIssues/{knownIssue-id}/resolvingKnowledgeBaseArticle")]
    [Cmdlet(VerbsData.Update, "MgWindowsUpdatesProductKnownIssueResolvingKnowledgeBaseArticle", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.KnowledgeBaseArticle))]
    public class UpdateMgWindowsUpdatesProductKnownIssueResolvingKnowledgeBaseArticleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ProductId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string KnownIssueId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Url { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(KnownIssueId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.KnowledgeBaseArticle();

    if (this.IsParameterBound(nameof(Url)))
        body.Url = Url;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.KnowledgeBaseArticle? result;
            try
            {
                result = client.Admin.Windows.Updates.Products[ProductId].KnownIssues[KnownIssueId].ResolvingKnowledgeBaseArticle.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, KnownIssueId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.Windows.Updates.Products[ProductId].KnownIssues[KnownIssueId].ResolvingKnowledgeBaseArticle.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, KnownIssueId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
