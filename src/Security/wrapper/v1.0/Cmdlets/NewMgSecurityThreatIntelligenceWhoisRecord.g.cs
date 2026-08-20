#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/threatIntelligence/whoisRecords")]
    [Cmdlet(VerbsCommon.New, "MgSecurityThreatIntelligenceWhoisRecord", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisRecord))]
    public class NewMgSecurityThreatIntelligenceWhoisRecordCommand : PSCmdlet
    {


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




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisRecord();

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


        // ── Choose HttpClient + auth provider ─────────────────────────────
        HttpClient httpClient;
        IAuthenticationProvider authProvider;

        if (this.IsParameterBound(nameof(AccessToken)))
        {
            httpClient = new HttpClient();
            authProvider = new StaticBearerTokenAuthenticationProvider(AccessToken!);
        }
        else
        {
            WriteVerbose("No -AccessToken supplied, using the active Connect-MgGraph session.");
            try
            {
                httpClient = HttpHelpers.GetGraphHttpClient();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(
                    new InvalidOperationException(
                        "No active Graph session. Run Connect-MgGraph first, or supply -AccessToken.", ex),
                    "NoGraphSession",
                    ErrorCategory.AuthenticationError,
                    null));
                return;
            }
            authProvider = new AnonymousAuthenticationProvider();
        }

        var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.WhoisRecord? result;
            try
            {
                result = client.Security.ThreatIntelligence.WhoisRecords.PostAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(Headers)))
                        {
                            foreach (System.Collections.DictionaryEntry entry in Headers!)
                                requestConfiguration.Headers.Add(entry.Key.ToString()!, entry.Value?.ToString() ?? string.Empty);
                        }
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, body));
                return;
            }

            WriteObject(result);
        }
    }
}
