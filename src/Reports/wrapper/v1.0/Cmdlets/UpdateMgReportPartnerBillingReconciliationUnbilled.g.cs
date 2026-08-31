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
    [GraphRoute("PATCH", "/reports/partners/billing/reconciliation/unbilled")]
    [Cmdlet(VerbsData.Update, "MgReportPartnerBillingReconciliationUnbilled", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.UnbilledReconciliation))]
    public class UpdateMgReportPartnerBillingReconciliationUnbilledCommand : GraphClientCmdlet
    {









        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.UnbilledReconciliation();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.UnbilledReconciliation? result;
            try
            {
                result = client.Reports.Partners.Billing.Reconciliation.Unbilled.PatchAsync(body, requestConfiguration =>
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
                    result = client.Reports.Partners.Billing.Reconciliation.Unbilled.GetAsync().GetAwaiter().GetResult();
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
