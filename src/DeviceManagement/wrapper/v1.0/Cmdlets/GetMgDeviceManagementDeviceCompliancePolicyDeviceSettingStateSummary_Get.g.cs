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
    [GraphRoute("GET", "/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy-id}/deviceSettingStateSummaries/{settingStateDeviceSummary-id}")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementDeviceCompliancePolicyDeviceSettingStateSummary_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SettingStateDeviceSummary))]
    public class GetMgDeviceManagementDeviceCompliancePolicyDeviceSettingStateSummary_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceCompliancePolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SettingStateDeviceSummaryId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SettingStateDeviceSummary? result;
            try
            {
                result = client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].DeviceSettingStateSummaries[SettingStateDeviceSummaryId].GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, SettingStateDeviceSummaryId);
                return;
            }

            WriteObject(result);
        }
    }
}
