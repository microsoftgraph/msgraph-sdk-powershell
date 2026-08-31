#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("POST", "/deviceManagement/mobileThreatDefenseConnectors")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementMobileThreatDefenseConnector", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MobileThreatDefenseConnector))]
    public class NewMgDeviceManagementMobileThreatDefenseConnectorCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? AllowPartnerToCollectIOSApplicationMetadata { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowPartnerToCollectIOSPersonalApplicationMetadata { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AndroidDeviceBlockedOnMissingPartnerData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AndroidEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AndroidMobileApplicationManagementEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IosDeviceBlockedOnMissingPartnerData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IosEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IosMobileApplicationManagementEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastHeartbeatDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? MicrosoftDefenderForEndpointAttachEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public int? PartnerUnresponsivenessThresholdInDays { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PartnerUnsupportedOsVersionBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? WindowsDeviceBlockedOnMissingPartnerData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? WindowsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MobileThreatPartnerTenantState? PartnerState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MobileThreatDefenseConnector();

    if (this.IsParameterBound(nameof(AllowPartnerToCollectIOSApplicationMetadata)))
        body.AllowPartnerToCollectIOSApplicationMetadata = AllowPartnerToCollectIOSApplicationMetadata;

    if (this.IsParameterBound(nameof(AllowPartnerToCollectIOSPersonalApplicationMetadata)))
        body.AllowPartnerToCollectIOSPersonalApplicationMetadata = AllowPartnerToCollectIOSPersonalApplicationMetadata;

    if (this.IsParameterBound(nameof(AndroidDeviceBlockedOnMissingPartnerData)))
        body.AndroidDeviceBlockedOnMissingPartnerData = AndroidDeviceBlockedOnMissingPartnerData;

    if (this.IsParameterBound(nameof(AndroidEnabled)))
        body.AndroidEnabled = AndroidEnabled;

    if (this.IsParameterBound(nameof(AndroidMobileApplicationManagementEnabled)))
        body.AndroidMobileApplicationManagementEnabled = AndroidMobileApplicationManagementEnabled;

    if (this.IsParameterBound(nameof(IosDeviceBlockedOnMissingPartnerData)))
        body.IosDeviceBlockedOnMissingPartnerData = IosDeviceBlockedOnMissingPartnerData;

    if (this.IsParameterBound(nameof(IosEnabled)))
        body.IosEnabled = IosEnabled;

    if (this.IsParameterBound(nameof(IosMobileApplicationManagementEnabled)))
        body.IosMobileApplicationManagementEnabled = IosMobileApplicationManagementEnabled;

    if (this.IsParameterBound(nameof(LastHeartbeatDateTime)))
        body.LastHeartbeatDateTime = LastHeartbeatDateTime;

    if (this.IsParameterBound(nameof(MicrosoftDefenderForEndpointAttachEnabled)))
        body.MicrosoftDefenderForEndpointAttachEnabled = MicrosoftDefenderForEndpointAttachEnabled;

    if (this.IsParameterBound(nameof(PartnerUnresponsivenessThresholdInDays)))
        body.PartnerUnresponsivenessThresholdInDays = PartnerUnresponsivenessThresholdInDays;

    if (this.IsParameterBound(nameof(PartnerUnsupportedOsVersionBlocked)))
        body.PartnerUnsupportedOsVersionBlocked = PartnerUnsupportedOsVersionBlocked;

    if (this.IsParameterBound(nameof(WindowsDeviceBlockedOnMissingPartnerData)))
        body.WindowsDeviceBlockedOnMissingPartnerData = WindowsDeviceBlockedOnMissingPartnerData;

    if (this.IsParameterBound(nameof(WindowsEnabled)))
        body.WindowsEnabled = WindowsEnabled;

    if (this.IsParameterBound(nameof(PartnerState)))
        body.PartnerState = PartnerState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MobileThreatDefenseConnector? result;
            try
            {
                result = client.DeviceManagement.MobileThreatDefenseConnectors.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
