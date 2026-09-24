#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Actions.Client;
using Microsoft.Graph.PowerShell.Users.Actions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users.Actions
{
    [GraphRoute("POST", "/users/{user-id}/wipeManagedAppRegistrationByDeviceTag")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserWipeManagedAppRegistrationByDeviceTag", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgUserWipeManagedAppRegistrationByDeviceTagCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DeviceTag { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.WipeManagedAppRegistrationByDeviceTag.WipeManagedAppRegistrationByDeviceTagPostRequestBody();

    if (this.IsParameterBound(nameof(DeviceTag)))
        body.DeviceTag = DeviceTag;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].WipeManagedAppRegistrationByDeviceTag.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

        }
    }
}
