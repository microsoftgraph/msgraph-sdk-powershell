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
    [GraphRoute("PATCH", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}/userAttributeAssignments/{identityUserFlowAttributeAssignment-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityB2XUserFlowUserAttributeAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityUserFlowAttributeAssignment))]
    public class UpdateMgIdentityB2XUserFlowUserAttributeAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2xIdentityUserFlowId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string IdentityUserFlowAttributeAssignmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsOptional { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RequiresVerification { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UserAttributeValuesItem[]? UserAttributeValues { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityUserFlowAttributeInputType? UserInputType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IdentityUserFlowAttributeAssignmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityUserFlowAttributeAssignment();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsOptional)))
        body.IsOptional = IsOptional;

    if (this.IsParameterBound(nameof(RequiresVerification)))
        body.RequiresVerification = RequiresVerification;

    if (this.IsParameterBound(nameof(UserAttributeValues)))
        body.UserAttributeValues = UserAttributeValues!.ToList();

    if (this.IsParameterBound(nameof(UserInputType)))
        body.UserInputType = UserInputType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityUserFlowAttributeAssignment? result;
            try
            {
                result = client.Identity.B2xUserFlows[B2xIdentityUserFlowId].UserAttributeAssignments[IdentityUserFlowAttributeAssignmentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, IdentityUserFlowAttributeAssignmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Identity.B2xUserFlows[B2xIdentityUserFlowId].UserAttributeAssignments[IdentityUserFlowAttributeAssignmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, IdentityUserFlowAttributeAssignmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
