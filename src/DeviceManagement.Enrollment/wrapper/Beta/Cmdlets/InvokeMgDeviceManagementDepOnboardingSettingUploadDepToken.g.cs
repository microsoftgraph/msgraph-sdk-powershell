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
    [GraphRoute("POST", "/deviceManagement/depOnboardingSettings/{depOnboardingSetting-id}/uploadDepToken")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementDepOnboardingSettingUploadDepToken", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementDepOnboardingSettingUploadDepTokenCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DepOnboardingSettingId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppleId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DepToken { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DepOnboardingSettingId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DepOnboardingSettings.Item.UploadDepToken.UploadDepTokenPostRequestBody();

    if (this.IsParameterBound(nameof(AppleId)))
        body.AppleId = AppleId;

    if (this.IsParameterBound(nameof(DepToken)))
        body.DepToken = DepToken;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.DepOnboardingSettings[DepOnboardingSettingId].UploadDepToken.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DepOnboardingSettingId);
                return;
            }

        }
    }
}
