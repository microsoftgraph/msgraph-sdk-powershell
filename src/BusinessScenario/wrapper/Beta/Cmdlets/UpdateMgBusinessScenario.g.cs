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
    [GraphRoute("PATCH", "/solutions/businessScenarios/{businessScenario-id}")]
    [Cmdlet(VerbsData.Update, "MgBusinessScenario", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.BusinessScenario))]
    public class UpdateMgBusinessScenarioCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BusinessScenarioId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? OwnerAppIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? UniqueName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.IdentitySet? LastModifiedBy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BusinessScenarioId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.BusinessScenario();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(OwnerAppIds)))
        body.OwnerAppIds = OwnerAppIds!.ToList();

    if (this.IsParameterBound(nameof(UniqueName)))
        body.UniqueName = UniqueName;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.BusinessScenario? result;
            try
            {
                result = client.Solutions.BusinessScenarios[BusinessScenarioId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, BusinessScenarioId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BusinessScenarios[BusinessScenarioId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, BusinessScenarioId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
