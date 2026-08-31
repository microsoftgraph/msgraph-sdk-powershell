#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("POST", "/deviceManagement/windowsAutopilotDeviceIdentities")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementWindowsAutopilotDeviceIdentity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotDeviceIdentity))]
    public class NewMgDeviceManagementWindowsAutopilotDeviceIdentityCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AddressableUserName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AzureActiveDirectoryDeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? GroupTag { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastContactedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagedDeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Manufacturer { get; set; }

        [Parameter(Mandatory = false)]
        public string? Model { get; set; }

        [Parameter(Mandatory = false)]
        public string? ProductKey { get; set; }

        [Parameter(Mandatory = false)]
        public string? PurchaseOrderIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? SerialNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? SkuNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? SystemFamily { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.EnrollmentState? EnrollmentState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotDeviceIdentity();

    if (this.IsParameterBound(nameof(AddressableUserName)))
        body.AddressableUserName = AddressableUserName;

    if (this.IsParameterBound(nameof(AzureActiveDirectoryDeviceId)))
        body.AzureActiveDirectoryDeviceId = AzureActiveDirectoryDeviceId;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(GroupTag)))
        body.GroupTag = GroupTag;

    if (this.IsParameterBound(nameof(LastContactedDateTime)))
        body.LastContactedDateTime = LastContactedDateTime;

    if (this.IsParameterBound(nameof(ManagedDeviceId)))
        body.ManagedDeviceId = ManagedDeviceId;

    if (this.IsParameterBound(nameof(Manufacturer)))
        body.Manufacturer = Manufacturer;

    if (this.IsParameterBound(nameof(Model)))
        body.Model = Model;

    if (this.IsParameterBound(nameof(ProductKey)))
        body.ProductKey = ProductKey;

    if (this.IsParameterBound(nameof(PurchaseOrderIdentifier)))
        body.PurchaseOrderIdentifier = PurchaseOrderIdentifier;

    if (this.IsParameterBound(nameof(ResourceName)))
        body.ResourceName = ResourceName;

    if (this.IsParameterBound(nameof(SerialNumber)))
        body.SerialNumber = SerialNumber;

    if (this.IsParameterBound(nameof(SkuNumber)))
        body.SkuNumber = SkuNumber;

    if (this.IsParameterBound(nameof(SystemFamily)))
        body.SystemFamily = SystemFamily;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(EnrollmentState)))
        body.EnrollmentState = EnrollmentState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotDeviceIdentity? result;
            try
            {
                result = client.DeviceManagement.WindowsAutopilotDeviceIdentities.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
