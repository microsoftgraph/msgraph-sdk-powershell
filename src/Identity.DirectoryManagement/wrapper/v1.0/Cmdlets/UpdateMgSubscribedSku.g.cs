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
    [GraphRoute("PATCH", "/subscribedSkus/{subscribedSku-id}")]
    [Cmdlet(VerbsData.Update, "MgSubscribedSku", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SubscribedSku))]
    public class UpdateMgSubscribedSkuCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SubscribedSkuId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AccountId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AccountName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppliesTo { get; set; }

        [Parameter(Mandatory = false)]
        public string? CapabilityStatus { get; set; }

        [Parameter(Mandatory = false)]
        public int? ConsumedUnits { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? SkuId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SkuPartNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SubscriptionIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.LicenseUnitsDetail? PrepaidUnits { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ServicePlanInfo[]? ServicePlans { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SubscribedSkuId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SubscribedSku();

    if (this.IsParameterBound(nameof(AccountId)))
        body.AccountId = AccountId;

    if (this.IsParameterBound(nameof(AccountName)))
        body.AccountName = AccountName;

    if (this.IsParameterBound(nameof(AppliesTo)))
        body.AppliesTo = AppliesTo;

    if (this.IsParameterBound(nameof(CapabilityStatus)))
        body.CapabilityStatus = CapabilityStatus;

    if (this.IsParameterBound(nameof(ConsumedUnits)))
        body.ConsumedUnits = ConsumedUnits;

    if (this.IsParameterBound(nameof(SkuId)))
        body.SkuId = SkuId;

    if (this.IsParameterBound(nameof(SkuPartNumber)))
        body.SkuPartNumber = SkuPartNumber;

    if (this.IsParameterBound(nameof(SubscriptionIds)))
        body.SubscriptionIds = SubscriptionIds!.ToList();

    if (this.IsParameterBound(nameof(PrepaidUnits)))
        body.PrepaidUnits = PrepaidUnits;

    if (this.IsParameterBound(nameof(ServicePlans)))
        body.ServicePlans = ServicePlans!.ToList();


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

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SubscribedSku? result;
            try
            {
                result = client.SubscribedSkus[SubscribedSkuId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, SubscribedSkuId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.SubscribedSkus[SubscribedSkuId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, SubscribedSkuId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
