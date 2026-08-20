#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/analytics/itemActivityStats")]
    [Cmdlet(VerbsCommon.New, "MgGroupSiteAnalyticItemActivityStat", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActivityStat))]
    public class NewMgGroupSiteAnalyticItemActivityStatCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsTrending { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActionStat? Access { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActionStat? Create { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActionStat? Delete { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActionStat? Edit { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.IncompleteData? IncompleteData { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActionStat? Move { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SiteId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActivityStat();

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(IsTrending)))
        body.IsTrending = IsTrending;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Access)))
        body.Access = Access;

    if (this.IsParameterBound(nameof(Create)))
        body.Create = Create;

    if (this.IsParameterBound(nameof(Delete)))
        body.Delete = Delete;

    if (this.IsParameterBound(nameof(Edit)))
        body.Edit = Edit;

    if (this.IsParameterBound(nameof(IncompleteData)))
        body.IncompleteData = IncompleteData;

    if (this.IsParameterBound(nameof(Move)))
        body.Move = Move;


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

            Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActivityStat? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].Analytics.ItemActivityStats.PostAsync(body, requestConfiguration =>
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
