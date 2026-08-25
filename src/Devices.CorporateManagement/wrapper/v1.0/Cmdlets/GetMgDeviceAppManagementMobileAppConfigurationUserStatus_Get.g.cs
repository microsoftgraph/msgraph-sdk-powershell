#nullable enable

using System;
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
    [GraphRoute("GET", "/deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfiguration-id}/userStatuses/{managedDeviceMobileAppConfigurationUserStatus-id}")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceAppManagementMobileAppConfigurationUserStatus_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedDeviceMobileAppConfigurationUserStatus))]
    public class GetMgDeviceAppManagementMobileAppConfigurationUserStatus_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceMobileAppConfigurationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedDeviceMobileAppConfigurationUserStatusId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedDeviceMobileAppConfigurationUserStatus? result;
            try
            {
                result = client.DeviceAppManagement.MobileAppConfigurations[ManagedDeviceMobileAppConfigurationId].UserStatuses[ManagedDeviceMobileAppConfigurationUserStatusId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceMobileAppConfigurationUserStatusId);
                return;
            }

            WriteObject(result);
        }
    }
}
