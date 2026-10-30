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
    [GraphRoute("PATCH", "/policies/authorizationPolicy/{authorizationPolicy-id}/defaultUserRoleOverrides/{defaultUserRoleOverride-id}")]
    [Cmdlet(VerbsData.Update, "MgPolicyAuthorizationPolicyDefaultUserRoleOverride", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DefaultUserRoleOverride))]
    public class UpdateMgPolicyAuthorizationPolicyDefaultUserRoleOverrideCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthorizationPolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DefaultUserRoleOverrideId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsDefault { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UnifiedRolePermission[]? RolePermissions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DefaultUserRoleOverrideId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DefaultUserRoleOverride();

    if (this.IsParameterBound(nameof(IsDefault)))
        body.IsDefault = IsDefault;

    if (this.IsParameterBound(nameof(RolePermissions)))
        body.RolePermissions = RolePermissions!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DefaultUserRoleOverride? result;
            try
            {
                result = client.Policies.AuthorizationPolicy[AuthorizationPolicyId].DefaultUserRoleOverrides[DefaultUserRoleOverrideId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DefaultUserRoleOverrideId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.AuthorizationPolicy[AuthorizationPolicyId].DefaultUserRoleOverrides[DefaultUserRoleOverrideId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DefaultUserRoleOverrideId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
