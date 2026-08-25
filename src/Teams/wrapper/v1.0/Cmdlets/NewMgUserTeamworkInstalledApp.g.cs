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
    [GraphRoute("POST", "/users/{user-id}/teamwork/installedApps")]
    [Cmdlet(VerbsCommon.New, "MgUserTeamworkInstalledApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.UserScopeTeamsAppInstallation))]
    public class NewMgUserTeamworkInstalledAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppPermissionSet? ConsentedPermissionSet { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.UserScopeTeamsAppInstallation();


    if (this.IsParameterBound(nameof(ConsentedPermissionSet)))
        body.ConsentedPermissionSet = ConsentedPermissionSet;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.UserScopeTeamsAppInstallation? result;
            try
            {
                result = client.Users[UserId].Teamwork.InstalledApps.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
