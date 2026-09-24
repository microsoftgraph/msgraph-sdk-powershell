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
    [GraphRoute("POST", "/deviceManagement/configurationPolicies/{deviceManagementConfigurationPolicy-id}/reorder")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementConfigurationPolicyReorder", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementConfigurationPolicyReorderCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementConfigurationPolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? Priority { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementConfigurationPolicyId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ConfigurationPolicies.Item.Reorder.ReorderPostRequestBody();

    if (this.IsParameterBound(nameof(Priority)))
        body.Priority = Priority;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.ConfigurationPolicies[DeviceManagementConfigurationPolicyId].Reorder.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementConfigurationPolicyId);
                return;
            }

        }
    }
}
