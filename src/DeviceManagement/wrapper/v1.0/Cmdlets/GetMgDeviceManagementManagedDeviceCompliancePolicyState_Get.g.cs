#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("GET", "/deviceManagement/managedDevices/{managedDevice-id}/deviceCompliancePolicyStates/{deviceCompliancePolicyState-id}")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementManagedDeviceCompliancePolicyState_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicyState))]
    public class GetMgDeviceManagementManagedDeviceCompliancePolicyState_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceCompliancePolicyStateId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicyState? result;
            try
            {
                result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].DeviceCompliancePolicyStates[DeviceCompliancePolicyStateId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DeviceCompliancePolicyStateId);
                return;
            }

            WriteObject(result);
        }
    }
}
