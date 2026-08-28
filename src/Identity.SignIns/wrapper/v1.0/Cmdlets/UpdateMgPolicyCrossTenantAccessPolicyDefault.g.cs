#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PATCH", "/policies/crossTenantAccessPolicy/default")]
    [Cmdlet(VerbsData.Update, "MgPolicyCrossTenantAccessPolicyDefault", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyConfigurationDefault))]
    public class UpdateMgPolicyCrossTenantAccessPolicyDefaultCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? IsServiceDefault { get; set; }

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
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DefaultInvitationRedemptionIdentityProviderConfiguration? InvitationRedemptionIdentityProviderConfiguration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyM365CollaborationInboundSetting? M365CollaborationInbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyM365CollaborationOutboundSetting? M365CollaborationOutbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyTenantRestrictions? TenantRestrictions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyConfigurationDefault();

    if (this.IsParameterBound(nameof(IsServiceDefault)))
        body.IsServiceDefault = IsServiceDefault;

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

    if (this.IsParameterBound(nameof(InvitationRedemptionIdentityProviderConfiguration)))
        body.InvitationRedemptionIdentityProviderConfiguration = InvitationRedemptionIdentityProviderConfiguration;

    if (this.IsParameterBound(nameof(M365CollaborationInbound)))
        body.M365CollaborationInbound = M365CollaborationInbound;

    if (this.IsParameterBound(nameof(M365CollaborationOutbound)))
        body.M365CollaborationOutbound = M365CollaborationOutbound;

    if (this.IsParameterBound(nameof(TenantRestrictions)))
        body.TenantRestrictions = TenantRestrictions;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyConfigurationDefault? result;
            try
            {
                result = client.Policies.CrossTenantAccessPolicy.Default.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.CrossTenantAccessPolicy.Default.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
