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
    [GraphRoute("POST", "/users/{user-id}/deviceEnrollmentConfigurations/createEnrollmentNotificationConfiguration")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserDeviceEnrollmentConfigurationCreateEnrollmentNotificationConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgUserDeviceEnrollmentConfigurationCreateEnrollmentNotificationConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceEnrollmentConfiguration[]? DeviceEnrollmentNotificationConfigurations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Users.Item.DeviceEnrollmentConfigurations.CreateEnrollmentNotificationConfiguration.CreateEnrollmentNotificationConfigurationPostRequestBody();

    if (this.IsParameterBound(nameof(DeviceEnrollmentNotificationConfigurations)))
        body.DeviceEnrollmentNotificationConfigurations = DeviceEnrollmentNotificationConfigurations!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].DeviceEnrollmentConfigurations.CreateEnrollmentNotificationConfiguration.PostAsync(body, requestConfiguration =>
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
