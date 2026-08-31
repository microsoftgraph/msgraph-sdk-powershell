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
    [GraphRoute("PATCH", "/identityProtection/riskyServicePrincipals/{riskyServicePrincipal-id}")]
    [Cmdlet(VerbsData.Update, "MgRiskyServicePrincipal", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyServicePrincipal))]
    public class UpdateMgRiskyServicePrincipalCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RiskyServicePrincipalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsProcessing { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RiskLastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServicePrincipalType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetail? RiskDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskLevel? RiskLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskState? RiskState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RiskyServicePrincipalId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyServicePrincipal();

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(IsProcessing)))
        body.IsProcessing = IsProcessing;

    if (this.IsParameterBound(nameof(RiskLastUpdatedDateTime)))
        body.RiskLastUpdatedDateTime = RiskLastUpdatedDateTime;

    if (this.IsParameterBound(nameof(ServicePrincipalType)))
        body.ServicePrincipalType = ServicePrincipalType;

    if (this.IsParameterBound(nameof(RiskDetail)))
        body.RiskDetail = RiskDetail;

    if (this.IsParameterBound(nameof(RiskLevel)))
        body.RiskLevel = RiskLevel;

    if (this.IsParameterBound(nameof(RiskState)))
        body.RiskState = RiskState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyServicePrincipal? result;
            try
            {
                result = client.IdentityProtection.RiskyServicePrincipals[RiskyServicePrincipalId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, RiskyServicePrincipalId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityProtection.RiskyServicePrincipals[RiskyServicePrincipalId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, RiskyServicePrincipalId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
