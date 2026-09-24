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
    [GraphRoute("POST", "/deviceManagement/androidManagedStoreAccountEnterpriseSettings/createGooglePlayWebToken")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementAndroidManagedStoreAccountEnterpriseSettingCreateGooglePlayWebToken", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.CreateGooglePlayWebToken.CreateGooglePlayWebTokenPostResponse))]
    public class InvokeMgDeviceManagementAndroidManagedStoreAccountEnterpriseSettingCreateGooglePlayWebTokenCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? ParentUri { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.CreateGooglePlayWebToken.CreateGooglePlayWebTokenPostRequestBody();

    if (this.IsParameterBound(nameof(ParentUri)))
        body.ParentUri = ParentUri;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.CreateGooglePlayWebToken.CreateGooglePlayWebTokenPostResponse? result;
            try
            {
                result = client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.CreateGooglePlayWebToken.PostAsCreateGooglePlayWebTokenPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
