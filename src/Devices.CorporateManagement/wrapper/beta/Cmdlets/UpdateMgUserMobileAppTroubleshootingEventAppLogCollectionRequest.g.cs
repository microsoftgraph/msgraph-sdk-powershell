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
    [GraphRoute("PATCH", "/users/{user-id}/mobileAppTroubleshootingEvents/{mobileAppTroubleshootingEvent-id}/appLogCollectionRequests/{appLogCollectionRequest-id}")]
    [Cmdlet(VerbsData.Update, "MgUserMobileAppTroubleshootingEventAppLogCollectionRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AppLogCollectionRequest))]
    public class UpdateMgUserMobileAppTroubleshootingEventAppLogCollectionRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MobileAppTroubleshootingEventId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AppLogCollectionRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? CustomLogFolders { get; set; }

        [Parameter(Mandatory = false)]
        public string? ErrorMessage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AppLogUploadState? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AppLogCollectionRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AppLogCollectionRequest();

    if (this.IsParameterBound(nameof(CompletedDateTime)))
        body.CompletedDateTime = CompletedDateTime;

    if (this.IsParameterBound(nameof(CustomLogFolders)))
        body.CustomLogFolders = CustomLogFolders!.ToList();

    if (this.IsParameterBound(nameof(ErrorMessage)))
        body.ErrorMessage = ErrorMessage;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AppLogCollectionRequest? result;
            try
            {
                result = client.Users[UserId].MobileAppTroubleshootingEvents[MobileAppTroubleshootingEventId].AppLogCollectionRequests[AppLogCollectionRequestId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AppLogCollectionRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].MobileAppTroubleshootingEvents[MobileAppTroubleshootingEventId].AppLogCollectionRequests[AppLogCollectionRequestId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AppLogCollectionRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
