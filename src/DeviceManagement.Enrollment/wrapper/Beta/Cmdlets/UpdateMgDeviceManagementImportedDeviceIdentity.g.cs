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
    [GraphRoute("PATCH", "/deviceManagement/importedDeviceIdentities/{importedDeviceIdentity-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementImportedDeviceIdentity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedDeviceIdentity))]
    public class UpdateMgDeviceManagementImportedDeviceIdentityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ImportedDeviceIdentityId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? ImportedDeviceIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastContactedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.EnrollmentState? EnrollmentState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedDeviceIdentityType? ImportedDeviceIdentityType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.Platform? Platform { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ImportedDeviceIdentityId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedDeviceIdentity();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(ImportedDeviceIdentifier)))
        body.ImportedDeviceIdentifier = ImportedDeviceIdentifier;

    if (this.IsParameterBound(nameof(LastContactedDateTime)))
        body.LastContactedDateTime = LastContactedDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(EnrollmentState)))
        body.EnrollmentState = EnrollmentState;

    if (this.IsParameterBound(nameof(ImportedDeviceIdentityType)))
        body.ImportedDeviceIdentityType = ImportedDeviceIdentityType;

    if (this.IsParameterBound(nameof(Platform)))
        body.Platform = Platform;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedDeviceIdentity? result;
            try
            {
                result = client.DeviceManagement.ImportedDeviceIdentities[ImportedDeviceIdentityId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ImportedDeviceIdentityId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ImportedDeviceIdentities[ImportedDeviceIdentityId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ImportedDeviceIdentityId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
