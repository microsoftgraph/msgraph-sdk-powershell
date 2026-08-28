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
    [GraphRoute("PATCH", "/teamwork/teamsAppSettings")]
    [Cmdlet(VerbsData.Update, "MgTeamworkTeamAppSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppSettings))]
    public class UpdateMgTeamworkTeamAppSettingCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? AllowUserRequestsForAppAccess { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsUserPersonalScopeResourceSpecificConsentEnabled { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppSettings();

    if (this.IsParameterBound(nameof(AllowUserRequestsForAppAccess)))
        body.AllowUserRequestsForAppAccess = AllowUserRequestsForAppAccess;

    if (this.IsParameterBound(nameof(IsUserPersonalScopeResourceSpecificConsentEnabled)))
        body.IsUserPersonalScopeResourceSpecificConsentEnabled = IsUserPersonalScopeResourceSpecificConsentEnabled;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAppSettings? result;
            try
            {
                result = client.Teamwork.TeamsAppSettings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Teamwork.TeamsAppSettings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
