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
    [GraphRoute("PATCH", "/security/threatIntelligence/whoisHistoryRecords/{whoisHistoryRecord-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityThreatIntelligenceWhoisHistoryRecord", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisHistoryRecord))]
    public class UpdateMgSecurityThreatIntelligenceWhoisHistoryRecordCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WhoisHistoryRecordId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DomainStatus { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FirstSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RawWhoisText { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RegistrationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? WhoisServer { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisContact? Abuse { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisContact? Admin { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisContact? Billing { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisNameserver[]? Nameservers { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisContact? Noc { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisContact? Registrant { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisContact? Registrar { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisContact? Technical { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisContact? Zone { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.Host? Host { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WhoisHistoryRecordId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisHistoryRecord();

    if (this.IsParameterBound(nameof(DomainStatus)))
        body.DomainStatus = DomainStatus;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(FirstSeenDateTime)))
        body.FirstSeenDateTime = FirstSeenDateTime;

    if (this.IsParameterBound(nameof(LastSeenDateTime)))
        body.LastSeenDateTime = LastSeenDateTime;

    if (this.IsParameterBound(nameof(LastUpdateDateTime)))
        body.LastUpdateDateTime = LastUpdateDateTime;

    if (this.IsParameterBound(nameof(RawWhoisText)))
        body.RawWhoisText = RawWhoisText;

    if (this.IsParameterBound(nameof(RegistrationDateTime)))
        body.RegistrationDateTime = RegistrationDateTime;

    if (this.IsParameterBound(nameof(WhoisServer)))
        body.WhoisServer = WhoisServer;

    if (this.IsParameterBound(nameof(Abuse)))
        body.Abuse = Abuse;

    if (this.IsParameterBound(nameof(Admin)))
        body.Admin = Admin;

    if (this.IsParameterBound(nameof(Billing)))
        body.Billing = Billing;

    if (this.IsParameterBound(nameof(Nameservers)))
        body.Nameservers = Nameservers!.ToList();

    if (this.IsParameterBound(nameof(Noc)))
        body.Noc = Noc;

    if (this.IsParameterBound(nameof(Registrant)))
        body.Registrant = Registrant;

    if (this.IsParameterBound(nameof(Registrar)))
        body.Registrar = Registrar;

    if (this.IsParameterBound(nameof(Technical)))
        body.Technical = Technical;

    if (this.IsParameterBound(nameof(Zone)))
        body.Zone = Zone;

    if (this.IsParameterBound(nameof(Host)))
        body.Host = Host;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisHistoryRecord? result;
            try
            {
                result = client.Security.ThreatIntelligence.WhoisHistoryRecords[WhoisHistoryRecordId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, WhoisHistoryRecordId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.ThreatIntelligence.WhoisHistoryRecords[WhoisHistoryRecordId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, WhoisHistoryRecordId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
