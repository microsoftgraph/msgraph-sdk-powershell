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
    [GraphRoute("POST", "/deviceManagement/virtualEndpoint/provisioningPolicies")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementVirtualEndpointProvisioningPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcProvisioningPolicy))]
    public class NewMgDeviceManagementVirtualEndpointProvisioningPolicyCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AlternateResourceUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? CloudPcGroupDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? CloudPcNamingTemplate { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? EnableSingleSignOn { get; set; }

        [Parameter(Mandatory = false)]
        public int? GracePeriodInHours { get; set; }

        [Parameter(Mandatory = false)]
        public string? ImageDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ImageId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? LocalAdminEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcProvisioningPolicyAutopatch? Autopatch { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcDomainJoinConfiguration[]? DomainJoinConfigurations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcProvisioningPolicyImageType? ImageType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MicrosoftManagedDesktop? MicrosoftManagedDesktop { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcProvisioningType? ProvisioningType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcWindowsSetting? WindowsSetting { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcProvisioningPolicy();

    if (this.IsParameterBound(nameof(AlternateResourceUrl)))
        body.AlternateResourceUrl = AlternateResourceUrl;

    if (this.IsParameterBound(nameof(CloudPcGroupDisplayName)))
        body.CloudPcGroupDisplayName = CloudPcGroupDisplayName;

    if (this.IsParameterBound(nameof(CloudPcNamingTemplate)))
        body.CloudPcNamingTemplate = CloudPcNamingTemplate;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EnableSingleSignOn)))
        body.EnableSingleSignOn = EnableSingleSignOn;

    if (this.IsParameterBound(nameof(GracePeriodInHours)))
        body.GracePeriodInHours = GracePeriodInHours;

    if (this.IsParameterBound(nameof(ImageDisplayName)))
        body.ImageDisplayName = ImageDisplayName;

    if (this.IsParameterBound(nameof(ImageId)))
        body.ImageId = ImageId;

    if (this.IsParameterBound(nameof(LocalAdminEnabled)))
        body.LocalAdminEnabled = LocalAdminEnabled;

    if (this.IsParameterBound(nameof(Autopatch)))
        body.Autopatch = Autopatch;

    if (this.IsParameterBound(nameof(DomainJoinConfigurations)))
        body.DomainJoinConfigurations = DomainJoinConfigurations!.ToList();

    if (this.IsParameterBound(nameof(ImageType)))
        body.ImageType = ImageType;

    if (this.IsParameterBound(nameof(MicrosoftManagedDesktop)))
        body.MicrosoftManagedDesktop = MicrosoftManagedDesktop;

    if (this.IsParameterBound(nameof(ProvisioningType)))
        body.ProvisioningType = ProvisioningType;

    if (this.IsParameterBound(nameof(WindowsSetting)))
        body.WindowsSetting = WindowsSetting;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcProvisioningPolicy? result;
            try
            {
                result = client.DeviceManagement.VirtualEndpoint.ProvisioningPolicies.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
