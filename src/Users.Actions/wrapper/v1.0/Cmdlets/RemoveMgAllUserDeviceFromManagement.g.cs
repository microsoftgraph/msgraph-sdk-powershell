#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Actions.Client;
using Microsoft.Graph.PowerShell.Users.Actions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users.Actions
{
    [GraphRoute("POST", "/users/{user-id}/removeAllDevicesFromManagement")]
    [Cmdlet(VerbsCommon.Remove, "MgAllUserDeviceFromManagement", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RemoveMgAllUserDeviceFromManagementCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Remove"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].RemoveAllDevicesFromManagement.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

        }
    }
}
