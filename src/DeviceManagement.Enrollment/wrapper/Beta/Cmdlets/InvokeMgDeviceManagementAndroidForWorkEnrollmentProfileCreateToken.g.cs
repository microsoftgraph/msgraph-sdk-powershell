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
    [GraphRoute("POST", "/deviceManagement/androidForWorkEnrollmentProfiles/{androidForWorkEnrollmentProfile-id}/createToken")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementAndroidForWorkEnrollmentProfileCreateToken", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementAndroidForWorkEnrollmentProfileCreateTokenCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AndroidForWorkEnrollmentProfileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? TokenValidityInSeconds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AndroidForWorkEnrollmentProfileId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.AndroidForWorkEnrollmentProfiles.Item.CreateToken.CreateTokenPostRequestBody();

    if (this.IsParameterBound(nameof(TokenValidityInSeconds)))
        body.TokenValidityInSeconds = TokenValidityInSeconds;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.AndroidForWorkEnrollmentProfiles[AndroidForWorkEnrollmentProfileId].CreateToken.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AndroidForWorkEnrollmentProfileId);
                return;
            }

        }
    }
}
