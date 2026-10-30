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
    [GraphRoute("PATCH", "/policies/servicePrincipalCreationPolicies/{servicePrincipalCreationPolicy-id}/excludes/{servicePrincipalCreationConditionSet-id}")]
    [Cmdlet(VerbsData.Update, "MgPolicyServicePrincipalCreationPolicyExclude", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ServicePrincipalCreationConditionSet))]
    public class UpdateMgPolicyServicePrincipalCreationPolicyExcludeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalCreationPolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ServicePrincipalCreationConditionSetId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? ApplicationIds { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ApplicationPublisherIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ApplicationsFromVerifiedPublisherOnly { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ApplicationTenantIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? CertifiedApplicationsOnly { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalCreationConditionSetId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ServicePrincipalCreationConditionSet();

    if (this.IsParameterBound(nameof(ApplicationIds)))
        body.ApplicationIds = ApplicationIds!.ToList();

    if (this.IsParameterBound(nameof(ApplicationPublisherIds)))
        body.ApplicationPublisherIds = ApplicationPublisherIds!.ToList();

    if (this.IsParameterBound(nameof(ApplicationsFromVerifiedPublisherOnly)))
        body.ApplicationsFromVerifiedPublisherOnly = ApplicationsFromVerifiedPublisherOnly;

    if (this.IsParameterBound(nameof(ApplicationTenantIds)))
        body.ApplicationTenantIds = ApplicationTenantIds!.ToList();

    if (this.IsParameterBound(nameof(CertifiedApplicationsOnly)))
        body.CertifiedApplicationsOnly = CertifiedApplicationsOnly;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ServicePrincipalCreationConditionSet? result;
            try
            {
                result = client.Policies.ServicePrincipalCreationPolicies[ServicePrincipalCreationPolicyId].Excludes[ServicePrincipalCreationConditionSetId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ServicePrincipalCreationConditionSetId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.ServicePrincipalCreationPolicies[ServicePrincipalCreationPolicyId].Excludes[ServicePrincipalCreationConditionSetId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ServicePrincipalCreationConditionSetId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
