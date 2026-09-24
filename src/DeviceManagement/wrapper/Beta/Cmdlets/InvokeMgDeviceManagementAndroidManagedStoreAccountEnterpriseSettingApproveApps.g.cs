#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/androidManagedStoreAccountEnterpriseSettings/approveApps")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementAndroidManagedStoreAccountEnterpriseSettingApproveApps", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementAndroidManagedStoreAccountEnterpriseSettingApproveAppsCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? PackageIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ApproveAllPermissions { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.ApproveApps.ApproveAppsPostRequestBody();

    if (this.IsParameterBound(nameof(PackageIds)))
        body.PackageIds = PackageIds!.ToList();

    if (this.IsParameterBound(nameof(ApproveAllPermissions)))
        body.ApproveAllPermissions = ApproveAllPermissions;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.ApproveApps.PostAsync(body, requestConfiguration =>
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
