#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("GET", "/security/attackSimulation/simulationAutomations/{simulationAutomation-id}/runs/{simulationAutomationRun-id}")]
    [Cmdlet(VerbsCommon.Get, "MgSecurityAttackSimulationAutomationRun_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAutomationRun))]
    public class GetMgSecurityAttackSimulationAutomationRun_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SimulationAutomationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SimulationAutomationRunId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAutomationRun? result;
            try
            {
                result = client.Security.AttackSimulation.SimulationAutomations[SimulationAutomationId].Runs[SimulationAutomationRunId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SimulationAutomationRunId);
                return;
            }

            WriteObject(result);
        }
    }
}
