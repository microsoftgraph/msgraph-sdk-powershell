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
    [GraphRoute("POST", "/deviceManagement/androidDeviceOwnerEnrollmentProfiles/{androidDeviceOwnerEnrollmentProfile-id}/createToken")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementAndroidDeviceOwnerEnrollmentProfileCreateToken", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementAndroidDeviceOwnerEnrollmentProfileCreateTokenCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AndroidDeviceOwnerEnrollmentProfileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? TokenValidityInSeconds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AndroidDeviceOwnerEnrollmentProfileId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.AndroidDeviceOwnerEnrollmentProfiles.Item.CreateToken.CreateTokenPostRequestBody();

    if (this.IsParameterBound(nameof(TokenValidityInSeconds)))
        body.TokenValidityInSeconds = TokenValidityInSeconds;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.AndroidDeviceOwnerEnrollmentProfiles[AndroidDeviceOwnerEnrollmentProfileId].CreateToken.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AndroidDeviceOwnerEnrollmentProfileId);
                return;
            }

        }
    }
}
