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
    [GraphRoute("POST", "/security/threatIntelligence/hostPorts")]
    [Cmdlet(VerbsCommon.New, "MgSecurityThreatIntelligenceHostPort", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostPort))]
    public class NewMgSecurityThreatIntelligenceHostPortCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FirstSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastScanDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? Port { get; set; }

        [Parameter(Mandatory = false)]
        public int? TimesObserved { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostPortBanner[]? Banners { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostPortProtocol? Protocol { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostPortComponent[]? Services { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostPortStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.Host? Host { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostPort();

    if (this.IsParameterBound(nameof(FirstSeenDateTime)))
        body.FirstSeenDateTime = FirstSeenDateTime;

    if (this.IsParameterBound(nameof(LastScanDateTime)))
        body.LastScanDateTime = LastScanDateTime;

    if (this.IsParameterBound(nameof(LastSeenDateTime)))
        body.LastSeenDateTime = LastSeenDateTime;

    if (this.IsParameterBound(nameof(Port)))
        body.Port = Port;

    if (this.IsParameterBound(nameof(TimesObserved)))
        body.TimesObserved = TimesObserved;

    if (this.IsParameterBound(nameof(Banners)))
        body.Banners = Banners!.ToList();

    if (this.IsParameterBound(nameof(Protocol)))
        body.Protocol = Protocol;

    if (this.IsParameterBound(nameof(Services)))
        body.Services = Services!.ToList();

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Host)))
        body.Host = Host;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.HostPort? result;
            try
            {
                result = client.Security.ThreatIntelligence.HostPorts.PostAsync(body, requestConfiguration =>
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
