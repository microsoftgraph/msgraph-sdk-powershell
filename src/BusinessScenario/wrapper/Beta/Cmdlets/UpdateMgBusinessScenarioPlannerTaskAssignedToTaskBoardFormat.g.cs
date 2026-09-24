#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.BusinessScenario.Client;
using Microsoft.Graph.PowerShell.BusinessScenario.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.BusinessScenario
{
    [GraphRoute("PATCH", "/solutions/businessScenarios/{businessScenario-id}/planner/tasks/{businessScenarioTask-id}/assignedToTaskBoardFormat")]
    [Cmdlet(VerbsData.Update, "MgBusinessScenarioPlannerTaskAssignedToTaskBoardFormat", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerAssignedToTaskBoardTaskFormat))]
    public class UpdateMgBusinessScenarioPlannerTaskAssignedToTaskBoardFormatCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BusinessScenarioId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BusinessScenarioTaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? UnassignedOrderHint { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerOrderHintsByAssignee? OrderHintsByAssignee { get; set; }



        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BusinessScenarioTaskId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerAssignedToTaskBoardTaskFormat();

    if (this.IsParameterBound(nameof(UnassignedOrderHint)))
        body.UnassignedOrderHint = UnassignedOrderHint;

    if (this.IsParameterBound(nameof(OrderHintsByAssignee)))
        body.OrderHintsByAssignee = OrderHintsByAssignee;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerAssignedToTaskBoardTaskFormat? result;
            try
            {
                result = client.Solutions.BusinessScenarios[BusinessScenarioId].Planner.Tasks[BusinessScenarioTaskId].AssignedToTaskBoardFormat.PatchAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, BusinessScenarioTaskId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BusinessScenarios[BusinessScenarioId].Planner.Tasks[BusinessScenarioTaskId].AssignedToTaskBoardFormat.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, BusinessScenarioTaskId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
