#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("PATCH", "/appCatalogs/teamsApps/{teamsApp-id}")]
    [Cmdlet(VerbsData.Update, "MgAppCatalogTeamApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsApp))]
    public class UpdateMgAppCatalogTeamAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamsAppId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppDistributionMethod? DistributionMethod { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamsAppId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsApp();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExternalId)))
        body.ExternalId = ExternalId;

    if (this.IsParameterBound(nameof(DistributionMethod)))
        body.DistributionMethod = DistributionMethod;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsApp? result;
            try
            {
                result = client.AppCatalogs.TeamsApps[TeamsAppId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TeamsAppId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.AppCatalogs.TeamsApps[TeamsAppId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, TeamsAppId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
