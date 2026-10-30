#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("DELETE", "/deviceManagement/managedDevices/{managedDevice-id}/deviceHealthScriptStates/id='{id}',policyId='{policyId}',deviceId='{deviceId}'")]
    [Cmdlet(VerbsCommon.Remove, "MgDeviceManagementManagedDeviceHealthScriptStateIdidpolicyIdpolicyIddeviceIddeviceId", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgDeviceManagementManagedDeviceHealthScriptStateIdidpolicyIdpolicyIddeviceIddeviceIdCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string Id { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string DeviceId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ManagedDevices.Item.DeviceHealthScriptStates.WithIdWithPolicyIdWithDeviceId.WithIdWithPolicyIdWithDeviceIdRequestBuilder(new global::System.Collections.Generic.Dictionary<string, object> { { "baseurl", requestAdapter.BaseUrl! }, { "managedDevice%2Did", ManagedDeviceId }, { "id", Id }, { "policyId", PolicyId }, { "deviceId", DeviceId }, }, requestAdapter).DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceId);
                return;
            }
        }
    }
}
