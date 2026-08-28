#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/attackSimulation/simulationAutomations/{simulationAutomation-id}/runs")]
    [Cmdlet(VerbsCommon.New, "MgSecurityAttackSimulationAutomationRun", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAutomationRun))]
    public class NewMgSecurityAttackSimulationAutomationRunCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SimulationAutomationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? SimulationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAutomationRunStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SimulationAutomationId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAutomationRun();

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(SimulationId)))
        body.SimulationId = SimulationId;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAutomationRun? result;
            try
            {
                result = client.Security.AttackSimulation.SimulationAutomations[SimulationAutomationId].Runs.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
