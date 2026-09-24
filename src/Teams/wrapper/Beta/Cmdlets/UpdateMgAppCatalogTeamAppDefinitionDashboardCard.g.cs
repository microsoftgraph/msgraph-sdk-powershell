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
    [GraphRoute("PATCH", "/appCatalogs/teamsApps/{teamsApp-id}/appDefinitions/{teamsAppDefinition-id}/dashboardCards/{teamsAppDashboardCardDefinition-id}")]
    [Cmdlet(VerbsData.Update, "MgAppCatalogTeamAppDefinitionDashboardCard", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppDashboardCardDefinition))]
    public class UpdateMgAppCatalogTeamAppDefinitionDashboardCardCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamsAppId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TeamsAppDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TeamsAppDashboardCardDefinitionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? PickerGroupId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppDashboardCardContentSource? ContentSource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppDashboardCardSize? DefaultSize { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppDashboardCardIcon? Icon { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamsAppDashboardCardDefinitionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppDashboardCardDefinition();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(PickerGroupId)))
        body.PickerGroupId = PickerGroupId;

    if (this.IsParameterBound(nameof(ContentSource)))
        body.ContentSource = ContentSource;

    if (this.IsParameterBound(nameof(DefaultSize)))
        body.DefaultSize = DefaultSize;

    if (this.IsParameterBound(nameof(Icon)))
        body.Icon = Icon;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppDashboardCardDefinition? result;
            try
            {
                result = client.AppCatalogs.TeamsApps[TeamsAppId].AppDefinitions[TeamsAppDefinitionId].DashboardCards[TeamsAppDashboardCardDefinitionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TeamsAppDashboardCardDefinitionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.AppCatalogs.TeamsApps[TeamsAppId].AppDefinitions[TeamsAppDefinitionId].DashboardCards[TeamsAppDashboardCardDefinitionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, TeamsAppDashboardCardDefinitionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
