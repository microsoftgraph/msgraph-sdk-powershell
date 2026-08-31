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
    [GraphRoute("PATCH", "/planner/plans/{plannerPlan-id}/details")]
    [Cmdlet(VerbsData.Update, "MgPlannerPlanDetail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerPlanDetails))]
    public class UpdateMgPlannerPlanDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlannerPlanId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerCategoryDescriptions? CategoryDescriptions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerUserIds? SharedWith { get; set; }



        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerPlanId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerPlanDetails();


    if (this.IsParameterBound(nameof(CategoryDescriptions)))
        body.CategoryDescriptions = CategoryDescriptions;

    if (this.IsParameterBound(nameof(SharedWith)))
        body.SharedWith = SharedWith;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerPlanDetails? result;
            try
            {
                result = client.Planner.Plans[PlannerPlanId].Details.PatchAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerPlanId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Planner.Plans[PlannerPlanId].Details.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PlannerPlanId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
