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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/purchaseInvoices/{purchaseInvoice-id}")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanyPurchaseInvoice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.PurchaseInvoice))]
    public class UpdateMgFinancialCompanyPurchaseInvoiceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PurchaseInvoiceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CurrencyCode { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? CurrencyId { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? DiscountAmount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DiscountAppliedBeforeTax { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? DueDate { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? InvoiceDate { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Number { get; set; }

        [Parameter(Mandatory = false)]
        public string? PayToContact { get; set; }

        [Parameter(Mandatory = false)]
        public string? PayToName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? PayToVendorId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PayToVendorNumber { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PricesIncludeTax { get; set; }

        [Parameter(Mandatory = false)]
        public string? ShipToContact { get; set; }

        [Parameter(Mandatory = false)]
        public string? ShipToName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? TotalAmountExcludingTax { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? TotalAmountIncludingTax { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? TotalTaxAmount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? VendorId { get; set; }

        [Parameter(Mandatory = false)]
        public string? VendorInvoiceNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? VendorName { get; set; }

        [Parameter(Mandatory = false)]
        public string? VendorNumber { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Financials.Client.Models.PostalAddressType? BuyFromAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Financials.Client.Models.PostalAddressType? PayToAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Financials.Client.Models.PostalAddressType? ShipToAddress { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PurchaseInvoiceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.PurchaseInvoice();

    if (this.IsParameterBound(nameof(CurrencyCode)))
        body.CurrencyCode = CurrencyCode;

    if (this.IsParameterBound(nameof(CurrencyId)))
        body.CurrencyId = CurrencyId;

    if (this.IsParameterBound(nameof(DiscountAmount)))
        body.DiscountAmount = DiscountAmount;

    if (this.IsParameterBound(nameof(DiscountAppliedBeforeTax)))
        body.DiscountAppliedBeforeTax = DiscountAppliedBeforeTax;

    if (this.IsParameterBound(nameof(DueDate)))
        body.DueDate = DueDate;

    if (this.IsParameterBound(nameof(InvoiceDate)))
        body.InvoiceDate = InvoiceDate;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Number)))
        body.Number = Number;

    if (this.IsParameterBound(nameof(PayToContact)))
        body.PayToContact = PayToContact;

    if (this.IsParameterBound(nameof(PayToName)))
        body.PayToName = PayToName;

    if (this.IsParameterBound(nameof(PayToVendorId)))
        body.PayToVendorId = PayToVendorId;

    if (this.IsParameterBound(nameof(PayToVendorNumber)))
        body.PayToVendorNumber = PayToVendorNumber;

    if (this.IsParameterBound(nameof(PricesIncludeTax)))
        body.PricesIncludeTax = PricesIncludeTax;

    if (this.IsParameterBound(nameof(ShipToContact)))
        body.ShipToContact = ShipToContact;

    if (this.IsParameterBound(nameof(ShipToName)))
        body.ShipToName = ShipToName;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(TotalAmountExcludingTax)))
        body.TotalAmountExcludingTax = TotalAmountExcludingTax;

    if (this.IsParameterBound(nameof(TotalAmountIncludingTax)))
        body.TotalAmountIncludingTax = TotalAmountIncludingTax;

    if (this.IsParameterBound(nameof(TotalTaxAmount)))
        body.TotalTaxAmount = TotalTaxAmount;

    if (this.IsParameterBound(nameof(VendorId)))
        body.VendorId = VendorId;

    if (this.IsParameterBound(nameof(VendorInvoiceNumber)))
        body.VendorInvoiceNumber = VendorInvoiceNumber;

    if (this.IsParameterBound(nameof(VendorName)))
        body.VendorName = VendorName;

    if (this.IsParameterBound(nameof(VendorNumber)))
        body.VendorNumber = VendorNumber;

    if (this.IsParameterBound(nameof(BuyFromAddress)))
        body.BuyFromAddress = BuyFromAddress;

    if (this.IsParameterBound(nameof(PayToAddress)))
        body.PayToAddress = PayToAddress;

    if (this.IsParameterBound(nameof(ShipToAddress)))
        body.ShipToAddress = ShipToAddress;


        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.PurchaseInvoice? result;
            try
            {
                result = client.Financials.Companies[CompanyId].PurchaseInvoices[PurchaseInvoiceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PurchaseInvoiceId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
