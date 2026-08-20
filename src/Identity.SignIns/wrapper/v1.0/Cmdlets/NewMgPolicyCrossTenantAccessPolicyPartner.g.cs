#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/policies/crossTenantAccessPolicy/partners")]
    [Cmdlet(VerbsCommon.New, "MgPolicyCrossTenantAccessPolicyPartner", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyConfigurationPartner))]
    public class NewMgPolicyCrossTenantAccessPolicyPartnerCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? IsInMultiTenantOrganization { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsServiceProvider { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyAppServiceConnectSetting? AppServiceConnectInbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.InboundOutboundPolicyConfiguration? AutomaticUserConsentSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyB2BSetting? B2bCollaborationInbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyB2BSetting? B2bCollaborationOutbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyB2BSetting? B2bDirectConnectInbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyB2BSetting? B2bDirectConnectOutbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyInboundTrust? InboundTrust { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyM365CollaborationInboundSetting? M365CollaborationInbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyM365CollaborationOutboundSetting? M365CollaborationOutbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyTenantRestrictions? TenantRestrictions { get; set; }




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

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyConfigurationPartner();

    if (this.IsParameterBound(nameof(IsInMultiTenantOrganization)))
        body.IsInMultiTenantOrganization = IsInMultiTenantOrganization;

    if (this.IsParameterBound(nameof(IsServiceProvider)))
        body.IsServiceProvider = IsServiceProvider;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(AppServiceConnectInbound)))
        body.AppServiceConnectInbound = AppServiceConnectInbound;

    if (this.IsParameterBound(nameof(AutomaticUserConsentSettings)))
        body.AutomaticUserConsentSettings = AutomaticUserConsentSettings;

    if (this.IsParameterBound(nameof(B2bCollaborationInbound)))
        body.B2bCollaborationInbound = B2bCollaborationInbound;

    if (this.IsParameterBound(nameof(B2bCollaborationOutbound)))
        body.B2bCollaborationOutbound = B2bCollaborationOutbound;

    if (this.IsParameterBound(nameof(B2bDirectConnectInbound)))
        body.B2bDirectConnectInbound = B2bDirectConnectInbound;

    if (this.IsParameterBound(nameof(B2bDirectConnectOutbound)))
        body.B2bDirectConnectOutbound = B2bDirectConnectOutbound;

    if (this.IsParameterBound(nameof(InboundTrust)))
        body.InboundTrust = InboundTrust;

    if (this.IsParameterBound(nameof(M365CollaborationInbound)))
        body.M365CollaborationInbound = M365CollaborationInbound;

    if (this.IsParameterBound(nameof(M365CollaborationOutbound)))
        body.M365CollaborationOutbound = M365CollaborationOutbound;

    if (this.IsParameterBound(nameof(TenantRestrictions)))
        body.TenantRestrictions = TenantRestrictions;


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

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyConfigurationPartner? result;
            try
            {
                result = client.Policies.CrossTenantAccessPolicy.Partners.PostAsync(body, requestConfiguration =>
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
