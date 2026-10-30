#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/deviceAppManagement/policySets/getPolicySets")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceAppManagementPolicySetGetPolicySets", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.PolicySets.GetPolicySets.GetPolicySetsPostResponse))]
    public class InvokeMgDeviceAppManagementPolicySetGetPolicySetsCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? PolicySetIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.PolicySets.GetPolicySets.GetPolicySetsPostRequestBody();

    if (this.IsParameterBound(nameof(PolicySetIds)))
        body.PolicySetIds = PolicySetIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.PolicySets.GetPolicySets.GetPolicySetsPostResponse? result;
            try
            {
                result = client.DeviceAppManagement.PolicySets.GetPolicySets.PostAsGetPolicySetsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
