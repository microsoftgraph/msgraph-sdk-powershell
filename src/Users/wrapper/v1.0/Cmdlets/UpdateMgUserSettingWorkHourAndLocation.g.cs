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
    [GraphRoute("PATCH", "/users/{user-id}/settings/workHoursAndLocations")]
    [Cmdlet(VerbsData.Update, "MgUserSettingWorkHourAndLocation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.WorkHoursAndLocationsSetting))]
    public class UpdateMgUserSettingWorkHourAndLocationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.MaxWorkLocationDetails? MaxSharedWorkLocationDetails { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.WorkHoursAndLocationsSetting();


    if (this.IsParameterBound(nameof(MaxSharedWorkLocationDetails)))
        body.MaxSharedWorkLocationDetails = MaxSharedWorkLocationDetails;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.WorkHoursAndLocationsSetting? result;
            try
            {
                result = client.Users[UserId].Settings.WorkHoursAndLocations.PatchAsync(body, requestConfiguration =>
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
                    result = client.Users[UserId].Settings.WorkHoursAndLocations.GetAsync().GetAwaiter().GetResult();
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
