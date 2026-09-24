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
    [GraphRoute("POST", "/deviceManagement/managedDevices/executeAction")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementManagedDeviceExecuteAction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BulkManagedDeviceActionResult))]
    public class InvokeMgDeviceManagementManagedDeviceExecuteActionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? KeepEnrollmentData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? KeepUserData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PersistEsimDataPlan { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? DeviceIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? NotificationTitle { get; set; }

        [Parameter(Mandatory = false)]
        public string? NotificationBody { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? CarrierUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeprovisionReason { get; set; }

        [Parameter(Mandatory = false)]
        public string? OrganizationalUnitPath { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceRemoteAction? ActionName { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ManagedDevices.ExecuteAction.ExecuteActionPostRequestBody();

    if (this.IsParameterBound(nameof(KeepEnrollmentData)))
        body.KeepEnrollmentData = KeepEnrollmentData;

    if (this.IsParameterBound(nameof(KeepUserData)))
        body.KeepUserData = KeepUserData;

    if (this.IsParameterBound(nameof(PersistEsimDataPlan)))
        body.PersistEsimDataPlan = PersistEsimDataPlan;

    if (this.IsParameterBound(nameof(DeviceIds)))
        body.DeviceIds = DeviceIds!.ToList();

    if (this.IsParameterBound(nameof(NotificationTitle)))
        body.NotificationTitle = NotificationTitle;

    if (this.IsParameterBound(nameof(NotificationBody)))
        body.NotificationBody = NotificationBody;

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(CarrierUrl)))
        body.CarrierUrl = CarrierUrl;

    if (this.IsParameterBound(nameof(DeprovisionReason)))
        body.DeprovisionReason = DeprovisionReason;

    if (this.IsParameterBound(nameof(OrganizationalUnitPath)))
        body.OrganizationalUnitPath = OrganizationalUnitPath;
    if (this.IsParameterBound(nameof(ActionName)))
        body.ActionName = ActionName;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BulkManagedDeviceActionResult? result;
            try
            {
                result = client.DeviceManagement.ManagedDevices.ExecuteAction.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
