#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Planner.Client;
using Microsoft.Graph.PowerShell.Planner.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Planner
{
    [GraphRoute("PATCH", "/planner/plans_v2/{plan-id}/contexts/{planContextLink-id}")]
    [Cmdlet(VerbsData.Update, "MgPlannerPlanV2Context", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.PlanContextLink))]
    public class UpdateMgPlannerPlanV2ContextCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlanId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlanContextLinkId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AssociationType { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomLinkText { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? DisplayNameSegments { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsActive { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCreation { get; set; }

        [Parameter(Mandatory = false)]
        public string? Key { get; set; }

        [Parameter(Mandatory = false)]
        public string? OwnerAppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerPlanContextType? DisplayAs { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlanContextLinkId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.PlanContextLink();

    if (this.IsParameterBound(nameof(AssociationType)))
        body.AssociationType = AssociationType;

    if (this.IsParameterBound(nameof(CustomLinkText)))
        body.CustomLinkText = CustomLinkText;

    if (this.IsParameterBound(nameof(DisplayNameSegments)))
        body.DisplayNameSegments = DisplayNameSegments!.ToList();

    if (this.IsParameterBound(nameof(IsActive)))
        body.IsActive = IsActive;

    if (this.IsParameterBound(nameof(IsCreation)))
        body.IsCreation = IsCreation;

    if (this.IsParameterBound(nameof(Key)))
        body.Key = Key;

    if (this.IsParameterBound(nameof(OwnerAppId)))
        body.OwnerAppId = OwnerAppId;

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;

    if (this.IsParameterBound(nameof(DisplayAs)))
        body.DisplayAs = DisplayAs;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.PlanContextLink? result;
            try
            {
                result = client.Planner.Plans_v2[PlanId].Contexts[PlanContextLinkId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlanContextLinkId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Planner.Plans_v2[PlanId].Contexts[PlanContextLinkId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PlanContextLinkId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
