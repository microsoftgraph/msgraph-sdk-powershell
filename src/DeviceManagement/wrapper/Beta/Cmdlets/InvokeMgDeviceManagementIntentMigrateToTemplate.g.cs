#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/deviceManagement/intents/{deviceManagementIntent-id}/migrateToTemplate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementIntentMigrateToTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementIntentMigrateToTemplateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementIntentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? NewTemplateId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PreserveCustomValues { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementIntentId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.Intents.Item.MigrateToTemplate.MigrateToTemplatePostRequestBody();

    if (this.IsParameterBound(nameof(NewTemplateId)))
        body.NewTemplateId = NewTemplateId;

    if (this.IsParameterBound(nameof(PreserveCustomValues)))
        body.PreserveCustomValues = PreserveCustomValues;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.Intents[DeviceManagementIntentId].MigrateToTemplate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementIntentId);
                return;
            }

        }
    }
}
