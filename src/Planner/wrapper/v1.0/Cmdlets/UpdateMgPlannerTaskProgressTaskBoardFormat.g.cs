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
    [GraphRoute("PATCH", "/planner/tasks/{plannerTask-id}/progressTaskBoardFormat")]
    [Cmdlet(VerbsData.Update, "MgPlannerTaskProgressTaskBoardFormat", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerProgressTaskBoardTaskFormat))]
    public class UpdateMgPlannerTaskProgressTaskBoardFormatCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlannerTaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? OrderHint { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerTaskId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerProgressTaskBoardTaskFormat();

    if (this.IsParameterBound(nameof(OrderHint)))
        body.OrderHint = OrderHint;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerProgressTaskBoardTaskFormat? result;
            try
            {
                result = client.Planner.Tasks[PlannerTaskId].ProgressTaskBoardFormat.PatchAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, PlannerTaskId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Planner.Tasks[PlannerTaskId].ProgressTaskBoardFormat.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, PlannerTaskId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
