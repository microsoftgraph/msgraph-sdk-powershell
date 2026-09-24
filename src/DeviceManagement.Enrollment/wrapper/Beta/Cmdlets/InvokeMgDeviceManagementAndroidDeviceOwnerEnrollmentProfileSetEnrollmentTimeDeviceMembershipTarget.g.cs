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
    [GraphRoute("POST", "/deviceManagement/androidDeviceOwnerEnrollmentProfiles/{androidDeviceOwnerEnrollmentProfile-id}/setEnrollmentTimeDeviceMembershipTarget")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementAndroidDeviceOwnerEnrollmentProfileSetEnrollmentTimeDeviceMembershipTarget", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.EnrollmentTimeDeviceMembershipTargetResult))]
    public class InvokeMgDeviceManagementAndroidDeviceOwnerEnrollmentProfileSetEnrollmentTimeDeviceMembershipTargetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AndroidDeviceOwnerEnrollmentProfileId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.EnrollmentTimeDeviceMembershipTarget[]? EnrollmentTimeDeviceMembershipTargets { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AndroidDeviceOwnerEnrollmentProfileId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.AndroidDeviceOwnerEnrollmentProfiles.Item.SetEnrollmentTimeDeviceMembershipTarget.SetEnrollmentTimeDeviceMembershipTargetPostRequestBody();

    if (this.IsParameterBound(nameof(EnrollmentTimeDeviceMembershipTargets)))
        body.EnrollmentTimeDeviceMembershipTargets = EnrollmentTimeDeviceMembershipTargets!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.EnrollmentTimeDeviceMembershipTargetResult? result;
            try
            {
                result = client.DeviceManagement.AndroidDeviceOwnerEnrollmentProfiles[AndroidDeviceOwnerEnrollmentProfileId].SetEnrollmentTimeDeviceMembershipTarget.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AndroidDeviceOwnerEnrollmentProfileId);
                return;
            }

            WriteObject(result);
        }
    }
}
