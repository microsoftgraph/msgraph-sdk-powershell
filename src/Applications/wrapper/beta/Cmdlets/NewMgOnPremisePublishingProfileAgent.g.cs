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
    [GraphRoute("POST", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agents")]
    [Cmdlet(VerbsCommon.New, "MgOnPremisePublishingProfileAgent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.OnPremisesAgent))]
    public class NewMgOnPremisePublishingProfileAgentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnPremisesPublishingProfileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ExternalIp { get; set; }

        [Parameter(Mandatory = false)]
        public string? MachineName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.AgentStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.OnPremisesPublishingType?[]? SupportedPublishingTypes { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnPremisesPublishingProfileId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.OnPremisesAgent();

    if (this.IsParameterBound(nameof(ExternalIp)))
        body.ExternalIp = ExternalIp;

    if (this.IsParameterBound(nameof(MachineName)))
        body.MachineName = MachineName;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(SupportedPublishingTypes)))
        body.SupportedPublishingTypes = SupportedPublishingTypes!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.OnPremisesAgent? result;
            try
            {
                result = client.OnPremisesPublishingProfiles[OnPremisesPublishingProfileId].Agents.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
