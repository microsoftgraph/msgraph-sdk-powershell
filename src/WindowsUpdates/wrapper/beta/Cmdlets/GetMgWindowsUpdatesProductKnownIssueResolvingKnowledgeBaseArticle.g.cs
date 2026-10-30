#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("GET", "/admin/windows/updates/products/{product-id}/knownIssues/{knownIssue-id}/resolvingKnowledgeBaseArticle")]
    [Cmdlet(VerbsCommon.Get, "MgWindowsUpdatesProductKnownIssueResolvingKnowledgeBaseArticle")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.KnowledgeBaseArticle))]
    public class GetMgWindowsUpdatesProductKnownIssueResolvingKnowledgeBaseArticleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ProductId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string KnownIssueId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.KnowledgeBaseArticle? result;
            try
            {
                result = client.Admin.Windows.Updates.Products[ProductId].KnownIssues[KnownIssueId].ResolvingKnowledgeBaseArticle.GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, KnownIssueId);
                return;
            }

            WriteObject(result);
        }
    }
}
