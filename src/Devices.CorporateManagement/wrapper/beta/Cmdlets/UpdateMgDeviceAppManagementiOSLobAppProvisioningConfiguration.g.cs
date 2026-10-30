#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/deviceAppManagement/iosLobAppProvisioningConfigurations/{iosLobAppProvisioningConfiguration-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementiOSLobAppProvisioningConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosLobAppProvisioningConfiguration))]
    public class UpdateMgDeviceAppManagementiOSLobAppProvisioningConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IosLobAppProvisioningConfigurationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Payload { get; set; }

        [Parameter(Mandatory = false)]
        public string? PayloadFileName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public int? Version { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IosLobAppProvisioningConfigurationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosLobAppProvisioningConfiguration();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Payload)))
        body.Payload = Payload;

    if (this.IsParameterBound(nameof(PayloadFileName)))
        body.PayloadFileName = PayloadFileName;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosLobAppProvisioningConfiguration? result;
            try
            {
                result = client.DeviceAppManagement.IosLobAppProvisioningConfigurations[IosLobAppProvisioningConfigurationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, IosLobAppProvisioningConfigurationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.IosLobAppProvisioningConfigurations[IosLobAppProvisioningConfigurationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, IosLobAppProvisioningConfigurationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
