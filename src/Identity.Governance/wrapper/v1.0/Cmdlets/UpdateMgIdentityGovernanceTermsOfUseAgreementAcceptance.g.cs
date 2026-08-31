#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("PATCH", "/identityGovernance/termsOfUse/agreementAcceptances/{agreementAcceptance-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceTermsOfUseAgreementAcceptance", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementAcceptance))]
    public class UpdateMgIdentityGovernanceTermsOfUseAgreementAcceptanceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AgreementAcceptanceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AgreementFileId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AgreementId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceOSType { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceOSVersion { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RecordedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserEmail { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementAcceptanceState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AgreementAcceptanceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementAcceptance();

    if (this.IsParameterBound(nameof(AgreementFileId)))
        body.AgreementFileId = AgreementFileId;

    if (this.IsParameterBound(nameof(AgreementId)))
        body.AgreementId = AgreementId;

    if (this.IsParameterBound(nameof(DeviceDisplayName)))
        body.DeviceDisplayName = DeviceDisplayName;

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceOSType)))
        body.DeviceOSType = DeviceOSType;

    if (this.IsParameterBound(nameof(DeviceOSVersion)))
        body.DeviceOSVersion = DeviceOSVersion;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(RecordedDateTime)))
        body.RecordedDateTime = RecordedDateTime;

    if (this.IsParameterBound(nameof(UserDisplayName)))
        body.UserDisplayName = UserDisplayName;

    if (this.IsParameterBound(nameof(UserEmail)))
        body.UserEmail = UserEmail;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementAcceptance? result;
            try
            {
                result = client.IdentityGovernance.TermsOfUse.AgreementAcceptances[AgreementAcceptanceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AgreementAcceptanceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.TermsOfUse.AgreementAcceptances[AgreementAcceptanceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AgreementAcceptanceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
