#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/threatIntelligence/hosts/{host-id}/reputation")]
    [Cmdlet(VerbsData.Update, "MgSecurityThreatIntelligenceHostReputation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostReputation))]
    public class UpdateMgSecurityThreatIntelligenceHostReputationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string HostId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? Score { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostReputationClassification? Classification { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostReputationRule[]? Rules { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(HostId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostReputation();

    if (this.IsParameterBound(nameof(Score)))
        body.Score = Score;

    if (this.IsParameterBound(nameof(Classification)))
        body.Classification = Classification;

    if (this.IsParameterBound(nameof(Rules)))
        body.Rules = Rules!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostReputation? result;
            try
            {
                result = client.Security.ThreatIntelligence.Hosts[HostId].Reputation.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, HostId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.ThreatIntelligence.Hosts[HostId].Reputation.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, HostId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
