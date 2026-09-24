#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("POST", "/deviceManagement/deviceEnrollmentConfigurations/createEnrollmentNotificationConfiguration")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementDeviceEnrollmentConfigurationCreateEnrollmentNotificationConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementDeviceEnrollmentConfigurationCreateEnrollmentNotificationConfigurationCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DeviceEnrollmentConfiguration[]? DeviceEnrollmentNotificationConfigurations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DeviceEnrollmentConfigurations.CreateEnrollmentNotificationConfiguration.CreateEnrollmentNotificationConfigurationPostRequestBody();

    if (this.IsParameterBound(nameof(DeviceEnrollmentNotificationConfigurations)))
        body.DeviceEnrollmentNotificationConfigurations = DeviceEnrollmentNotificationConfigurations!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.DeviceEnrollmentConfigurations.CreateEnrollmentNotificationConfiguration.PostAsync(body, requestConfiguration =>
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
