#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/deviceAppManagement/managedAppRegistrations/{managedAppRegistration-id}/managedAppLogCollectionRequests/{managedAppLogCollectionRequest-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementManagedAppRegistrationManagedAppLogCollectionRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppLogCollectionRequest))]
    public class UpdateMgDeviceAppManagementManagedAppRegistrationManagedAppLogCollectionRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedAppRegistrationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedAppLogCollectionRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagedAppRegistrationId1 { get; set; }

        [Parameter(Mandatory = false)]
        public string? RequestedByUserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RequestedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppLogUpload[]? UploadedLogs { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppLogUploadConsent? UserLogUploadConsent { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedAppLogCollectionRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppLogCollectionRequest();

    if (this.IsParameterBound(nameof(CompletedDateTime)))
        body.CompletedDateTime = CompletedDateTime;

    if (this.IsParameterBound(nameof(ManagedAppRegistrationId1)))
        body.ManagedAppRegistrationId = ManagedAppRegistrationId1;

    if (this.IsParameterBound(nameof(RequestedByUserPrincipalName)))
        body.RequestedByUserPrincipalName = RequestedByUserPrincipalName;

    if (this.IsParameterBound(nameof(RequestedDateTime)))
        body.RequestedDateTime = RequestedDateTime;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(UploadedLogs)))
        body.UploadedLogs = UploadedLogs!.ToList();

    if (this.IsParameterBound(nameof(UserLogUploadConsent)))
        body.UserLogUploadConsent = UserLogUploadConsent;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppLogCollectionRequest? result;
            try
            {
                result = client.DeviceAppManagement.ManagedAppRegistrations[ManagedAppRegistrationId].ManagedAppLogCollectionRequests[ManagedAppLogCollectionRequestId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ManagedAppLogCollectionRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.ManagedAppRegistrations[ManagedAppRegistrationId].ManagedAppLogCollectionRequests[ManagedAppLogCollectionRequestId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ManagedAppLogCollectionRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
