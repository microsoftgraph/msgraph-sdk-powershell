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
    [GraphRoute("PATCH", "/security/attackSimulation/operations/{attackSimulationOperation-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityAttackSimulationOperation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.AttackSimulationOperation))]
    public class UpdateMgSecurityAttackSimulationOperationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AttackSimulationOperationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastActionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? StatusDetail { get; set; }

        [Parameter(Mandatory = false)]
        public int? PercentageCompleted { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.LongRunningOperationStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AttackSimulationOperationType? Type { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AttackSimulationOperationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.AttackSimulationOperation();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(LastActionDateTime)))
        body.LastActionDateTime = LastActionDateTime;

    if (this.IsParameterBound(nameof(ResourceLocation)))
        body.ResourceLocation = ResourceLocation;

    if (this.IsParameterBound(nameof(StatusDetail)))
        body.StatusDetail = StatusDetail;

    if (this.IsParameterBound(nameof(PercentageCompleted)))
        body.PercentageCompleted = PercentageCompleted;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.AttackSimulationOperation? result;
            try
            {
                result = client.Security.AttackSimulation.Operations[AttackSimulationOperationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AttackSimulationOperationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.AttackSimulation.Operations[AttackSimulationOperationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, AttackSimulationOperationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
