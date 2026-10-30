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
    [GraphRoute("PATCH", "/security/partner/securityScore/customerInsights/{customerInsight-tenantId}")]
    [Cmdlet(VerbsData.Update, "MgSecurityPartnerSecurityScoreCustomerInsight", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.CustomerInsight))]
    public class UpdateMgSecurityPartnerSecurityScoreCustomerInsightCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CustomerInsightTenantId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.CustomerMfaInsight? Mfa { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomerInsightTenantId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.CustomerInsight();

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(Mfa)))
        body.Mfa = Mfa;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.CustomerInsight? result;
            try
            {
                result = client.Security.Partner.SecurityScore.CustomerInsights[CustomerInsightTenantId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CustomerInsightTenantId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Partner.SecurityScore.CustomerInsights[CustomerInsightTenantId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CustomerInsightTenantId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
