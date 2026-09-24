#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("PATCH", "/reports/appCredentialSignInActivities/{appCredentialSignInActivity-id}")]
    [Cmdlet(VerbsData.Update, "MgReportAppCredentialSignInActivity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.AppCredentialSignInActivity))]
    public class UpdateMgReportAppCredentialSignInActivityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AppCredentialSignInActivityId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppObjectId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? KeyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServicePrincipalObjectId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ApplicationKeyOrigin? CredentialOrigin { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ApplicationKeyType? KeyType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ApplicationKeyUsage? KeyUsage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInActivity? SignInActivity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AppCredentialSignInActivityId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.AppCredentialSignInActivity();

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;

    if (this.IsParameterBound(nameof(AppObjectId)))
        body.AppObjectId = AppObjectId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(KeyId)))
        body.KeyId = KeyId;

    if (this.IsParameterBound(nameof(ResourceId)))
        body.ResourceId = ResourceId;

    if (this.IsParameterBound(nameof(ServicePrincipalObjectId)))
        body.ServicePrincipalObjectId = ServicePrincipalObjectId;

    if (this.IsParameterBound(nameof(CredentialOrigin)))
        body.CredentialOrigin = CredentialOrigin;

    if (this.IsParameterBound(nameof(KeyType)))
        body.KeyType = KeyType;

    if (this.IsParameterBound(nameof(KeyUsage)))
        body.KeyUsage = KeyUsage;

    if (this.IsParameterBound(nameof(SignInActivity)))
        body.SignInActivity = SignInActivity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.AppCredentialSignInActivity? result;
            try
            {
                result = client.Reports.AppCredentialSignInActivities[AppCredentialSignInActivityId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AppCredentialSignInActivityId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.AppCredentialSignInActivities[AppCredentialSignInActivityId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AppCredentialSignInActivityId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
