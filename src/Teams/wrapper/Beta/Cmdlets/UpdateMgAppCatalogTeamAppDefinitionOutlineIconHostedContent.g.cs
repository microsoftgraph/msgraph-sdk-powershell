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
    [GraphRoute("PATCH", "/appCatalogs/teamsApps/{teamsApp-id}/appDefinitions/{teamsAppDefinition-id}/outlineIcon/hostedContent")]
    [Cmdlet(VerbsData.Update, "MgAppCatalogTeamAppDefinitionOutlineIconHostedContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkHostedContent))]
    public class UpdateMgAppCatalogTeamAppDefinitionOutlineIconHostedContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamsAppId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TeamsAppDefinitionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public byte[]? ContentBytes { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamsAppDefinitionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkHostedContent();

    if (this.IsParameterBound(nameof(ContentBytes)))
        body.ContentBytes = ContentBytes;

    if (this.IsParameterBound(nameof(ContentType)))
        body.ContentType = ContentType;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkHostedContent? result;
            try
            {
                result = client.AppCatalogs.TeamsApps[TeamsAppId].AppDefinitions[TeamsAppDefinitionId].OutlineIcon.HostedContent.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TeamsAppDefinitionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.AppCatalogs.TeamsApps[TeamsAppId].AppDefinitions[TeamsAppDefinitionId].OutlineIcon.HostedContent.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, TeamsAppDefinitionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
