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
    [GraphRoute("PATCH", "/auditLogs/signIns/{signIn-id}")]
    [Cmdlet(VerbsData.Update, "MgAuditLogSignIn", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.SignIn))]
    public class UpdateMgAuditLogSignInCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SignInId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppOwnerTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? AuthenticationMethodsUsed { get; set; }

        [Parameter(Mandatory = false)]
        public string? AuthenticationRequirement { get; set; }

        [Parameter(Mandatory = false)]
        public int? AutonomousSystemNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? AzureResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClientAppUsed { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClientSessionId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ConditionalAccessAudiences { get; set; }

        [Parameter(Mandatory = false)]
        public string? CorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? FederatedCredentialId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? FlaggedForReview { get; set; }

        [Parameter(Mandatory = false)]
        public string? GlobalSecureAccessIpAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? HomeTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? HomeTenantName { get; set; }

        [Parameter(Mandatory = false)]
        public string? IpAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? IpAddressFromResourceProvider { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsInteractive { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsTenantRestricted { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsThroughGlobalSecureAccess { get; set; }

        [Parameter(Mandatory = false)]
        public string? OriginalRequestId { get; set; }

        [Parameter(Mandatory = false)]
        public int? ProcessingTimeInMilliseconds { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceOwnerTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceServicePrincipalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RiskEventTypesV2 { get; set; }

        [Parameter(Mandatory = false)]
        public string? RootActorId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServicePrincipalCredentialKeyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServicePrincipalCredentialThumbprint { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServicePrincipalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServicePrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? SessionId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SignInEventTypes { get; set; }

        [Parameter(Mandatory = false)]
        public string? SignInIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? TokenIssuerName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UniqueTokenIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserAgent { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.Agentic.AgentSignIn? Agent { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AppliedConditionalAccessPolicy[]? AppliedConditionalAccessPolicies { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AppliedAuthenticationEventListener[]? AppliedEventListeners { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.TokenProtectionStatus? AppTokenProtectionStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AuthenticationAppDeviceDetails? AuthenticationAppDeviceDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AuthenticationAppPolicyDetails[]? AuthenticationAppPolicyEvaluationDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AuthenticationContext[]? AuthenticationContextClassReferences { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AuthenticationDetail[]? AuthenticationDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.KeyValue[]? AuthenticationProcessingDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ProtocolType? AuthenticationProtocol { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AuthenticationRequirementPolicy[]? AuthenticationRequirementPolicies { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ClientCredentialType? ClientCredentialType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ConditionalAccessStatus? ConditionalAccessStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInAccessType? CrossTenantAccessType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceDetail? DeviceDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.IncomingTokenType? IncomingTokenType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInLocation? Location { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ManagedIdentity? ManagedServiceIdentity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.MfaDetail? MfaDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.NetworkLocationDetail[]? NetworkLocationDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.OriginalTransferMethods? OriginalTransferMethod { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.PrivateLinkDetails? PrivateLinkDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.RiskDetail? RiskDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.RiskLevel? RiskLevelAggregated { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.RiskLevel? RiskLevelDuringSignIn { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.RiskState? RiskState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SessionLifetimePolicy[]? SessionLifetimePolicies { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInIdentifierType? SignInIdentifierType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.TokenProtectionStatus? SignInTokenProtectionStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.TokenIssuerType? TokenIssuerType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.TokenProtectionStatusDetails? TokenProtectionStatusDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInUserType? UserType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SignInId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.SignIn();

    if (this.IsParameterBound(nameof(AppDisplayName)))
        body.AppDisplayName = AppDisplayName;

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;

    if (this.IsParameterBound(nameof(AppOwnerTenantId)))
        body.AppOwnerTenantId = AppOwnerTenantId;

    if (this.IsParameterBound(nameof(AuthenticationMethodsUsed)))
        body.AuthenticationMethodsUsed = AuthenticationMethodsUsed!.ToList();

    if (this.IsParameterBound(nameof(AuthenticationRequirement)))
        body.AuthenticationRequirement = AuthenticationRequirement;

    if (this.IsParameterBound(nameof(AutonomousSystemNumber)))
        body.AutonomousSystemNumber = AutonomousSystemNumber;

    if (this.IsParameterBound(nameof(AzureResourceId)))
        body.AzureResourceId = AzureResourceId;

    if (this.IsParameterBound(nameof(ClientAppUsed)))
        body.ClientAppUsed = ClientAppUsed;

    if (this.IsParameterBound(nameof(ClientSessionId)))
        body.ClientSessionId = ClientSessionId;

    if (this.IsParameterBound(nameof(ConditionalAccessAudiences)))
        body.ConditionalAccessAudiences = ConditionalAccessAudiences!.ToList();

    if (this.IsParameterBound(nameof(CorrelationId)))
        body.CorrelationId = CorrelationId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(FederatedCredentialId)))
        body.FederatedCredentialId = FederatedCredentialId;

    if (this.IsParameterBound(nameof(FlaggedForReview)))
        body.FlaggedForReview = FlaggedForReview;

    if (this.IsParameterBound(nameof(GlobalSecureAccessIpAddress)))
        body.GlobalSecureAccessIpAddress = GlobalSecureAccessIpAddress;

    if (this.IsParameterBound(nameof(HomeTenantId)))
        body.HomeTenantId = HomeTenantId;

    if (this.IsParameterBound(nameof(HomeTenantName)))
        body.HomeTenantName = HomeTenantName;

    if (this.IsParameterBound(nameof(IpAddress)))
        body.IpAddress = IpAddress;

    if (this.IsParameterBound(nameof(IpAddressFromResourceProvider)))
        body.IpAddressFromResourceProvider = IpAddressFromResourceProvider;

    if (this.IsParameterBound(nameof(IsInteractive)))
        body.IsInteractive = IsInteractive;

    if (this.IsParameterBound(nameof(IsTenantRestricted)))
        body.IsTenantRestricted = IsTenantRestricted;

    if (this.IsParameterBound(nameof(IsThroughGlobalSecureAccess)))
        body.IsThroughGlobalSecureAccess = IsThroughGlobalSecureAccess;

    if (this.IsParameterBound(nameof(OriginalRequestId)))
        body.OriginalRequestId = OriginalRequestId;

    if (this.IsParameterBound(nameof(ProcessingTimeInMilliseconds)))
        body.ProcessingTimeInMilliseconds = ProcessingTimeInMilliseconds;

    if (this.IsParameterBound(nameof(ResourceDisplayName)))
        body.ResourceDisplayName = ResourceDisplayName;

    if (this.IsParameterBound(nameof(ResourceId)))
        body.ResourceId = ResourceId;

    if (this.IsParameterBound(nameof(ResourceOwnerTenantId)))
        body.ResourceOwnerTenantId = ResourceOwnerTenantId;

    if (this.IsParameterBound(nameof(ResourceServicePrincipalId)))
        body.ResourceServicePrincipalId = ResourceServicePrincipalId;

    if (this.IsParameterBound(nameof(ResourceTenantId)))
        body.ResourceTenantId = ResourceTenantId;

    if (this.IsParameterBound(nameof(RiskEventTypesV2)))
        body.RiskEventTypesV2 = RiskEventTypesV2!.ToList();

    if (this.IsParameterBound(nameof(RootActorId)))
        body.RootActorId = RootActorId;

    if (this.IsParameterBound(nameof(ServicePrincipalCredentialKeyId)))
        body.ServicePrincipalCredentialKeyId = ServicePrincipalCredentialKeyId;

    if (this.IsParameterBound(nameof(ServicePrincipalCredentialThumbprint)))
        body.ServicePrincipalCredentialThumbprint = ServicePrincipalCredentialThumbprint;

    if (this.IsParameterBound(nameof(ServicePrincipalId)))
        body.ServicePrincipalId = ServicePrincipalId;

    if (this.IsParameterBound(nameof(ServicePrincipalName)))
        body.ServicePrincipalName = ServicePrincipalName;

    if (this.IsParameterBound(nameof(SessionId)))
        body.SessionId = SessionId;

    if (this.IsParameterBound(nameof(SignInEventTypes)))
        body.SignInEventTypes = SignInEventTypes!.ToList();

    if (this.IsParameterBound(nameof(SignInIdentifier)))
        body.SignInIdentifier = SignInIdentifier;

    if (this.IsParameterBound(nameof(TokenIssuerName)))
        body.TokenIssuerName = TokenIssuerName;

    if (this.IsParameterBound(nameof(UniqueTokenIdentifier)))
        body.UniqueTokenIdentifier = UniqueTokenIdentifier;

    if (this.IsParameterBound(nameof(UserAgent)))
        body.UserAgent = UserAgent;

    if (this.IsParameterBound(nameof(UserDisplayName)))
        body.UserDisplayName = UserDisplayName;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(Agent)))
        body.Agent = Agent;

    if (this.IsParameterBound(nameof(AppliedConditionalAccessPolicies)))
        body.AppliedConditionalAccessPolicies = AppliedConditionalAccessPolicies!.ToList();

    if (this.IsParameterBound(nameof(AppliedEventListeners)))
        body.AppliedEventListeners = AppliedEventListeners!.ToList();

    if (this.IsParameterBound(nameof(AppTokenProtectionStatus)))
        body.AppTokenProtectionStatus = AppTokenProtectionStatus;

    if (this.IsParameterBound(nameof(AuthenticationAppDeviceDetails)))
        body.AuthenticationAppDeviceDetails = AuthenticationAppDeviceDetails;

    if (this.IsParameterBound(nameof(AuthenticationAppPolicyEvaluationDetails)))
        body.AuthenticationAppPolicyEvaluationDetails = AuthenticationAppPolicyEvaluationDetails!.ToList();

    if (this.IsParameterBound(nameof(AuthenticationContextClassReferences)))
        body.AuthenticationContextClassReferences = AuthenticationContextClassReferences!.ToList();

    if (this.IsParameterBound(nameof(AuthenticationDetails)))
        body.AuthenticationDetails = AuthenticationDetails!.ToList();

    if (this.IsParameterBound(nameof(AuthenticationProcessingDetails)))
        body.AuthenticationProcessingDetails = AuthenticationProcessingDetails!.ToList();

    if (this.IsParameterBound(nameof(AuthenticationProtocol)))
        body.AuthenticationProtocol = AuthenticationProtocol;

    if (this.IsParameterBound(nameof(AuthenticationRequirementPolicies)))
        body.AuthenticationRequirementPolicies = AuthenticationRequirementPolicies!.ToList();

    if (this.IsParameterBound(nameof(ClientCredentialType)))
        body.ClientCredentialType = ClientCredentialType;

    if (this.IsParameterBound(nameof(ConditionalAccessStatus)))
        body.ConditionalAccessStatus = ConditionalAccessStatus;

    if (this.IsParameterBound(nameof(CrossTenantAccessType)))
        body.CrossTenantAccessType = CrossTenantAccessType;

    if (this.IsParameterBound(nameof(DeviceDetail)))
        body.DeviceDetail = DeviceDetail;

    if (this.IsParameterBound(nameof(IncomingTokenType)))
        body.IncomingTokenType = IncomingTokenType;

    if (this.IsParameterBound(nameof(Location)))
        body.Location = Location;

    if (this.IsParameterBound(nameof(ManagedServiceIdentity)))
        body.ManagedServiceIdentity = ManagedServiceIdentity;

    if (this.IsParameterBound(nameof(MfaDetail)))
        body.MfaDetail = MfaDetail;

    if (this.IsParameterBound(nameof(NetworkLocationDetails)))
        body.NetworkLocationDetails = NetworkLocationDetails!.ToList();

    if (this.IsParameterBound(nameof(OriginalTransferMethod)))
        body.OriginalTransferMethod = OriginalTransferMethod;

    if (this.IsParameterBound(nameof(PrivateLinkDetails)))
        body.PrivateLinkDetails = PrivateLinkDetails;

    if (this.IsParameterBound(nameof(RiskDetail)))
        body.RiskDetail = RiskDetail;

    if (this.IsParameterBound(nameof(RiskLevelAggregated)))
        body.RiskLevelAggregated = RiskLevelAggregated;

    if (this.IsParameterBound(nameof(RiskLevelDuringSignIn)))
        body.RiskLevelDuringSignIn = RiskLevelDuringSignIn;

    if (this.IsParameterBound(nameof(RiskState)))
        body.RiskState = RiskState;

    if (this.IsParameterBound(nameof(SessionLifetimePolicies)))
        body.SessionLifetimePolicies = SessionLifetimePolicies!.ToList();

    if (this.IsParameterBound(nameof(SignInIdentifierType)))
        body.SignInIdentifierType = SignInIdentifierType;

    if (this.IsParameterBound(nameof(SignInTokenProtectionStatus)))
        body.SignInTokenProtectionStatus = SignInTokenProtectionStatus;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(TokenIssuerType)))
        body.TokenIssuerType = TokenIssuerType;

    if (this.IsParameterBound(nameof(TokenProtectionStatusDetails)))
        body.TokenProtectionStatusDetails = TokenProtectionStatusDetails;

    if (this.IsParameterBound(nameof(UserType)))
        body.UserType = UserType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.SignIn? result;
            try
            {
                result = client.AuditLogs.SignIns[SignInId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SignInId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.AuditLogs.SignIns[SignInId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SignInId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
