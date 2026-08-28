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
    [GraphRoute("POST", "/deviceManagement/virtualEndpoint/onPremisesConnections")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementVirtualEndpointOnPremiseConnection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcOnPremisesConnection))]
    public class NewMgDeviceManagementVirtualEndpointOnPremiseConnectionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AdDomainName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AdDomainPassword { get; set; }

        [Parameter(Mandatory = false)]
        public string? AdDomainUsername { get; set; }

        [Parameter(Mandatory = false)]
        public string? AlternateResourceUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HealthCheckPaused { get; set; }

        [Parameter(Mandatory = false)]
        public bool? InUse { get; set; }

        [Parameter(Mandatory = false)]
        public bool? InUseByCloudPc { get; set; }

        [Parameter(Mandatory = false)]
        public string? OrganizationalUnit { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceGroupId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ScopeIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? SubnetId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SubscriptionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SubscriptionName { get; set; }

        [Parameter(Mandatory = false)]
        public string? VirtualNetworkId { get; set; }

        [Parameter(Mandatory = false)]
        public string? VirtualNetworkLocation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcOnPremisesConnectionType? ConnectionType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcOnPremisesConnectionStatus? HealthCheckStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcOnPremisesConnectionStatusDetail? HealthCheckStatusDetail { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcOnPremisesConnection();

    if (this.IsParameterBound(nameof(AdDomainName)))
        body.AdDomainName = AdDomainName;

    if (this.IsParameterBound(nameof(AdDomainPassword)))
        body.AdDomainPassword = AdDomainPassword;

    if (this.IsParameterBound(nameof(AdDomainUsername)))
        body.AdDomainUsername = AdDomainUsername;

    if (this.IsParameterBound(nameof(AlternateResourceUrl)))
        body.AlternateResourceUrl = AlternateResourceUrl;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(HealthCheckPaused)))
        body.HealthCheckPaused = HealthCheckPaused;

    if (this.IsParameterBound(nameof(InUse)))
        body.InUse = InUse;

    if (this.IsParameterBound(nameof(InUseByCloudPc)))
        body.InUseByCloudPc = InUseByCloudPc;

    if (this.IsParameterBound(nameof(OrganizationalUnit)))
        body.OrganizationalUnit = OrganizationalUnit;

    if (this.IsParameterBound(nameof(ResourceGroupId)))
        body.ResourceGroupId = ResourceGroupId;

    if (this.IsParameterBound(nameof(ScopeIds)))
        body.ScopeIds = ScopeIds!.ToList();

    if (this.IsParameterBound(nameof(SubnetId)))
        body.SubnetId = SubnetId;

    if (this.IsParameterBound(nameof(SubscriptionId)))
        body.SubscriptionId = SubscriptionId;

    if (this.IsParameterBound(nameof(SubscriptionName)))
        body.SubscriptionName = SubscriptionName;

    if (this.IsParameterBound(nameof(VirtualNetworkId)))
        body.VirtualNetworkId = VirtualNetworkId;

    if (this.IsParameterBound(nameof(VirtualNetworkLocation)))
        body.VirtualNetworkLocation = VirtualNetworkLocation;

    if (this.IsParameterBound(nameof(ConnectionType)))
        body.ConnectionType = ConnectionType;

    if (this.IsParameterBound(nameof(HealthCheckStatus)))
        body.HealthCheckStatus = HealthCheckStatus;

    if (this.IsParameterBound(nameof(HealthCheckStatusDetail)))
        body.HealthCheckStatusDetail = HealthCheckStatusDetail;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcOnPremisesConnection? result;
            try
            {
                result = client.DeviceManagement.VirtualEndpoint.OnPremisesConnections.PostAsync(body, requestConfiguration =>
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
