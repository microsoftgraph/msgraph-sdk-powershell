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
    [GraphRoute("POST", "/deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfiguration-id}/assign")]
    [Cmdlet(VerbsCommon.Set, "MgDeviceAppManagementMobileAppConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgDeviceAppManagementMobileAppConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceMobileAppConfigurationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedDeviceMobileAppConfigurationAssignment[]? Assignments { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceMobileAppConfigurationId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.MobileAppConfigurations.Item.Assign.AssignPostRequestBody();

    if (this.IsParameterBound(nameof(Assignments)))
        body.Assignments = Assignments!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceAppManagement.MobileAppConfigurations[ManagedDeviceMobileAppConfigurationId].Assign.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceMobileAppConfigurationId);
                return;
            }

        }
    }
}
