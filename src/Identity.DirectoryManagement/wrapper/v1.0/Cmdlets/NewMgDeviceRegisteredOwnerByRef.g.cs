#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/devices/{device-id}/registeredOwners/$ref")]
    [Cmdlet(VerbsCommon.New, "MgDeviceRegisteredOwnerByRef", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class NewMgDeviceRegisteredOwnerByRefCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? OdataId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ReferenceCreate();

    if (this.IsParameterBound(nameof(OdataId)))
        body.OdataId = OdataId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Devices[DeviceId].RegisteredOwners.Ref.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceId);
                return;
            }

        }
    }
}
