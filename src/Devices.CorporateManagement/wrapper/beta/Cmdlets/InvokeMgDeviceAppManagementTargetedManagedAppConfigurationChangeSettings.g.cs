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
    [GraphRoute("POST", "/deviceAppManagement/targetedManagedAppConfigurations/{targetedManagedAppConfiguration-id}/changeSettings")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceAppManagementTargetedManagedAppConfigurationChangeSettings", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceAppManagementTargetedManagedAppConfigurationChangeSettingsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TargetedManagedAppConfigurationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceManagementConfigurationSetting[]? Settings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TargetedManagedAppConfigurationId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.TargetedManagedAppConfigurations.Item.ChangeSettings.ChangeSettingsPostRequestBody();

    if (this.IsParameterBound(nameof(Settings)))
        body.Settings = Settings!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceAppManagement.TargetedManagedAppConfigurations[TargetedManagedAppConfigurationId].ChangeSettings.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TargetedManagedAppConfigurationId);
                return;
            }

        }
    }
}
