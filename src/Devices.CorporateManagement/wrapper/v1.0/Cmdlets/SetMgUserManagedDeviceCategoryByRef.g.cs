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
    [GraphRoute("PUT", "/users/{user-id}/managedDevices/{managedDevice-id}/deviceCategory/$ref")]
    [Cmdlet(VerbsCommon.Set, "MgUserManagedDeviceCategoryByRef", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgUserManagedDeviceCategoryByRefCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? OdataId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceId, "Set"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ReferenceUpdate();

    if (this.IsParameterBound(nameof(OdataId)))
        body.OdataId = OdataId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].ManagedDevices[ManagedDeviceId].DeviceCategory.Ref.PutAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceId);
                return;
            }

        }
    }
}
