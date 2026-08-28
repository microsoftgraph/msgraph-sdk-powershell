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
    [GraphRoute("PATCH", "/security/attackSimulation/landingPages/{landingPage-id}/details/{landingPageDetail-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityAttackSimulationLandingPageDetail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.LandingPageDetail))]
    public class UpdateMgSecurityAttackSimulationLandingPageDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string LandingPageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string LandingPageDetailId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Content { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDefaultLangauge { get; set; }

        [Parameter(Mandatory = false)]
        public string? Language { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(LandingPageDetailId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.LandingPageDetail();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(IsDefaultLangauge)))
        body.IsDefaultLangauge = IsDefaultLangauge;

    if (this.IsParameterBound(nameof(Language)))
        body.Language = Language;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.LandingPageDetail? result;
            try
            {
                result = client.Security.AttackSimulation.LandingPages[LandingPageId].Details[LandingPageDetailId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, LandingPageDetailId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.AttackSimulation.LandingPages[LandingPageId].Details[LandingPageDetailId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, LandingPageDetailId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
