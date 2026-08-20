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
    [GraphRoute("POST", "/domains")]
    [Cmdlet(VerbsCommon.New, "MgDomain", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Domain))]
    public class NewMgDomainCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AuthenticationType { get; set; }

        [Parameter(Mandatory = false)]
        public string? AvailabilityStatus { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAdminManaged { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDefault { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsInitial { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRoot { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsVerified { get; set; }

        [Parameter(Mandatory = false)]
        public string? Manufacturer { get; set; }

        [Parameter(Mandatory = false)]
        public string? Model { get; set; }

        [Parameter(Mandatory = false)]
        public int? PasswordNotificationWindowInDays { get; set; }

        [Parameter(Mandatory = false)]
        public int? PasswordValidityPeriodInDays { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SupportedServices { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DomainState? State { get; set; }




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

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Domain();

    if (this.IsParameterBound(nameof(AuthenticationType)))
        body.AuthenticationType = AuthenticationType;

    if (this.IsParameterBound(nameof(AvailabilityStatus)))
        body.AvailabilityStatus = AvailabilityStatus;

    if (this.IsParameterBound(nameof(IsAdminManaged)))
        body.IsAdminManaged = IsAdminManaged;

    if (this.IsParameterBound(nameof(IsDefault)))
        body.IsDefault = IsDefault;

    if (this.IsParameterBound(nameof(IsInitial)))
        body.IsInitial = IsInitial;

    if (this.IsParameterBound(nameof(IsRoot)))
        body.IsRoot = IsRoot;

    if (this.IsParameterBound(nameof(IsVerified)))
        body.IsVerified = IsVerified;

    if (this.IsParameterBound(nameof(Manufacturer)))
        body.Manufacturer = Manufacturer;

    if (this.IsParameterBound(nameof(Model)))
        body.Model = Model;

    if (this.IsParameterBound(nameof(PasswordNotificationWindowInDays)))
        body.PasswordNotificationWindowInDays = PasswordNotificationWindowInDays;

    if (this.IsParameterBound(nameof(PasswordValidityPeriodInDays)))
        body.PasswordValidityPeriodInDays = PasswordValidityPeriodInDays;

    if (this.IsParameterBound(nameof(SupportedServices)))
        body.SupportedServices = SupportedServices!.ToList();

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


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

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Domain? result;
            try
            {
                result = client.Domains.PostAsync(body, requestConfiguration =>
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
