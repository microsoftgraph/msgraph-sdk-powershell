#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("PATCH", "/deviceManagement/embeddedSIMActivationCodePools/{embeddedSIMActivationCodePool-id}/deviceStates/{embeddedSIMDeviceState-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementEmbeddedSIMActivationCodePoolDeviceState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EmbeddedSIMDeviceState))]
    public class UpdateMgDeviceManagementEmbeddedSIMActivationCodePoolDeviceStateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EmbeddedSIMActivationCodePoolId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EmbeddedSIMDeviceStateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? StateDetails { get; set; }

        [Parameter(Mandatory = false)]
        public string? UniversalIntegratedCircuitCardIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EmbeddedSIMDeviceStateValue? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EmbeddedSIMDeviceStateId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EmbeddedSIMDeviceState();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(LastSyncDateTime)))
        body.LastSyncDateTime = LastSyncDateTime;

    if (this.IsParameterBound(nameof(ModifiedDateTime)))
        body.ModifiedDateTime = ModifiedDateTime;

    if (this.IsParameterBound(nameof(StateDetails)))
        body.StateDetails = StateDetails;

    if (this.IsParameterBound(nameof(UniversalIntegratedCircuitCardIdentifier)))
        body.UniversalIntegratedCircuitCardIdentifier = UniversalIntegratedCircuitCardIdentifier;

    if (this.IsParameterBound(nameof(UserName)))
        body.UserName = UserName;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EmbeddedSIMDeviceState? result;
            try
            {
                result = client.DeviceManagement.EmbeddedSIMActivationCodePools[EmbeddedSIMActivationCodePoolId].DeviceStates[EmbeddedSIMDeviceStateId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EmbeddedSIMDeviceStateId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.EmbeddedSIMActivationCodePools[EmbeddedSIMActivationCodePoolId].DeviceStates[EmbeddedSIMDeviceStateId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, EmbeddedSIMDeviceStateId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
