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
    [GraphRoute("PATCH", "/deviceManagement/dataSharingConsents/{dataSharingConsent-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDataSharingConsent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DataSharingConsent))]
    public class UpdateMgDeviceManagementDataSharingConsentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DataSharingConsentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? GrantDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Granted { get; set; }

        [Parameter(Mandatory = false)]
        public string? GrantedByUpn { get; set; }

        [Parameter(Mandatory = false)]
        public string? GrantedByUserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServiceDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? TermsUrl { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DataSharingConsentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DataSharingConsent();

    if (this.IsParameterBound(nameof(GrantDateTime)))
        body.GrantDateTime = GrantDateTime;

    if (this.IsParameterBound(nameof(Granted)))
        body.Granted = Granted;

    if (this.IsParameterBound(nameof(GrantedByUpn)))
        body.GrantedByUpn = GrantedByUpn;

    if (this.IsParameterBound(nameof(GrantedByUserId)))
        body.GrantedByUserId = GrantedByUserId;

    if (this.IsParameterBound(nameof(ServiceDisplayName)))
        body.ServiceDisplayName = ServiceDisplayName;

    if (this.IsParameterBound(nameof(TermsUrl)))
        body.TermsUrl = TermsUrl;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DataSharingConsent? result;
            try
            {
                result = client.DeviceManagement.DataSharingConsents[DataSharingConsentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DataSharingConsentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DataSharingConsents[DataSharingConsentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DataSharingConsentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
