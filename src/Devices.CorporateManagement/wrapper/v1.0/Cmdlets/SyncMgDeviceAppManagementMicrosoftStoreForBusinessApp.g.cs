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
    [GraphRoute("POST", "/deviceAppManagement/syncMicrosoftStoreForBusinessApps")]
    [Cmdlet(VerbsData.Sync, "MgDeviceAppManagementMicrosoftStoreForBusinessApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SyncMgDeviceAppManagementMicrosoftStoreForBusinessAppCommand : GraphClientCmdlet
    {









        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Sync"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceAppManagement.SyncMicrosoftStoreForBusinessApps.PostAsync(requestConfiguration =>
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
