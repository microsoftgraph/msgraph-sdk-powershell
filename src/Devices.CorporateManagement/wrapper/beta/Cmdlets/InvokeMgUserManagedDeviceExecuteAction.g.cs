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
    [GraphRoute("POST", "/users/{user-id}/managedDevices/executeAction")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserManagedDeviceExecuteAction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.BulkManagedDeviceActionResult))]
    public class InvokeMgUserManagedDeviceExecuteActionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

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
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedDeviceRemoteAction? ActionName { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Users.Item.ManagedDevices.ExecuteAction.ExecuteActionPostRequestBody();

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

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.BulkManagedDeviceActionResult? result;
            try
            {
                result = client.Users[UserId].ManagedDevices.ExecuteAction.PostAsync(body, requestConfiguration =>
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
