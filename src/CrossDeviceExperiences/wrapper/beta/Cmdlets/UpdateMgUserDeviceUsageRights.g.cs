#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client;
using Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CrossDeviceExperiences
{
    [GraphRoute("PATCH", "/users/{user-id}/devices/{device-id}/usageRights/{usageRight-id}")]
    [Cmdlet(VerbsData.Update, "MgUserDeviceUsageRights", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.UsageRight))]
    public class UpdateMgUserDeviceUsageRightsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string UsageRightId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CatalogId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServiceIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.UsageRightState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UsageRightId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.UsageRight();

    if (this.IsParameterBound(nameof(CatalogId)))
        body.CatalogId = CatalogId;

    if (this.IsParameterBound(nameof(ServiceIdentifier)))
        body.ServiceIdentifier = ServiceIdentifier;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.UsageRight? result;
            try
            {
                result = client.Users[UserId].Devices[DeviceId].UsageRights[UsageRightId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UsageRightId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Devices[DeviceId].UsageRights[UsageRightId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UsageRightId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
