#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("PATCH", "/servicePrincipals/{servicePrincipal-id}/claimsPolicy")]
    [Cmdlet(VerbsData.Update, "MgServicePrincipalClaimPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.CustomClaimsPolicy))]
    public class UpdateMgServicePrincipalClaimPolicyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AudienceOverride { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IncludeApplicationIdInIssuer { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IncludeBasicClaimSet { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.CustomClaimBase[]? Claims { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.CustomClaimsPolicy();

    if (this.IsParameterBound(nameof(AudienceOverride)))
        body.AudienceOverride = AudienceOverride;

    if (this.IsParameterBound(nameof(IncludeApplicationIdInIssuer)))
        body.IncludeApplicationIdInIssuer = IncludeApplicationIdInIssuer;

    if (this.IsParameterBound(nameof(IncludeBasicClaimSet)))
        body.IncludeBasicClaimSet = IncludeBasicClaimSet;

    if (this.IsParameterBound(nameof(Claims)))
        body.Claims = Claims!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.CustomClaimsPolicy? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].ClaimsPolicy.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ServicePrincipalId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.ServicePrincipals[ServicePrincipalId].ClaimsPolicy.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ServicePrincipalId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
