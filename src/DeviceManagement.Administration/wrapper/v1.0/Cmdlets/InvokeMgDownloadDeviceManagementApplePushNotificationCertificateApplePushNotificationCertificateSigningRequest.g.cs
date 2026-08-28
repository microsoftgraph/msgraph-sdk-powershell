#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("GET", "/deviceManagement/applePushNotificationCertificate/downloadApplePushNotificationCertificateSigningRequest()")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDownloadDeviceManagementApplePushNotificationCertificateApplePushNotificationCertificateSigningRequest")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.DeviceManagement.ApplePushNotificationCertificate.DownloadApplePushNotificationCertificateSigningRequest.DownloadApplePushNotificationCertificateSigningRequestGetResponse))]
    public class InvokeMgDownloadDeviceManagementApplePushNotificationCertificateApplePushNotificationCertificateSigningRequestCommand : GraphClientCmdlet
    {










        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.DeviceManagement.ApplePushNotificationCertificate.DownloadApplePushNotificationCertificateSigningRequest.DownloadApplePushNotificationCertificateSigningRequestGetResponse? result;
            try
            {
                result = client.DeviceManagement.ApplePushNotificationCertificate.DownloadApplePushNotificationCertificateSigningRequest.GetAsDownloadApplePushNotificationCertificateSigningRequestGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
