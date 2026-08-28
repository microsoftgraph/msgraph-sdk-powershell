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
    [GraphRoute("PATCH", "/policies/permissionGrantPolicies/{permissionGrantPolicy-id}/includes/{permissionGrantConditionSet-id}")]
    [Cmdlet(VerbsData.Update, "MgPolicyPermissionGrantPolicyInclude", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.PermissionGrantConditionSet))]
    public class UpdateMgPolicyPermissionGrantPolicyIncludeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PermissionGrantPolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PermissionGrantConditionSetId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? ClientApplicationIds { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ClientApplicationPublisherIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ClientApplicationsFromVerifiedPublisherOnly { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ClientApplicationTenantIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? PermissionClassification { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Permissions { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceApplication { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.PermissionType? PermissionType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PermissionGrantConditionSetId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.PermissionGrantConditionSet();

    if (this.IsParameterBound(nameof(ClientApplicationIds)))
        body.ClientApplicationIds = ClientApplicationIds!.ToList();

    if (this.IsParameterBound(nameof(ClientApplicationPublisherIds)))
        body.ClientApplicationPublisherIds = ClientApplicationPublisherIds!.ToList();

    if (this.IsParameterBound(nameof(ClientApplicationsFromVerifiedPublisherOnly)))
        body.ClientApplicationsFromVerifiedPublisherOnly = ClientApplicationsFromVerifiedPublisherOnly;

    if (this.IsParameterBound(nameof(ClientApplicationTenantIds)))
        body.ClientApplicationTenantIds = ClientApplicationTenantIds!.ToList();

    if (this.IsParameterBound(nameof(PermissionClassification)))
        body.PermissionClassification = PermissionClassification;

    if (this.IsParameterBound(nameof(Permissions)))
        body.Permissions = Permissions!.ToList();

    if (this.IsParameterBound(nameof(ResourceApplication)))
        body.ResourceApplication = ResourceApplication;

    if (this.IsParameterBound(nameof(PermissionType)))
        body.PermissionType = PermissionType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.PermissionGrantConditionSet? result;
            try
            {
                result = client.Policies.PermissionGrantPolicies[PermissionGrantPolicyId].Includes[PermissionGrantConditionSetId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, PermissionGrantConditionSetId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.PermissionGrantPolicies[PermissionGrantPolicyId].Includes[PermissionGrantConditionSetId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, PermissionGrantConditionSetId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
