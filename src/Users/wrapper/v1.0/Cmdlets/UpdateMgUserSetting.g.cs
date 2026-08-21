#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("PATCH", "/users/{user-id}/settings")]
    [Cmdlet(VerbsData.Update, "MgUserSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.UserSettings))]
    public class UpdateMgUserSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ContributionToContentDiscoveryDisabled { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.UserSettings();

    if (this.IsParameterBound(nameof(ContributionToContentDiscoveryAsOrganizationDisabled)))
        body.ContributionToContentDiscoveryAsOrganizationDisabled = ContributionToContentDiscoveryAsOrganizationDisabled;

    if (this.IsParameterBound(nameof(ContributionToContentDiscoveryDisabled)))
        body.ContributionToContentDiscoveryDisabled = ContributionToContentDiscoveryDisabled;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.UserSettings? result;
            try
            {
                result = client.Users[UserId].Settings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Settings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, UserId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
