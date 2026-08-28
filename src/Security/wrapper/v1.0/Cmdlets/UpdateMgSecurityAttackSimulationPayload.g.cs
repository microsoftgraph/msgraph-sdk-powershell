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
    [GraphRoute("PATCH", "/security/attackSimulation/payloads/{payload-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityAttackSimulationPayload", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Payload))]
    public class UpdateMgSecurityAttackSimulationPayloadCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PayloadId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAutomated { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsControversial { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCurrentEvent { get; set; }

        [Parameter(Mandatory = false)]
        public string? Language { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? PayloadTags { get; set; }

        [Parameter(Mandatory = false)]
        public double? PredictedCompromiseRate { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PayloadBrand? Brand { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PayloadComplexity? Complexity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.EmailIdentity? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PayloadDetail? Detail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PayloadIndustry? Industry { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.EmailIdentity? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PayloadDeliveryPlatform? Platform { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAttackType? SimulationAttackType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SimulationContentSource? Source { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SimulationContentStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAttackTechnique? Technique { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PayloadTheme? Theme { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PayloadId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Payload();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsAutomated)))
        body.IsAutomated = IsAutomated;

    if (this.IsParameterBound(nameof(IsControversial)))
        body.IsControversial = IsControversial;

    if (this.IsParameterBound(nameof(IsCurrentEvent)))
        body.IsCurrentEvent = IsCurrentEvent;

    if (this.IsParameterBound(nameof(Language)))
        body.Language = Language;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(PayloadTags)))
        body.PayloadTags = PayloadTags!.ToList();

    if (this.IsParameterBound(nameof(PredictedCompromiseRate)))
        body.PredictedCompromiseRate = PredictedCompromiseRate;

    if (this.IsParameterBound(nameof(Brand)))
        body.Brand = Brand;

    if (this.IsParameterBound(nameof(Complexity)))
        body.Complexity = Complexity;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Detail)))
        body.Detail = Detail;

    if (this.IsParameterBound(nameof(Industry)))
        body.Industry = Industry;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(Platform)))
        body.Platform = Platform;

    if (this.IsParameterBound(nameof(SimulationAttackType)))
        body.SimulationAttackType = SimulationAttackType;

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Technique)))
        body.Technique = Technique;

    if (this.IsParameterBound(nameof(Theme)))
        body.Theme = Theme;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Payload? result;
            try
            {
                result = client.Security.AttackSimulation.Payloads[PayloadId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, PayloadId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.AttackSimulation.Payloads[PayloadId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, PayloadId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
