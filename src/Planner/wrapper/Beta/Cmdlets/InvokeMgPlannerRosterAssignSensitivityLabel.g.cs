#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Planner.Client;
using Microsoft.Graph.PowerShell.Planner.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Planner
{
    [GraphRoute("POST", "/planner/rosters/{plannerRoster-id}/assignSensitivityLabel")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgPlannerRosterAssignSensitivityLabel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerRoster))]
    public class InvokeMgPlannerRosterAssignSensitivityLabelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlannerRosterId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? SensitivityLabelId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.SensitivityLabelAssignmentMethod? AssignmentMethod { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerRosterId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Planner.Client.Planner.Rosters.Item.AssignSensitivityLabel.AssignSensitivityLabelPostRequestBody();

    if (this.IsParameterBound(nameof(SensitivityLabelId)))
        body.SensitivityLabelId = SensitivityLabelId;
    if (this.IsParameterBound(nameof(AssignmentMethod)))
        body.AssignmentMethod = AssignmentMethod;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerRoster? result;
            try
            {
                result = client.Planner.Rosters[PlannerRosterId].AssignSensitivityLabel.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerRosterId);
                return;
            }

            WriteObject(result);
        }
    }
}
