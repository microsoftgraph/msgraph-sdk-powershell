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
    [GraphRoute("PATCH", "/solutions/businessScenarios/{businessScenario-id}/planner/planConfiguration/localizations/{plannerPlanConfigurationLocalization-id}")]
    [Cmdlet(VerbsData.Update, "MgBusinessScenarioPlannerPlanConfigurationLocalization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerPlanConfigurationLocalization))]
    public class UpdateMgBusinessScenarioPlannerPlanConfigurationLocalizationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BusinessScenarioId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanConfigurationLocalizationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? LanguageTag { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlanTitle { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerPlanConfigurationBucketLocalization[]? Buckets { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerPlanConfigurationLocalizationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerPlanConfigurationLocalization();

    if (this.IsParameterBound(nameof(LanguageTag)))
        body.LanguageTag = LanguageTag;

    if (this.IsParameterBound(nameof(PlanTitle)))
        body.PlanTitle = PlanTitle;

    if (this.IsParameterBound(nameof(Buckets)))
        body.Buckets = Buckets!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerPlanConfigurationLocalization? result;
            try
            {
                result = client.Solutions.BusinessScenarios[BusinessScenarioId].Planner.PlanConfiguration.Localizations[PlannerPlanConfigurationLocalizationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerPlanConfigurationLocalizationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BusinessScenarios[BusinessScenarioId].Planner.PlanConfiguration.Localizations[PlannerPlanConfigurationLocalizationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PlannerPlanConfigurationLocalizationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
