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
    [GraphRoute("PATCH", "/deviceAppManagement")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagement", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceAppManagement))]
    public class UpdateMgDeviceAppManagementCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? IsEnabledForMicrosoftStoreForBusiness { get; set; }

        [Parameter(Mandatory = false)]
        public string? MicrosoftStoreForBusinessLanguage { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceAppManagement();

    if (this.IsParameterBound(nameof(IsEnabledForMicrosoftStoreForBusiness)))
        body.IsEnabledForMicrosoftStoreForBusiness = IsEnabledForMicrosoftStoreForBusiness;

    if (this.IsParameterBound(nameof(MicrosoftStoreForBusinessLanguage)))
        body.MicrosoftStoreForBusinessLanguage = MicrosoftStoreForBusinessLanguage;

    if (this.IsParameterBound(nameof(MicrosoftStoreForBusinessLastCompletedApplicationSyncTime)))
        body.MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = MicrosoftStoreForBusinessLastCompletedApplicationSyncTime;

    if (this.IsParameterBound(nameof(MicrosoftStoreForBusinessLastSuccessfulSyncDateTime)))
        body.MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = MicrosoftStoreForBusinessLastSuccessfulSyncDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceAppManagement? result;
            try
            {
                result = client.DeviceAppManagement.PatchAsync(body, requestConfiguration =>
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
                    result = client.DeviceAppManagement.GetAsync().GetAwaiter().GetResult();
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
