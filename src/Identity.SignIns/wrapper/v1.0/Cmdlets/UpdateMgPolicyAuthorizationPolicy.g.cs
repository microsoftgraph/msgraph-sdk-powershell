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
    [GraphRoute("PATCH", "/policies/authorizationPolicy")]
    [Cmdlet(VerbsData.Update, "MgPolicyAuthorizationPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthorizationPolicy))]
    public class UpdateMgPolicyAuthorizationPolicyCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowedToSignUpEmailBasedSubscriptions { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowedToUseSSPR { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowEmailVerifiedUsersToJoinOrganization { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowUserConsentForRiskyApps { get; set; }

        [Parameter(Mandatory = false)]
        public bool? BlockMsolPowerShell { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? GuestUserRoleId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AllowInvitesFrom? AllowInvitesFrom { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DefaultUserRolePermissions? DefaultUserRolePermissions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthorizationPolicy();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(AllowedToSignUpEmailBasedSubscriptions)))
        body.AllowedToSignUpEmailBasedSubscriptions = AllowedToSignUpEmailBasedSubscriptions;

    if (this.IsParameterBound(nameof(AllowedToUseSSPR)))
        body.AllowedToUseSSPR = AllowedToUseSSPR;

    if (this.IsParameterBound(nameof(AllowEmailVerifiedUsersToJoinOrganization)))
        body.AllowEmailVerifiedUsersToJoinOrganization = AllowEmailVerifiedUsersToJoinOrganization;

    if (this.IsParameterBound(nameof(AllowUserConsentForRiskyApps)))
        body.AllowUserConsentForRiskyApps = AllowUserConsentForRiskyApps;

    if (this.IsParameterBound(nameof(BlockMsolPowerShell)))
        body.BlockMsolPowerShell = BlockMsolPowerShell;

    if (this.IsParameterBound(nameof(GuestUserRoleId)))
        body.GuestUserRoleId = GuestUserRoleId;

    if (this.IsParameterBound(nameof(AllowInvitesFrom)))
        body.AllowInvitesFrom = AllowInvitesFrom;

    if (this.IsParameterBound(nameof(DefaultUserRolePermissions)))
        body.DefaultUserRolePermissions = DefaultUserRolePermissions;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthorizationPolicy? result;
            try
            {
                result = client.Policies.AuthorizationPolicy.PatchAsync(body, requestConfiguration =>
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
                    result = client.Policies.AuthorizationPolicy.GetAsync().GetAwaiter().GetResult();
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
