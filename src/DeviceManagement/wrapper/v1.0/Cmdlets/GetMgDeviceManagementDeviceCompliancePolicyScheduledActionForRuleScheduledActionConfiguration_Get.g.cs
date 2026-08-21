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
    [GraphRoute("GET", "/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy-id}/scheduledActionsForRule/{deviceComplianceScheduledActionForRule-id}/scheduledActionConfigurations/{deviceComplianceActionItem-id}")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementDeviceCompliancePolicyScheduledActionForRuleScheduledActionConfiguration_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceActionItem))]
    public class GetMgDeviceManagementDeviceCompliancePolicyScheduledActionForRuleScheduledActionConfiguration_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceCompliancePolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceComplianceScheduledActionForRuleId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DeviceComplianceActionItemId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceActionItem? result;
            try
            {
                result = client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].ScheduledActionsForRule[DeviceComplianceScheduledActionForRuleId].ScheduledActionConfigurations[DeviceComplianceActionItemId].GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, DeviceComplianceActionItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
