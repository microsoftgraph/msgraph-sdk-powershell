#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/identityProtection/riskyAgents")]
    [Cmdlet(VerbsCommon.New, "MgRiskyAgent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyAgent))]
    public class NewMgRiskyAgentCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AdditionalInfo { get; set; }

        [Parameter(Mandatory = false)]
        public string? AgentDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AgentPlatform { get; set; }

        [Parameter(Mandatory = false)]
        public string? AssociatedUserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? BlueprintId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDeleted { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsProcessing { get; set; }

        [Parameter(Mandatory = false)]
        public string? MachineId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RiskLastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Sources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.BlastRadiusRisk? BlastRadiusRisk { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ExposureRisk? ExposureRisk { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AgentIdentityType? IdentityType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetail? RiskDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskLevel? RiskLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskState? RiskState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RuntimeRisk? RuntimeRisk { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyAgent();

    if (this.IsParameterBound(nameof(AdditionalInfo)))
        body.AdditionalInfo = AdditionalInfo;

    if (this.IsParameterBound(nameof(AgentDisplayName)))
        body.AgentDisplayName = AgentDisplayName;

    if (this.IsParameterBound(nameof(AgentPlatform)))
        body.AgentPlatform = AgentPlatform;

    if (this.IsParameterBound(nameof(AssociatedUserId)))
        body.AssociatedUserId = AssociatedUserId;

    if (this.IsParameterBound(nameof(BlueprintId)))
        body.BlueprintId = BlueprintId;

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(IsDeleted)))
        body.IsDeleted = IsDeleted;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(IsProcessing)))
        body.IsProcessing = IsProcessing;

    if (this.IsParameterBound(nameof(MachineId)))
        body.MachineId = MachineId;

    if (this.IsParameterBound(nameof(RiskLastModifiedDateTime)))
        body.RiskLastModifiedDateTime = RiskLastModifiedDateTime;

    if (this.IsParameterBound(nameof(Sources)))
        body.Sources = Sources!.ToList();

    if (this.IsParameterBound(nameof(BlastRadiusRisk)))
        body.BlastRadiusRisk = BlastRadiusRisk;

    if (this.IsParameterBound(nameof(ExposureRisk)))
        body.ExposureRisk = ExposureRisk;

    if (this.IsParameterBound(nameof(IdentityType)))
        body.IdentityType = IdentityType;

    if (this.IsParameterBound(nameof(RiskDetail)))
        body.RiskDetail = RiskDetail;

    if (this.IsParameterBound(nameof(RiskLevel)))
        body.RiskLevel = RiskLevel;

    if (this.IsParameterBound(nameof(RiskState)))
        body.RiskState = RiskState;

    if (this.IsParameterBound(nameof(RuntimeRisk)))
        body.RuntimeRisk = RuntimeRisk;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyAgent? result;
            try
            {
                result = client.IdentityProtection.RiskyAgents.PostAsync(body, requestConfiguration =>
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
