#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("POST", "/deviceManagement/virtualEndpoint/provisioningPolicies/{cloudPcProvisioningPolicy-id}/assignments")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementVirtualEndpointProvisioningPolicyAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcProvisioningPolicyAssignment))]
    public class NewMgDeviceManagementVirtualEndpointProvisioningPolicyAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudPcProvisioningPolicyId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcManagementAssignmentTarget? Target { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CloudPcProvisioningPolicyId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcProvisioningPolicyAssignment();


    if (this.IsParameterBound(nameof(Target)))
        body.Target = Target;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcProvisioningPolicyAssignment? result;
            try
            {
                result = client.DeviceManagement.VirtualEndpoint.ProvisioningPolicies[CloudPcProvisioningPolicyId].Assignments.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
