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
    [GraphRoute("POST", "/planner/tasks_v2/{task-id}/checklist")]
    [Cmdlet(VerbsCommon.New, "MgPlannerTaskV2Checklist", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.ChecklistItemV4))]
    public class NewMgPlannerTaskV2ChecklistCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsChecked { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.IdentitySet? CompletedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.ExtensionFieldCollection? Extensions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.IdentitySet? LastModifiedBy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TaskId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.ChecklistItemV4();

    if (this.IsParameterBound(nameof(CompletedDateTime)))
        body.CompletedDateTime = CompletedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsChecked)))
        body.IsChecked = IsChecked;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(CompletedBy)))
        body.CompletedBy = CompletedBy;

    if (this.IsParameterBound(nameof(Extensions)))
        body.Extensions = Extensions;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.ChecklistItemV4? result;
            try
            {
                result = client.Planner.Tasks_v2[TaskId].Checklist.PostAsync(body, requestConfiguration =>
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
