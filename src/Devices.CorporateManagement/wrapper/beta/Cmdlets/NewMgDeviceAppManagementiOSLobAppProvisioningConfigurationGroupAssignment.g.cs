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
    [GraphRoute("POST", "/deviceAppManagement/iosLobAppProvisioningConfigurations/{iosLobAppProvisioningConfiguration-id}/groupAssignments")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementiOSLobAppProvisioningConfigurationGroupAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppProvisioningConfigGroupAssignment))]
    public class NewMgDeviceAppManagementiOSLobAppProvisioningConfigurationGroupAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IosLobAppProvisioningConfigurationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? TargetGroupId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IosLobAppProvisioningConfigurationId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppProvisioningConfigGroupAssignment();

    if (this.IsParameterBound(nameof(TargetGroupId)))
        body.TargetGroupId = TargetGroupId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppProvisioningConfigGroupAssignment? result;
            try
            {
                result = client.DeviceAppManagement.IosLobAppProvisioningConfigurations[IosLobAppProvisioningConfigurationId].GroupAssignments.PostAsync(body, requestConfiguration =>
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
