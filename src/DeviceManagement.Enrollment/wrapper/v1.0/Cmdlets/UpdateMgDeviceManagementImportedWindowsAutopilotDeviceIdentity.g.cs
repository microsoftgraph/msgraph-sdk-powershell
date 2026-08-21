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
    [GraphRoute("PATCH", "/deviceManagement/importedWindowsAutopilotDeviceIdentities/{importedWindowsAutopilotDeviceIdentity-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementImportedWindowsAutopilotDeviceIdentity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedWindowsAutopilotDeviceIdentity))]
    public class UpdateMgDeviceManagementImportedWindowsAutopilotDeviceIdentityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ImportedWindowsAutopilotDeviceIdentityId { get; set; } = string.Empty;

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
            if (!ShouldProcess(ImportedWindowsAutopilotDeviceIdentityId, "Update"))
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
                result = client.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities[ImportedWindowsAutopilotDeviceIdentityId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ImportedWindowsAutopilotDeviceIdentityId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities[ImportedWindowsAutopilotDeviceIdentityId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, ImportedWindowsAutopilotDeviceIdentityId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
