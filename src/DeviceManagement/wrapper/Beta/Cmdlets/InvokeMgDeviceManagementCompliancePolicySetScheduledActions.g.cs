#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/deviceManagement/compliancePolicies/{deviceManagementCompliancePolicy-id}/setScheduledActions")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementCompliancePolicySetScheduledActions", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.CompliancePolicies.Item.SetScheduledActions.SetScheduledActionsPostResponse))]
    public class InvokeMgDeviceManagementCompliancePolicySetScheduledActionsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementCompliancePolicyId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementComplianceScheduledActionForRule[]? ScheduledActions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementCompliancePolicyId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.CompliancePolicies.Item.SetScheduledActions.SetScheduledActionsPostRequestBody();

    if (this.IsParameterBound(nameof(ScheduledActions)))
        body.ScheduledActions = ScheduledActions!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.CompliancePolicies.Item.SetScheduledActions.SetScheduledActionsPostResponse? result;
            try
            {
                result = client.DeviceManagement.CompliancePolicies[DeviceManagementCompliancePolicyId].SetScheduledActions.PostAsSetScheduledActionsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementCompliancePolicyId);
                return;
            }

            WriteObject(result);
        }
    }
}
