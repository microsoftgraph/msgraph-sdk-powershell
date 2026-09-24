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
    [GraphRoute("PATCH", "/users/{user-id}/teamwork/installedApps/{userScopeTeamsAppInstallation-id}")]
    [Cmdlet(VerbsData.Update, "MgUserTeamworkInstalledApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.UserScopeTeamsAppInstallation))]
    public class UpdateMgUserTeamworkInstalledAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UserScopeTeamsAppInstallationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppPermissionSet? ConsentedPermissionSet { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppInstallationScopeInfo? ScopeInfo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserScopeTeamsAppInstallationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.UserScopeTeamsAppInstallation();


    if (this.IsParameterBound(nameof(ConsentedPermissionSet)))
        body.ConsentedPermissionSet = ConsentedPermissionSet;

    if (this.IsParameterBound(nameof(ScopeInfo)))
        body.ScopeInfo = ScopeInfo;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.UserScopeTeamsAppInstallation? result;
            try
            {
                result = client.Users[UserId].Teamwork.InstalledApps[UserScopeTeamsAppInstallationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserScopeTeamsAppInstallationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Teamwork.InstalledApps[UserScopeTeamsAppInstallationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UserScopeTeamsAppInstallationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
