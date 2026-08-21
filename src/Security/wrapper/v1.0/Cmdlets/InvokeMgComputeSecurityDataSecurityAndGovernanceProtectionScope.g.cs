#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/dataSecurityAndGovernance/protectionScopes/compute")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgComputeSecurityDataSecurityAndGovernanceProtectionScope", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.ProtectionScopes.Compute.ComputePostResponse))]
    public class InvokeMgComputeSecurityDataSecurityAndGovernanceProtectionScopeCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.UserActivityTypes? Activities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PolicyLocation[]? Locations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PolicyPivotProperty? PivotOn { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.DeviceMetadata? DeviceMetadata { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.IntegratedApplicationMetadata? IntegratedAppMetadata { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.ProtectionScopes.Compute.ComputePostRequestBody();

    if (this.IsParameterBound(nameof(Activities)))
        body.Activities = Activities;

    if (this.IsParameterBound(nameof(Locations)))
        body.Locations = Locations!.ToList();

    if (this.IsParameterBound(nameof(PivotOn)))
        body.PivotOn = PivotOn;

    if (this.IsParameterBound(nameof(DeviceMetadata)))
        body.DeviceMetadata = DeviceMetadata;

    if (this.IsParameterBound(nameof(IntegratedAppMetadata)))
        body.IntegratedAppMetadata = IntegratedAppMetadata;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.ProtectionScopes.Compute.ComputePostResponse? result;
            try
            {
                result = client.Security.DataSecurityAndGovernance.ProtectionScopes.Compute.PostAsComputePostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
