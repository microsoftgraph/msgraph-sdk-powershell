#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/mobileAppTroubleshootingEvents/{mobileAppTroubleshootingEvent-id}/appLogCollectionRequests")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementMobileAppTroubleshootingEventAppLogCollectionRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AppLogCollectionRequest))]
    public class NewMgDeviceManagementMobileAppTroubleshootingEventAppLogCollectionRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppTroubleshootingEventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? CustomLogFolders { get; set; }

        [Parameter(Mandatory = false)]
        public string? ErrorMessage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AppLogUploadState? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppTroubleshootingEventId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AppLogCollectionRequest();

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

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AppLogCollectionRequest? result;
            try
            {
                result = client.DeviceManagement.MobileAppTroubleshootingEvents[MobileAppTroubleshootingEventId].AppLogCollectionRequests.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
