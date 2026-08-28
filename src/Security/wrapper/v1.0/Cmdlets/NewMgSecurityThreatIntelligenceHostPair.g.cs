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
    [GraphRoute("POST", "/security/threatIntelligence/hostPairs")]
    [Cmdlet(VerbsCommon.New, "MgSecurityThreatIntelligenceHostPair", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostPair))]
    public class NewMgSecurityThreatIntelligenceHostPairCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FirstSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? LinkKind { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.Host? ChildHost { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.Host? ParentHost { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostPair();

    if (this.IsParameterBound(nameof(FirstSeenDateTime)))
        body.FirstSeenDateTime = FirstSeenDateTime;

    if (this.IsParameterBound(nameof(LastSeenDateTime)))
        body.LastSeenDateTime = LastSeenDateTime;

    if (this.IsParameterBound(nameof(LinkKind)))
        body.LinkKind = LinkKind;

    if (this.IsParameterBound(nameof(ChildHost)))
        body.ChildHost = ChildHost;

    if (this.IsParameterBound(nameof(ParentHost)))
        body.ParentHost = ParentHost;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostPair? result;
            try
            {
                result = client.Security.ThreatIntelligence.HostPairs.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
