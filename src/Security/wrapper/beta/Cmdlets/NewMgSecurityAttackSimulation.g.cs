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
    [GraphRoute("POST", "/security/attackSimulation/simulations")]
    [Cmdlet(VerbsCommon.New, "MgSecurityAttackSimulation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Simulation))]
    public class NewMgSecurityAttackSimulationCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AutomationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? DurationInDays { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAutomated { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LaunchDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAttackTechnique? AttackTechnique { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAttackType? AttackType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.EmailIdentity? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.EndUserNotificationSetting? EndUserNotificationSetting { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AccountTargetContent? ExcludedAccountTarget { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AccountTargetContent? IncludedAccountTarget { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.EmailIdentity? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.OAuthConsentAppDetail? OAuthConsentAppDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PayloadDeliveryPlatform? PayloadDeliveryPlatform { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SimulationReport? Report { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SimulationStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.TrainingSetting? TrainingSetting { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Simulation();

    if (this.IsParameterBound(nameof(AutomationId)))
        body.AutomationId = AutomationId;

    if (this.IsParameterBound(nameof(CompletionDateTime)))
        body.CompletionDateTime = CompletionDateTime;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DurationInDays)))
        body.DurationInDays = DurationInDays;

    if (this.IsParameterBound(nameof(IsAutomated)))
        body.IsAutomated = IsAutomated;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(LaunchDateTime)))
        body.LaunchDateTime = LaunchDateTime;

    if (this.IsParameterBound(nameof(AttackTechnique)))
        body.AttackTechnique = AttackTechnique;

    if (this.IsParameterBound(nameof(AttackType)))
        body.AttackType = AttackType;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(EndUserNotificationSetting)))
        body.EndUserNotificationSetting = EndUserNotificationSetting;

    if (this.IsParameterBound(nameof(ExcludedAccountTarget)))
        body.ExcludedAccountTarget = ExcludedAccountTarget;

    if (this.IsParameterBound(nameof(IncludedAccountTarget)))
        body.IncludedAccountTarget = IncludedAccountTarget;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(OAuthConsentAppDetail)))
        body.OAuthConsentAppDetail = OAuthConsentAppDetail;

    if (this.IsParameterBound(nameof(PayloadDeliveryPlatform)))
        body.PayloadDeliveryPlatform = PayloadDeliveryPlatform;

    if (this.IsParameterBound(nameof(Report)))
        body.Report = Report;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(TrainingSetting)))
        body.TrainingSetting = TrainingSetting;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Simulation? result;
            try
            {
                result = client.Security.AttackSimulation.Simulations.PostAsync(body, requestConfiguration =>
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
