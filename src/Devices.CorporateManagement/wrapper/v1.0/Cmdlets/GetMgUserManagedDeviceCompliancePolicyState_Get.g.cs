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
    [GraphRoute("GET", "/users/{user-id}/managedDevices/{managedDevice-id}/deviceCompliancePolicyStates/{deviceCompliancePolicyState-id}")]
    [Cmdlet(VerbsCommon.Get, "MgUserManagedDeviceCompliancePolicyState_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceCompliancePolicyState))]
    public class GetMgUserManagedDeviceCompliancePolicyState_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedDeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
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

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceCompliancePolicyState? result;
            try
            {
                result = client.Users[UserId].ManagedDevices[ManagedDeviceId].DeviceCompliancePolicyStates[DeviceCompliancePolicyStateId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceCompliancePolicyStateId);
                return;
            }

            WriteObject(result);
        }
    }
}
