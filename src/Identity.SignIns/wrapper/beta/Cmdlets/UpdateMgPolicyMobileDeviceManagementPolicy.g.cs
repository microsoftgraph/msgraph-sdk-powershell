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
    [GraphRoute("PATCH", "/policies/mobileDeviceManagementPolicies/{mobileDeviceManagementPolicy-id}")]
    [Cmdlet(VerbsData.Update, "MgPolicyMobileDeviceManagementPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MobileDeviceManagementPolicy))]
    public class UpdateMgPolicyMobileDeviceManagementPolicyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileDeviceManagementPolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ComplianceUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DiscoveryUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsValid { get; set; }

        [Parameter(Mandatory = false)]
        public string? TermsOfUseUrl { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMdmEnrollmentDuringRegistrationDisabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.PolicyScope? AppliesTo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileDeviceManagementPolicyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MobileDeviceManagementPolicy();

    if (this.IsParameterBound(nameof(ComplianceUrl)))
        body.ComplianceUrl = ComplianceUrl;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DiscoveryUrl)))
        body.DiscoveryUrl = DiscoveryUrl;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsValid)))
        body.IsValid = IsValid;

    if (this.IsParameterBound(nameof(TermsOfUseUrl)))
        body.TermsOfUseUrl = TermsOfUseUrl;

    if (this.IsParameterBound(nameof(IsMdmEnrollmentDuringRegistrationDisabled)))
        body.IsMdmEnrollmentDuringRegistrationDisabled = IsMdmEnrollmentDuringRegistrationDisabled;

    if (this.IsParameterBound(nameof(AppliesTo)))
        body.AppliesTo = AppliesTo;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MobileDeviceManagementPolicy? result;
            try
            {
                result = client.Policies.MobileDeviceManagementPolicies[MobileDeviceManagementPolicyId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MobileDeviceManagementPolicyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.MobileDeviceManagementPolicies[MobileDeviceManagementPolicyId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, MobileDeviceManagementPolicyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
