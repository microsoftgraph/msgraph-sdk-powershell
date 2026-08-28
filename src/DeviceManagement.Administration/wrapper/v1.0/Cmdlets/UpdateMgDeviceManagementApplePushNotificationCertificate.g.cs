#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("PATCH", "/deviceManagement/applePushNotificationCertificate")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementApplePushNotificationCertificate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.ApplePushNotificationCertificate))]
    public class UpdateMgDeviceManagementApplePushNotificationCertificateCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AppleIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? Certificate { get; set; }

        [Parameter(Mandatory = false)]
        public string? CertificateUploadFailureReason { get; set; }

        [Parameter(Mandatory = false)]
        public string? CertificateUploadStatus { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TopicIdentifier { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.ApplePushNotificationCertificate();

    if (this.IsParameterBound(nameof(AppleIdentifier)))
        body.AppleIdentifier = AppleIdentifier;

    if (this.IsParameterBound(nameof(Certificate)))
        body.Certificate = Certificate;

    if (this.IsParameterBound(nameof(CertificateUploadFailureReason)))
        body.CertificateUploadFailureReason = CertificateUploadFailureReason;

    if (this.IsParameterBound(nameof(CertificateUploadStatus)))
        body.CertificateUploadStatus = CertificateUploadStatus;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(TopicIdentifier)))
        body.TopicIdentifier = TopicIdentifier;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.ApplePushNotificationCertificate? result;
            try
            {
                result = client.DeviceManagement.ApplePushNotificationCertificate.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ApplePushNotificationCertificate.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
