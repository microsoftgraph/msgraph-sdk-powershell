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
    [GraphRoute("POST", "/deviceAppManagement/deviceAppManagementTasks/{deviceAppManagementTask-id}/updateStatus")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceAppManagementTaskUpdateStatus", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceAppManagementTaskUpdateStatusCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceAppManagementTaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Note { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceAppManagementTaskStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceAppManagementTaskId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.DeviceAppManagementTasks.Item.UpdateStatus.UpdateStatusPostRequestBody();

    if (this.IsParameterBound(nameof(Note)))
        body.Note = Note;
    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceAppManagement.DeviceAppManagementTasks[DeviceAppManagementTaskId].UpdateStatus.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceAppManagementTaskId);
                return;
            }

        }
    }
}
