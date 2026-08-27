#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("POST", "/reports/partners/billing/reconciliation/billed/microsoft.graph.partners.billing.export")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgReportPartnerBillingReconciliationBilledExport", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.Operation))]
    public class InvokeMgReportPartnerBillingReconciliationBilledExportCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? InvoiceId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.AttributeSet? AttributeSet { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Reports.Client.Reports.Partners.Billing.Reconciliation.Billed.MicrosoftGraphPartnersBillingExport.ExportPostRequestBody();

    if (this.IsParameterBound(nameof(InvoiceId)))
        body.InvoiceId = InvoiceId;
    if (this.IsParameterBound(nameof(AttributeSet)))
        body.AttributeSet = AttributeSet;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.Operation? result;
            try
            {
                result = client.Reports.Partners.Billing.Reconciliation.Billed.MicrosoftGraphPartnersBillingExport.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
