#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/teams/{team-id}/installedApps/{teamsAppInstallation-id}/upgrade")]
    [Cmdlet(VerbsData.Update, "MgTeamInstalledApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class UpdateMgTeamInstalledAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TeamsAppInstallationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppPermissionSet? ConsentedPermissionSet { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamsAppInstallationId, "Update"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Teams.Item.InstalledApps.Item.Upgrade.UpgradePostRequestBody();

    if (this.IsParameterBound(nameof(ConsentedPermissionSet)))
        body.ConsentedPermissionSet = ConsentedPermissionSet;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Teams[TeamId].InstalledApps[TeamsAppInstallationId].Upgrade.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, TeamsAppInstallationId);
                return;
            }

        }
    }
}
