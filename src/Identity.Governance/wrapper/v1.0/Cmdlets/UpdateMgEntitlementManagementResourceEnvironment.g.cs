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
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/resourceEnvironments/{accessPackageResourceEnvironment-id}")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementResourceEnvironment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceEnvironment))]
    public class UpdateMgEntitlementManagementResourceEnvironmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceEnvironmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDefaultEnvironment { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OriginId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OriginSystem { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ConnectionInfo? ConnectionInfo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageResourceEnvironmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceEnvironment();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsDefaultEnvironment)))
        body.IsDefaultEnvironment = IsDefaultEnvironment;

    if (this.IsParameterBound(nameof(ModifiedDateTime)))
        body.ModifiedDateTime = ModifiedDateTime;

    if (this.IsParameterBound(nameof(OriginId)))
        body.OriginId = OriginId;

    if (this.IsParameterBound(nameof(OriginSystem)))
        body.OriginSystem = OriginSystem;

    if (this.IsParameterBound(nameof(ConnectionInfo)))
        body.ConnectionInfo = ConnectionInfo;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceEnvironment? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.ResourceEnvironments[AccessPackageResourceEnvironmentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageResourceEnvironmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.ResourceEnvironments[AccessPackageResourceEnvironmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, AccessPackageResourceEnvironmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
