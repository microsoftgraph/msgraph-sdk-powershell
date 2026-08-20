#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/deviceAppManagement/mobileApps/{mobileApp-id}/graph.androidLobApp/contentVersions/{mobileAppContent-id}/files/{mobileAppContentFile-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementMobileAppAsAndroidLobAppContentVersionFile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentFile))]
    public class UpdateMgDeviceAppManagementMobileAppAsAndroidLobAppContentVersionFileCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MobileAppContentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MobileAppContentFileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsDependency { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Manifest { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public long? Size { get; set; }

        [Parameter(Mandatory = false)]
        public long? SizeEncrypted { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentFileUploadState? UploadState { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppContentFileId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentFile();

    if (this.IsParameterBound(nameof(IsDependency)))
        body.IsDependency = IsDependency;

    if (this.IsParameterBound(nameof(Manifest)))
        body.Manifest = Manifest;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Size)))
        body.Size = Size;

    if (this.IsParameterBound(nameof(SizeEncrypted)))
        body.SizeEncrypted = SizeEncrypted;

    if (this.IsParameterBound(nameof(UploadState)))
        body.UploadState = UploadState;


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

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentFile? result;
            try
            {
                result = client.DeviceAppManagement.MobileApps[MobileAppId].GraphAndroidLobApp.ContentVersions[MobileAppContentId].Files[MobileAppContentFileId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, MobileAppContentFileId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.MobileApps[MobileAppId].GraphAndroidLobApp.ContentVersions[MobileAppContentId].Files[MobileAppContentFileId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, MobileAppContentFileId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
