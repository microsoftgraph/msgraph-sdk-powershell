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
    [GraphRoute("POST", "/planner/tasks_v2/{task-id}/customFieldValues")]
    [Cmdlet(VerbsCommon.New, "MgPlannerTaskV2CustomFieldValue", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.CustomFieldValue))]
    public class NewMgPlannerTaskV2CustomFieldValueCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CustomFieldDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Value { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TaskId, "New"))
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
                result = client.Planner.Tasks_v2[TaskId].CustomFieldValues.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
