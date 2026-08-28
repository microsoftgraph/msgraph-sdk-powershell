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
    [GraphRoute("POST", "/security/threatIntelligence/intelligenceProfileIndicators")]
    [Cmdlet(VerbsCommon.New, "MgSecurityThreatIntelligenceProfileIndicator", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.IntelligenceProfileIndicator))]
    public class NewMgSecurityThreatIntelligenceProfileIndicatorCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FirstSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.IndicatorSource? Source { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.Artifact? Artifact { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.IntelligenceProfileIndicator();

    if (this.IsParameterBound(nameof(FirstSeenDateTime)))
        body.FirstSeenDateTime = FirstSeenDateTime;

    if (this.IsParameterBound(nameof(LastSeenDateTime)))
        body.LastSeenDateTime = LastSeenDateTime;

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(Artifact)))
        body.Artifact = Artifact;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.IntelligenceProfileIndicator? result;
            try
            {
                result = client.Security.ThreatIntelligence.IntelligenceProfileIndicators.PostAsync(body, requestConfiguration =>
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
