#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.BackupRestore.Client;
using Microsoft.Graph.PowerShell.BackupRestore.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.BackupRestore
{
    [GraphRoute("POST", "/solutions/backupRestore/oneDriveForBusinessRestoreSessions/{oneDriveForBusinessRestoreSession-id}/granularDriveRestoreArtifacts")]
    [Cmdlet(VerbsCommon.New, "MgSolutionBackupRestoreOneDriveForBusinessRestoreSessionGranularDriveRestoreArtifact", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.GranularDriveRestoreArtifact))]
    public class NewMgSolutionBackupRestoreOneDriveForBusinessRestoreSessionGranularDriveRestoreArtifactCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OneDriveForBusinessRestoreSessionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? BrowseSessionId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RestoredItemKey { get; set; }

        [Parameter(Mandatory = false)]
        public string? RestoredItemPath { get; set; }

        [Parameter(Mandatory = false)]
        public string? RestoredItemWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RestorePointDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? DirectoryObjectId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ArtifactRestoreStatus? Status { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OneDriveForBusinessRestoreSessionId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.BackupRestore.Client.Models.GranularDriveRestoreArtifact();

    if (this.IsParameterBound(nameof(BrowseSessionId)))
        body.BrowseSessionId = BrowseSessionId;

    if (this.IsParameterBound(nameof(CompletionDateTime)))
        body.CompletionDateTime = CompletionDateTime;

    if (this.IsParameterBound(nameof(RestoredItemKey)))
        body.RestoredItemKey = RestoredItemKey;

    if (this.IsParameterBound(nameof(RestoredItemPath)))
        body.RestoredItemPath = RestoredItemPath;

    if (this.IsParameterBound(nameof(RestoredItemWebUrl)))
        body.RestoredItemWebUrl = RestoredItemWebUrl;

    if (this.IsParameterBound(nameof(RestorePointDateTime)))
        body.RestorePointDateTime = RestorePointDateTime;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;

    if (this.IsParameterBound(nameof(DirectoryObjectId)))
        body.DirectoryObjectId = DirectoryObjectId;

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

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.GranularDriveRestoreArtifact? result;
            try
            {
                result = client.Solutions.BackupRestore.OneDriveForBusinessRestoreSessions[OneDriveForBusinessRestoreSessionId].GranularDriveRestoreArtifacts.PostAsync(body, requestConfiguration =>
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
