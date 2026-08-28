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
    [GraphRoute("PATCH", "/deviceManagement/remoteAssistancePartners/{remoteAssistancePartner-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementRemoteAssistancePartner", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.RemoteAssistancePartner))]
    public class UpdateMgDeviceManagementRemoteAssistancePartnerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RemoteAssistancePartnerId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastConnectionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnboardingUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.RemoteAssistanceOnboardingStatus? OnboardingStatus { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RemoteAssistancePartnerId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.RemoteAssistancePartner();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastConnectionDateTime)))
        body.LastConnectionDateTime = LastConnectionDateTime;

    if (this.IsParameterBound(nameof(OnboardingUrl)))
        body.OnboardingUrl = OnboardingUrl;

    if (this.IsParameterBound(nameof(OnboardingStatus)))
        body.OnboardingStatus = OnboardingStatus;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.RemoteAssistancePartner? result;
            try
            {
                result = client.DeviceManagement.RemoteAssistancePartners[RemoteAssistancePartnerId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, RemoteAssistancePartnerId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.RemoteAssistancePartners[RemoteAssistancePartnerId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, RemoteAssistancePartnerId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
