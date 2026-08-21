#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/domains/{domain-id}/serviceConfigurationRecords/{domainDnsRecord-id}")]
    [Cmdlet(VerbsData.Update, "MgDomainServiceConfigurationRecord", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DomainDnsRecord))]
    public class UpdateMgDomainServiceConfigurationRecordCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DomainId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DomainDnsRecordId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsOptional { get; set; }

        [Parameter(Mandatory = false)]
        public string? Label { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecordType { get; set; }

        [Parameter(Mandatory = false)]
        public string? SupportedService { get; set; }

        [Parameter(Mandatory = false)]
        public int? Ttl { get; set; }





        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DomainDnsRecordId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DomainDnsRecord();

    if (this.IsParameterBound(nameof(IsOptional)))
        body.IsOptional = IsOptional;

    if (this.IsParameterBound(nameof(Label)))
        body.Label = Label;

    if (this.IsParameterBound(nameof(RecordType)))
        body.RecordType = RecordType;

    if (this.IsParameterBound(nameof(SupportedService)))
        body.SupportedService = SupportedService;

    if (this.IsParameterBound(nameof(Ttl)))
        body.Ttl = Ttl;



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

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DomainDnsRecord? result;
            try
            {
                result = client.Domains[DomainId].ServiceConfigurationRecords[DomainDnsRecordId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, DomainDnsRecordId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Domains[DomainId].ServiceConfigurationRecords[DomainDnsRecordId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, DomainDnsRecordId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
