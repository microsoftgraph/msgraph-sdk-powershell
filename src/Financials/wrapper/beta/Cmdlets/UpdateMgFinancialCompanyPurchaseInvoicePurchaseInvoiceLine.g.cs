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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/purchaseInvoices/{purchaseInvoice-id}/purchaseInvoiceLines/{purchaseInvoiceLine-id}")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanyPurchaseInvoicePurchaseInvoiceLine", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.PurchaseInvoiceLine))]
    public class UpdateMgFinancialCompanyPurchaseInvoicePurchaseInvoiceLineCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PurchaseInvoiceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PurchaseInvoiceLineId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.Guid? AccountId { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? AmountExcludingTax { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? AmountIncludingTax { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? DiscountAmount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DiscountAppliedBeforeTax { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? DiscountPercent { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? DocumentId { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? ExpectedReceiptDate { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? InvoiceDiscountAllocation { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? ItemId { get; set; }

        [Parameter(Mandatory = false)]
        public string? LineType { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? NetAmount { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? NetAmountIncludingTax { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? NetTaxAmount { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? Quantity { get; set; }

        [Parameter(Mandatory = false)]
        public int? Sequence { get; set; }

        [Parameter(Mandatory = false)]
        public string? TaxCode { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? TaxPercent { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? TotalTaxAmount { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? UnitCost { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PurchaseInvoiceLineId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.PurchaseInvoiceLine();

    if (this.IsParameterBound(nameof(AccountId)))
        body.AccountId = AccountId;

    if (this.IsParameterBound(nameof(AmountExcludingTax)))
        body.AmountExcludingTax = AmountExcludingTax;

    if (this.IsParameterBound(nameof(AmountIncludingTax)))
        body.AmountIncludingTax = AmountIncludingTax;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DiscountAmount)))
        body.DiscountAmount = DiscountAmount;

    if (this.IsParameterBound(nameof(DiscountAppliedBeforeTax)))
        body.DiscountAppliedBeforeTax = DiscountAppliedBeforeTax;

    if (this.IsParameterBound(nameof(DiscountPercent)))
        body.DiscountPercent = DiscountPercent;

    if (this.IsParameterBound(nameof(DocumentId)))
        body.DocumentId = DocumentId;

    if (this.IsParameterBound(nameof(ExpectedReceiptDate)))
        body.ExpectedReceiptDate = ExpectedReceiptDate;

    if (this.IsParameterBound(nameof(InvoiceDiscountAllocation)))
        body.InvoiceDiscountAllocation = InvoiceDiscountAllocation;

    if (this.IsParameterBound(nameof(ItemId)))
        body.ItemId = ItemId;

    if (this.IsParameterBound(nameof(LineType)))
        body.LineType = LineType;

    if (this.IsParameterBound(nameof(NetAmount)))
        body.NetAmount = NetAmount;

    if (this.IsParameterBound(nameof(NetAmountIncludingTax)))
        body.NetAmountIncludingTax = NetAmountIncludingTax;

    if (this.IsParameterBound(nameof(NetTaxAmount)))
        body.NetTaxAmount = NetTaxAmount;

    if (this.IsParameterBound(nameof(Quantity)))
        body.Quantity = Quantity;

    if (this.IsParameterBound(nameof(Sequence)))
        body.Sequence = Sequence;

    if (this.IsParameterBound(nameof(TaxCode)))
        body.TaxCode = TaxCode;

    if (this.IsParameterBound(nameof(TaxPercent)))
        body.TaxPercent = TaxPercent;

    if (this.IsParameterBound(nameof(TotalTaxAmount)))
        body.TotalTaxAmount = TotalTaxAmount;

    if (this.IsParameterBound(nameof(UnitCost)))
        body.UnitCost = UnitCost;



        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.PurchaseInvoiceLine? result;
            try
            {
                result = client.Financials.Companies[CompanyId].PurchaseInvoices[PurchaseInvoiceId].PurchaseInvoiceLines[PurchaseInvoiceLineId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PurchaseInvoiceLineId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Financials.Companies[CompanyId].PurchaseInvoices[PurchaseInvoiceId].PurchaseInvoiceLines[PurchaseInvoiceLineId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PurchaseInvoiceLineId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
