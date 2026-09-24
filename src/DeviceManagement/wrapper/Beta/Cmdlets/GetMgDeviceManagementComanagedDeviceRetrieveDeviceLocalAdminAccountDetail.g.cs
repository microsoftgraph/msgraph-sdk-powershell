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
    [GraphRoute("GET", "/deviceManagement/comanagedDevices/{managedDevice-id}/retrieveDeviceLocalAdminAccountDetail()")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementComanagedDeviceRetrieveDeviceLocalAdminAccountDetail")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceLocalAdminAccountDetail))]
    public class GetMgDeviceManagementComanagedDeviceRetrieveDeviceLocalAdminAccountDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceLocalAdminAccountDetail? result;
            try
            {
                result = client.DeviceManagement.ComanagedDevices[ManagedDeviceId].RetrieveDeviceLocalAdminAccountDetail.GetAsync(requestConfiguration =>
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
