#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.BusinessScenario.Client;
using Microsoft.Graph.PowerShell.BusinessScenario.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.BusinessScenario
{
    [GraphRoute("POST", "/solutions/businessScenarios/{businessScenario-id}/planner/getPlan")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgBusinessScenarioPlannerGetPlan", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.BusinessScenarioPlanReference))]
    public class InvokeMgBusinessScenarioPlannerGetPlanCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BusinessScenarioId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.BusinessScenarioTaskTargetBase? Target { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BusinessScenarioId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.BusinessScenario.Client.Solutions.BusinessScenarios.Item.Planner.GetPlan.GetPlanPostRequestBody();

    if (this.IsParameterBound(nameof(Target)))
        body.Target = Target;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.BusinessScenarioPlanReference? result;
            try
            {
                result = client.Solutions.BusinessScenarios[BusinessScenarioId].Planner.GetPlan.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, BusinessScenarioId);
                return;
            }

            WriteObject(result);
        }
    }
}
