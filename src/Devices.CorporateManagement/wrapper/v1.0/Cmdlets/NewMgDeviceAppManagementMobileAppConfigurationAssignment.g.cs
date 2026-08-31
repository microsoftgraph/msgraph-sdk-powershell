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
    [GraphRoute("POST", "/deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfiguration-id}/assignments")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementMobileAppConfigurationAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedDeviceMobileAppConfigurationAssignment))]
    public class NewMgDeviceAppManagementMobileAppConfigurationAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceMobileAppConfigurationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceAndAppManagementAssignmentTarget? Target { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceMobileAppConfigurationId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedDeviceMobileAppConfigurationAssignment();


    if (this.IsParameterBound(nameof(Target)))
        body.Target = Target;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedDeviceMobileAppConfigurationAssignment? result;
            try
            {
                result = client.DeviceAppManagement.MobileAppConfigurations[ManagedDeviceMobileAppConfigurationId].Assignments.PostAsync(body, requestConfiguration =>
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
