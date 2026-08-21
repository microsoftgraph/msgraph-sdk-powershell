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
    [GraphRoute("POST", "/security/threatIntelligence/passiveDnsRecords")]
    [Cmdlet(VerbsCommon.New, "MgSecurityThreatIntelligencePassiveDnsRecord", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.PassiveDnsRecord))]
    public class NewMgSecurityThreatIntelligencePassiveDnsRecordCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CollectedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FirstSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecordType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.Artifact? Artifact { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.Host? ParentHost { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.PassiveDnsRecord();

    if (this.IsParameterBound(nameof(CollectedDateTime)))
        body.CollectedDateTime = CollectedDateTime;

    if (this.IsParameterBound(nameof(FirstSeenDateTime)))
        body.FirstSeenDateTime = FirstSeenDateTime;

    if (this.IsParameterBound(nameof(LastSeenDateTime)))
        body.LastSeenDateTime = LastSeenDateTime;

    if (this.IsParameterBound(nameof(RecordType)))
        body.RecordType = RecordType;

    if (this.IsParameterBound(nameof(Artifact)))
        body.Artifact = Artifact;

    if (this.IsParameterBound(nameof(ParentHost)))
        body.ParentHost = ParentHost;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.PassiveDnsRecord? result;
            try
            {
                result = client.Security.ThreatIntelligence.PassiveDnsRecords.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
