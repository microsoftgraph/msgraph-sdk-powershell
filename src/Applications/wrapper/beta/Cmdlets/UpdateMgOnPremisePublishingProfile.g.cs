#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("PATCH", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}")]
    [Cmdlet(VerbsData.Update, "MgOnPremisePublishingProfile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.OnPremisesPublishingProfile))]
    public class UpdateMgOnPremisePublishingProfileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnPremisesPublishingProfileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsDefaultAccessEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.HybridAgentUpdaterConfiguration? HybridAgentUpdaterConfiguration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnPremisesPublishingProfileId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.OnPremisesPublishingProfile();

    if (this.IsParameterBound(nameof(IsDefaultAccessEnabled)))
        body.IsDefaultAccessEnabled = IsDefaultAccessEnabled;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(HybridAgentUpdaterConfiguration)))
        body.HybridAgentUpdaterConfiguration = HybridAgentUpdaterConfiguration;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.OnPremisesPublishingProfile? result;
            try
            {
                result = client.OnPremisesPublishingProfiles[OnPremisesPublishingProfileId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OnPremisesPublishingProfileId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.OnPremisesPublishingProfiles[OnPremisesPublishingProfileId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, OnPremisesPublishingProfileId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
