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
    [GraphRoute("PATCH", "/auditLogs/signUps/{selfServiceSignUp-id}")]
    [Cmdlet(VerbsData.Update, "MgAuditLogSignUp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.SelfServiceSignUp))]
    public class UpdateMgAuditLogSignUpCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SelfServiceSignUpId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? CorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? SignUpIdentityProvider { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AppliedAuthenticationEventListener[]? AppliedEventListeners { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.FraudProtectionDetails? FraudProtectionDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignUpIdentity? SignUpIdentity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignUpStage? SignUpStage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignUpStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SelfServiceSignUpId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.SelfServiceSignUp();

    if (this.IsParameterBound(nameof(AppDisplayName)))
        body.AppDisplayName = AppDisplayName;

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;

    if (this.IsParameterBound(nameof(CorrelationId)))
        body.CorrelationId = CorrelationId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(SignUpIdentityProvider)))
        body.SignUpIdentityProvider = SignUpIdentityProvider;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(AppliedEventListeners)))
        body.AppliedEventListeners = AppliedEventListeners!.ToList();

    if (this.IsParameterBound(nameof(FraudProtectionDetails)))
        body.FraudProtectionDetails = FraudProtectionDetails;

    if (this.IsParameterBound(nameof(SignUpIdentity)))
        body.SignUpIdentity = SignUpIdentity;

    if (this.IsParameterBound(nameof(SignUpStage)))
        body.SignUpStage = SignUpStage;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.SelfServiceSignUp? result;
            try
            {
                result = client.AuditLogs.SignUps[SelfServiceSignUpId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SelfServiceSignUpId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.AuditLogs.SignUps[SelfServiceSignUpId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SelfServiceSignUpId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
