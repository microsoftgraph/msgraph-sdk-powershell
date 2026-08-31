#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/users/{user-id}/settings/workHoursAndLocations/occurrences/setCurrentLocation")]
    [Cmdlet(VerbsCommon.Set, "MgUserSettingWorkHourAndLocationOccurrenceCurrentLocation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgUserSettingWorkHourAndLocationOccurrenceCurrentLocationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? PlaceId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.WorkLocationUpdateScope? UpdateScope { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.WorkLocationType? WorkLocationType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Users.Client.Users.Item.Settings.WorkHoursAndLocations.Occurrences.SetCurrentLocation.SetCurrentLocationPostRequestBody();

    if (this.IsParameterBound(nameof(PlaceId)))
        body.PlaceId = PlaceId;
    if (this.IsParameterBound(nameof(UpdateScope)))
        body.UpdateScope = UpdateScope;

    if (this.IsParameterBound(nameof(WorkLocationType)))
        body.WorkLocationType = WorkLocationType;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].Settings.WorkHoursAndLocations.Occurrences.SetCurrentLocation.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

        }
    }
}
