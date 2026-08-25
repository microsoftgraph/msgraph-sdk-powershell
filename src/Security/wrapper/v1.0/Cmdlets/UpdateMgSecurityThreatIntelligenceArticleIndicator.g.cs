#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/threatIntelligence/articleIndicators/{articleIndicator-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityThreatIntelligenceArticleIndicator", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.ArticleIndicator))]
    public class UpdateMgSecurityThreatIntelligenceArticleIndicatorCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ArticleIndicatorId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.IndicatorSource? Source { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.Artifact? Artifact { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ArticleIndicatorId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.ArticleIndicator();


    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(Artifact)))
        body.Artifact = Artifact;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.ArticleIndicator? result;
            try
            {
                result = client.Security.ThreatIntelligence.ArticleIndicators[ArticleIndicatorId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ArticleIndicatorId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.ThreatIntelligence.ArticleIndicators[ArticleIndicatorId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ArticleIndicatorId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
