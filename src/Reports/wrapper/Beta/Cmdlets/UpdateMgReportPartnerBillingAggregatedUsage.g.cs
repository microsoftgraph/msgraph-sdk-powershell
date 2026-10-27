#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("PATCH", "/reports/partners/billing/aggregatedUsage")]
    [Cmdlet(VerbsData.Update, "MgReportPartnerBillingAggregatedUsage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.AzureAggregatedUsage))]
    public class UpdateMgReportPartnerBillingAggregatedUsageCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.BilledAggregatedUsage? Billed { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.AzureAggregatedUsage();


    if (this.IsParameterBound(nameof(Billed)))
        body.Billed = Billed;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.AzureAggregatedUsage? result;
            try
            {
                result = client.Reports.Partners.Billing.AggregatedUsage.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.Partners.Billing.AggregatedUsage.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
