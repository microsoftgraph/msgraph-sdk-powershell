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
    [GraphRoute("PATCH", "/reports/partners/billing/usage")]
    [Cmdlet(VerbsData.Update, "MgReportPartnerBillingUsage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.AzureUsage))]
    public class UpdateMgReportPartnerBillingUsageCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.BilledUsage? Billed { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.UnbilledUsage? Unbilled { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.AzureUsage();


    if (this.IsParameterBound(nameof(Billed)))
        body.Billed = Billed;

    if (this.IsParameterBound(nameof(Unbilled)))
        body.Unbilled = Unbilled;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.AzureUsage? result;
            try
            {
                result = client.Reports.Partners.Billing.Usage.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.Partners.Billing.Usage.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
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
