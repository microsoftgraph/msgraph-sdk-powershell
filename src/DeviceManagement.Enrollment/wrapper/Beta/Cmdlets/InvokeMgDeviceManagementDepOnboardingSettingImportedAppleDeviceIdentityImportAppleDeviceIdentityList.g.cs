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
    [GraphRoute("POST", "/deviceManagement/depOnboardingSettings/{depOnboardingSetting-id}/importedAppleDeviceIdentities/importAppleDeviceIdentityList")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementDepOnboardingSettingImportedAppleDeviceIdentityImportAppleDeviceIdentityList", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.Item.ImportedAppleDeviceIdentities.ImportAppleDeviceIdentityList.ImportAppleDeviceIdentityListPostResponse))]
    public class InvokeMgDeviceManagementDepOnboardingSettingImportedAppleDeviceIdentityImportAppleDeviceIdentityListCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DepOnboardingSettingId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? OverwriteImportedDeviceIdentities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedAppleDeviceIdentity[]? ImportedAppleDeviceIdentities { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DepOnboardingSettingId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.Item.ImportedAppleDeviceIdentities.ImportAppleDeviceIdentityList.ImportAppleDeviceIdentityListPostRequestBody();

    if (this.IsParameterBound(nameof(OverwriteImportedDeviceIdentities)))
        body.OverwriteImportedDeviceIdentities = OverwriteImportedDeviceIdentities;
    if (this.IsParameterBound(nameof(ImportedAppleDeviceIdentities)))
        body.ImportedAppleDeviceIdentities = ImportedAppleDeviceIdentities!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.Item.ImportedAppleDeviceIdentities.ImportAppleDeviceIdentityList.ImportAppleDeviceIdentityListPostResponse? result;
            try
            {
                result = client.DeviceManagement.DepOnboardingSettings[DepOnboardingSettingId].ImportedAppleDeviceIdentities.ImportAppleDeviceIdentityList.PostAsImportAppleDeviceIdentityListPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DepOnboardingSettingId);
                return;
            }

            WriteObject(result);
        }
    }
}
