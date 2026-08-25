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
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/resources/{accessPackageResource-id}/roles/{accessPackageResourceRole-id}")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementResourceRole", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceRole))]
    public class UpdateMgEntitlementManagementResourceRoleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessPackageResourceRoleId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OriginId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OriginSystem { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.RoleType? Type { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageResourceRoleId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceRole();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(OriginId)))
        body.OriginId = OriginId;

    if (this.IsParameterBound(nameof(OriginSystem)))
        body.OriginSystem = OriginSystem;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceRole? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.Resources[AccessPackageResourceId].Roles[AccessPackageResourceRoleId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageResourceRoleId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.Resources[AccessPackageResourceId].Roles[AccessPackageResourceRoleId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, AccessPackageResourceRoleId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
