#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Financials.Client;
using Microsoft.Graph.PowerShell.Financials.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("POST", "/financials/companies/{company-id}/salesInvoices/{salesInvoice-id}/cancelAndSend")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgFinancialCompanySaleInvoiceCancelAndSend", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgFinancialCompanySaleInvoiceCancelAndSendCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SalesInvoiceId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SalesInvoiceId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Financials.Companies[CompanyId].SalesInvoices[SalesInvoiceId].CancelAndSend.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SalesInvoiceId);
                return;
            }

        }
    }
}
