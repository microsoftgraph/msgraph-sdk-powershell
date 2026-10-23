#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client;
using Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CrossDeviceExperiences
{
    [GraphRoute("POST", "/users/{user-id}/devices/provision")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserDeviceProvision", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.ProvisionResponse))]
    public class InvokeMgUserDeviceProvisionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ProvisioningBlob { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Users.Item.Devices.Provision.ProvisionPostRequestBody();

    if (this.IsParameterBound(nameof(ProvisioningBlob)))
        body.ProvisioningBlob = ProvisioningBlob;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.ProvisionResponse? result;
            try
            {
                result = client.Users[UserId].Devices.Provision.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
