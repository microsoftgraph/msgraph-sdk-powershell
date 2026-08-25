#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("GET", "/users/{user-id}/teamwork/installedApps/{userScopeTeamsAppInstallation-id}/teamsAppDefinition")]
    [Cmdlet(VerbsCommon.Get, "MgUserTeamworkInstalledAppTeamAppDefinition")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppDefinition))]
    public class GetMgUserTeamworkInstalledAppTeamAppDefinitionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UserScopeTeamsAppInstallationId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppDefinition? result;
            try
            {
                result = client.Users[UserId].Teamwork.InstalledApps[UserScopeTeamsAppInstallationId].TeamsAppDefinition.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, UserScopeTeamsAppInstallationId);
                return;
            }

            WriteObject(result);
        }
    }
}
