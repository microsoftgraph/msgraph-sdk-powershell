#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Functions.Client;
using Microsoft.Graph.PowerShell.Users.Functions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users.Functions
{
    [GraphRoute("GET", "/users/{user-id}/exportDeviceAndAppManagementData()")]
    [Cmdlet(VerbsData.Export, "MgUserDeviceAndAppManagementData")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Functions.Client.Models.DeviceAndAppManagementData))]
    public class ExportMgUserDeviceAndAppManagementDataCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Users.Functions.Client.Models.DeviceAndAppManagementData? result;
            try
            {
                result = client.Users[UserId].ExportDeviceAndAppManagementData.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
