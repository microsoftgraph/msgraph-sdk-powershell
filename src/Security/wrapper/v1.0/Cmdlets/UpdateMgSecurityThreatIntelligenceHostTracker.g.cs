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
    [GraphRoute("PATCH", "/security/threatIntelligence/hostTrackers/{hostTracker-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityThreatIntelligenceHostTracker", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostTracker))]
    public class UpdateMgSecurityThreatIntelligenceHostTrackerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string HostTrackerId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FirstSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Kind { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Value { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.Host? Host { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(HostTrackerId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostTracker();

    if (this.IsParameterBound(nameof(FirstSeenDateTime)))
        body.FirstSeenDateTime = FirstSeenDateTime;

    if (this.IsParameterBound(nameof(Kind)))
        body.Kind = Kind;

    if (this.IsParameterBound(nameof(LastSeenDateTime)))
        body.LastSeenDateTime = LastSeenDateTime;

    if (this.IsParameterBound(nameof(Value)))
        body.Value = Value;

    if (this.IsParameterBound(nameof(Host)))
        body.Host = Host;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostTracker? result;
            try
            {
                result = client.Security.ThreatIntelligence.HostTrackers[HostTrackerId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, HostTrackerId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.ThreatIntelligence.HostTrackers[HostTrackerId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, HostTrackerId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
