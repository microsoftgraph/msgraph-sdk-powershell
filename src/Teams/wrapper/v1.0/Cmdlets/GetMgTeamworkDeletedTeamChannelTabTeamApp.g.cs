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
    [GraphRoute("GET", "/teamwork/deletedTeams/{deletedTeam-id}/channels/{channel-id}/tabs/{teamsTab-id}/teamsApp")]
    [Cmdlet(VerbsCommon.Get, "MgTeamworkDeletedTeamChannelTabTeamApp")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsApp))]
    public class GetMgTeamworkDeletedTeamChannelTabTeamAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeletedTeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChannelId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TeamsTabId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsApp? result;
            try
            {
                result = client.Teamwork.DeletedTeams[DeletedTeamId].Channels[ChannelId].Tabs[TeamsTabId].TeamsApp.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, TeamsTabId);
                return;
            }

            WriteObject(result);
        }
    }
}
