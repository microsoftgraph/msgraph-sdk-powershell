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
    [GraphRoute("POST", "/deviceManagement/androidManagedStoreAccountEnterpriseSettings/requestEnterpriseUpgradeUrl")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementAndroidManagedStoreAccountEnterpriseSettingRequestEnterpriseUpgradeUrl", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.RequestEnterpriseUpgradeUrl.RequestEnterpriseUpgradeUrlPostResponse))]
    public class InvokeMgDeviceManagementAndroidManagedStoreAccountEnterpriseSettingRequestEnterpriseUpgradeUrlCommand : GraphClientCmdlet
    {









        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.RequestEnterpriseUpgradeUrl.RequestEnterpriseUpgradeUrlPostResponse? result;
            try
            {
                result = client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.RequestEnterpriseUpgradeUrl.PostAsRequestEnterpriseUpgradeUrlPostResponseAsync(requestConfiguration =>
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
