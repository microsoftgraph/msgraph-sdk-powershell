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
    [GraphRoute("POST", "/security/auditLog/queries")]
    [Cmdlet(VerbsCommon.New, "MgSecurityAuditLogQuery", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.AuditLogQuery))]
    public class NewMgSecurityAuditLogQueryCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? AdministrativeUnitIdFilters { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FilterEndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FilterStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? IpAddressFilters { get; set; }

        [Parameter(Mandatory = false)]
        public string? KeywordFilter { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ObjectIdFilters { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? OperationFilters { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ServiceFilters { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? UserPrincipalNameFilters { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AuditLogRecordType?[]? RecordTypeFilters { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AuditLogQueryStatus? Status { get; set; }




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

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.AuditLogQuery();

    if (this.IsParameterBound(nameof(AdministrativeUnitIdFilters)))
        body.AdministrativeUnitIdFilters = AdministrativeUnitIdFilters!.ToList();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(FilterEndDateTime)))
        body.FilterEndDateTime = FilterEndDateTime;

    if (this.IsParameterBound(nameof(FilterStartDateTime)))
        body.FilterStartDateTime = FilterStartDateTime;

    if (this.IsParameterBound(nameof(IpAddressFilters)))
        body.IpAddressFilters = IpAddressFilters!.ToList();

    if (this.IsParameterBound(nameof(KeywordFilter)))
        body.KeywordFilter = KeywordFilter;

    if (this.IsParameterBound(nameof(ObjectIdFilters)))
        body.ObjectIdFilters = ObjectIdFilters!.ToList();

    if (this.IsParameterBound(nameof(OperationFilters)))
        body.OperationFilters = OperationFilters!.ToList();

    if (this.IsParameterBound(nameof(ServiceFilters)))
        body.ServiceFilters = ServiceFilters!.ToList();

    if (this.IsParameterBound(nameof(UserPrincipalNameFilters)))
        body.UserPrincipalNameFilters = UserPrincipalNameFilters!.ToList();

    if (this.IsParameterBound(nameof(RecordTypeFilters)))
        body.RecordTypeFilters = RecordTypeFilters!.ToList();

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


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

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.AuditLogQuery? result;
            try
            {
                result = client.Security.AuditLog.Queries.PostAsync(body, requestConfiguration =>
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
