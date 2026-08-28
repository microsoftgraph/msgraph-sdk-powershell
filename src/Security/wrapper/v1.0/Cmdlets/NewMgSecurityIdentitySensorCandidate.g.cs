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
    [GraphRoute("POST", "/security/identities/sensorCandidates")]
    [Cmdlet(VerbsCommon.New, "MgSecurityIdentitySensorCandidate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.SensorCandidate))]
    public class NewMgSecurityIdentitySensorCandidateCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? ComputerDnsName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DomainName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? SenseClientVersion { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.SensorCandidate();

    if (this.IsParameterBound(nameof(ComputerDnsName)))
        body.ComputerDnsName = ComputerDnsName;

    if (this.IsParameterBound(nameof(DomainName)))
        body.DomainName = DomainName;

    if (this.IsParameterBound(nameof(LastSeenDateTime)))
        body.LastSeenDateTime = LastSeenDateTime;

    if (this.IsParameterBound(nameof(SenseClientVersion)))
        body.SenseClientVersion = SenseClientVersion;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.SensorCandidate? result;
            try
            {
                result = client.Security.Identities.SensorCandidates.PostAsync(body, requestConfiguration =>
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
