#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/iosLobAppProvisioningConfigurations/{iosLobAppProvisioningConfiguration-id}/assign")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceAppManagementiOSLobAppProvisioningConfigurationAssign", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceAppManagementiOSLobAppProvisioningConfigurationAssignCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IosLobAppProvisioningConfigurationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppProvisioningConfigGroupAssignment[]? AppProvisioningConfigurationGroupAssignments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosLobAppProvisioningConfigurationAssignment[]? IOSLobAppProvisioningConfigAssignments { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IosLobAppProvisioningConfigurationId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.IosLobAppProvisioningConfigurations.Item.Assign.AssignPostRequestBody();

    if (this.IsParameterBound(nameof(AppProvisioningConfigurationGroupAssignments)))
        body.AppProvisioningConfigurationGroupAssignments = AppProvisioningConfigurationGroupAssignments!.ToList();

    if (this.IsParameterBound(nameof(IOSLobAppProvisioningConfigAssignments)))
        body.IOSLobAppProvisioningConfigAssignments = IOSLobAppProvisioningConfigAssignments!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceAppManagement.IosLobAppProvisioningConfigurations[IosLobAppProvisioningConfigurationId].Assign.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, IosLobAppProvisioningConfigurationId);
                return;
            }

        }
    }
}
