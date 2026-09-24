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
    [GraphRoute("GET", "/users/{user-id}/isManagedAppUserBlocked()")]
    [Cmdlet(VerbsCommon.Get, "MgUserIsManagedAppUserBlocked")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Users.Functions.Client.Users.Item.IsManagedAppUserBlocked.IsManagedAppUserBlockedGetResponse))]
    public class GetMgUserIsManagedAppUserBlockedCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.Users.Functions.Client.Users.Item.IsManagedAppUserBlocked.IsManagedAppUserBlockedGetResponse? result;
            try
            {
                result = client.Users[UserId].IsManagedAppUserBlocked.GetAsIsManagedAppUserBlockedGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
