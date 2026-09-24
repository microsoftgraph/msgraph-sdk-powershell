#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/deviceManagement/androidManagedStoreAccountEnterpriseSettings/retrieveStoreLayout()")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementAndroidManagedStoreAccountEnterpriseSettingRetrieveStoreLayout")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidManagedStoreLayoutType))]
    public class GetMgDeviceManagementAndroidManagedStoreAccountEnterpriseSettingRetrieveStoreLayoutCommand : GraphClientCmdlet
    {










        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidManagedStoreLayoutType? result;
            try
            {
                result = client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.RetrieveStoreLayout.GetAsync(requestConfiguration =>
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
