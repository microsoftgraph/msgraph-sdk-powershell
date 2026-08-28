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
    [GraphRoute("POST", "/deviceAppManagement/managedAppRegistrations/{managedAppRegistration-id}/appliedPolicies/{managedAppPolicy-id}/targetApps")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgTargetDeviceAppManagementManagedAppRegistrationAppliedPolicyApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgTargetDeviceAppManagementManagedAppRegistrationAppliedPolicyAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedAppRegistrationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedAppPolicyId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedMobileApp[]? Apps { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedAppPolicyId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.ManagedAppRegistrations.Item.AppliedPolicies.Item.TargetApps.TargetAppsPostRequestBody();

    if (this.IsParameterBound(nameof(Apps)))
        body.Apps = Apps!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceAppManagement.ManagedAppRegistrations[ManagedAppRegistrationId].AppliedPolicies[ManagedAppPolicyId].TargetApps.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ManagedAppPolicyId);
                return;
            }

        }
    }
}
