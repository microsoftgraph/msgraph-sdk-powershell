#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("GET", "/users/{user-id}/licenseDetails/getTeamsLicensingDetails()")]
    [Cmdlet(VerbsCommon.Get, "MgUserLicenseDetailTeamLicensingDetail")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.TeamsLicensingDetails))]
    public class GetMgUserLicenseDetailTeamLicensingDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Users.Client.Models.TeamsLicensingDetails? result;
            try
            {
                result = client.Users[UserId].LicenseDetails.GetTeamsLicensingDetails.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
