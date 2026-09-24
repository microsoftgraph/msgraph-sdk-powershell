#nullable enable

using System;
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
    [GraphRoute("GET", "/solutions/businessScenarios/{businessScenario-id}/planner/planConfiguration/localizations/{plannerPlanConfigurationLocalization-id}")]
    [Cmdlet(VerbsCommon.Get, "MgBusinessScenarioPlannerPlanConfigurationLocalization_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerPlanConfigurationLocalization))]
    public class GetMgBusinessScenarioPlannerPlanConfigurationLocalization_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BusinessScenarioId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanConfigurationLocalizationId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerPlanConfigurationLocalization? result;
            try
            {
                result = client.Solutions.BusinessScenarios[BusinessScenarioId].Planner.PlanConfiguration.Localizations[PlannerPlanConfigurationLocalizationId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerPlanConfigurationLocalizationId);
                return;
            }

            WriteObject(result);
        }
    }
}
