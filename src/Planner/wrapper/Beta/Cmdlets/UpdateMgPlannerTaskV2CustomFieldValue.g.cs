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
    [GraphRoute("PATCH", "/planner/tasks_v2/{task-id}/customFieldValues/{customFieldValue-id}")]
    [Cmdlet(VerbsData.Update, "MgPlannerTaskV2CustomFieldValue", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.CustomFieldValue))]
    public class UpdateMgPlannerTaskV2CustomFieldValueCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TaskId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CustomFieldValueId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CustomFieldDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Value { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomFieldValueId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.CustomFieldValue();

    if (this.IsParameterBound(nameof(CustomFieldDefinitionId)))
        body.CustomFieldDefinitionId = CustomFieldDefinitionId;

    if (this.IsParameterBound(nameof(Value)))
        body.Value = Value;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.CustomFieldValue? result;
            try
            {
                result = client.Planner.Tasks_v2[TaskId].CustomFieldValues[CustomFieldValueId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CustomFieldValueId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Planner.Tasks_v2[TaskId].CustomFieldValues[CustomFieldValueId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CustomFieldValueId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
