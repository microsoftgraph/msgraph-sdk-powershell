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
    [GraphRoute("POST", "/deviceManagement/importedWindowsAutopilotDeviceIdentities")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementImportedWindowsAutopilotDeviceIdentity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedWindowsAutopilotDeviceIdentity))]
    public class NewMgDeviceManagementImportedWindowsAutopilotDeviceIdentityCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AssignedUserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? GroupTag { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? HardwareIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? ImportId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ProductKey { get; set; }

        [Parameter(Mandatory = false)]
        public string? SerialNumber { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedWindowsAutopilotDeviceIdentityState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedWindowsAutopilotDeviceIdentity();

    if (this.IsParameterBound(nameof(AssignedUserPrincipalName)))
        body.AssignedUserPrincipalName = AssignedUserPrincipalName;

    if (this.IsParameterBound(nameof(GroupTag)))
        body.GroupTag = GroupTag;

    if (this.IsParameterBound(nameof(HardwareIdentifier)))
        body.HardwareIdentifier = HardwareIdentifier;

    if (this.IsParameterBound(nameof(ImportId)))
        body.ImportId = ImportId;

    if (this.IsParameterBound(nameof(ProductKey)))
        body.ProductKey = ProductKey;

    if (this.IsParameterBound(nameof(SerialNumber)))
        body.SerialNumber = SerialNumber;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedWindowsAutopilotDeviceIdentity? result;
            try
            {
                result = client.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
