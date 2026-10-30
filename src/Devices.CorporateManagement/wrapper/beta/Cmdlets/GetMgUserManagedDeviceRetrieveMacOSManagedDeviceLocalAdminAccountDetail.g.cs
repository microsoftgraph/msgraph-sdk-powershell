#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/users/{user-id}/managedDevices/{managedDevice-id}/retrieveMacOSManagedDeviceLocalAdminAccountDetail()")]
    [Cmdlet(VerbsCommon.Get, "MgUserManagedDeviceRetrieveMacOSManagedDeviceLocalAdminAccountDetail")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MacOSManagedDeviceLocalAdminAccountDetail))]
    public class GetMgUserManagedDeviceRetrieveMacOSManagedDeviceLocalAdminAccountDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedDeviceId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MacOSManagedDeviceLocalAdminAccountDetail? result;
            try
            {
                result = client.Users[UserId].ManagedDevices[ManagedDeviceId].RetrieveMacOSManagedDeviceLocalAdminAccountDetail.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceId);
                return;
            }

            WriteObject(result);
        }
    }
}
