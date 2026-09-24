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
    [GraphRoute("POST", "/deviceManagement/deviceCompliancePolicies/setScheduledRetireState")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementDeviceCompliancePolicySetScheduledRetireState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementDeviceCompliancePolicySetScheduledRetireStateCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? ScopedToAllDevices { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ManagedDeviceIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ScheduledRetireState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceCompliancePolicies.SetScheduledRetireState.SetScheduledRetireStatePostRequestBody();

    if (this.IsParameterBound(nameof(ScopedToAllDevices)))
        body.ScopedToAllDevices = ScopedToAllDevices;

    if (this.IsParameterBound(nameof(ManagedDeviceIds)))
        body.ManagedDeviceIds = ManagedDeviceIds!.ToList();
    if (this.IsParameterBound(nameof(State)))
        body.State = State;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.DeviceCompliancePolicies.SetScheduledRetireState.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

        }
    }
}
