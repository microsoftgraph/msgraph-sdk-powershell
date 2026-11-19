#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Financials.Client;
using Microsoft.Graph.PowerShell.Financials.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("PATCH", "/financials/companies/{company-id}/purchaseInvoices/{purchaseInvoice-id}/purchaseInvoiceLines/{purchaseInvoiceLine-id}/item/itemCategory")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanyPurchaseInvoicePurchaseInvoiceLineItemCategory", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.ItemCategory))]
    public class UpdateMgFinancialCompanyPurchaseInvoicePurchaseInvoiceLineItemCategoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PurchaseInvoiceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PurchaseInvoiceLineId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Code { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PurchaseInvoiceLineId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.ItemCategory();

    if (this.IsParameterBound(nameof(Code)))
        body.Code = Code;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;



        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.ItemCategory? result;
            try
            {
                result = client.Financials.Companies[CompanyId].PurchaseInvoices[PurchaseInvoiceId].PurchaseInvoiceLines[PurchaseInvoiceLineId].Item.ItemCategory.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PurchaseInvoiceLineId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
