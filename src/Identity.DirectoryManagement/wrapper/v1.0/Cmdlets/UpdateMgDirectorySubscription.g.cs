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
    [GraphRoute("PATCH", "/directory/subscriptions/{companySubscription-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectorySubscription", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CompanySubscription))]
    public class UpdateMgDirectorySubscriptionCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanySubscriptionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CommerceSubscriptionId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsTrial { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? NextLifecycleDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OwnerId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OwnerTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OwnerType { get; set; }

        [Parameter(Mandatory = false)]
        public string? SkuId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SkuPartNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalLicenses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ServicePlanInfo[]? ServiceStatus { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CompanySubscriptionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CompanySubscription();

    if (this.IsParameterBound(nameof(CommerceSubscriptionId)))
        body.CommerceSubscriptionId = CommerceSubscriptionId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(IsTrial)))
        body.IsTrial = IsTrial;

    if (this.IsParameterBound(nameof(NextLifecycleDateTime)))
        body.NextLifecycleDateTime = NextLifecycleDateTime;

    if (this.IsParameterBound(nameof(OwnerId)))
        body.OwnerId = OwnerId;

    if (this.IsParameterBound(nameof(OwnerTenantId)))
        body.OwnerTenantId = OwnerTenantId;

    if (this.IsParameterBound(nameof(OwnerType)))
        body.OwnerType = OwnerType;

    if (this.IsParameterBound(nameof(SkuId)))
        body.SkuId = SkuId;

    if (this.IsParameterBound(nameof(SkuPartNumber)))
        body.SkuPartNumber = SkuPartNumber;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(TotalLicenses)))
        body.TotalLicenses = TotalLicenses;

    if (this.IsParameterBound(nameof(ServiceStatus)))
        body.ServiceStatus = ServiceStatus!.ToList();


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

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CompanySubscription? result;
            try
            {
                result = client.Directory.Subscriptions[CompanySubscriptionId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, CompanySubscriptionId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.Subscriptions[CompanySubscriptionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, CompanySubscriptionId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
