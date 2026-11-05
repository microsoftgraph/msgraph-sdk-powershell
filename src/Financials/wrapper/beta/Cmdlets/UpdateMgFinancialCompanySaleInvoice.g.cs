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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/salesInvoices/{salesInvoice-id}")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanySaleInvoice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.SalesInvoice))]
    public class UpdateMgFinancialCompanySaleInvoiceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SalesInvoiceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.Guid? BillToCustomerId { get; set; }

        [Parameter(Mandatory = false)]
        public string? BillToCustomerNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? BillToName { get; set; }

        [Parameter(Mandatory = false)]
        public string? CurrencyCode { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? CurrencyId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? CustomerId { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomerName { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomerNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomerPurchaseOrderReference { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? DiscountAmount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DiscountAppliedBeforeTax { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? DueDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? Email { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalDocumentNumber { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? InvoiceDate { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Number { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? OrderId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OrderNumber { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? PaymentTermsId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PhoneNumber { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PricesIncludeTax { get; set; }

        [Parameter(Mandatory = false)]
        public string? Salesperson { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? ShipmentMethodId { get; set; }

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
        public Microsoft.Graph.PowerShell.Financials.Client.Models.PostalAddressType? BillingPostalAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Financials.Client.Models.PostalAddressType? SellingPostalAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Financials.Client.Models.PostalAddressType? ShippingPostalAddress { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SalesInvoiceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.SalesInvoice();

    if (this.IsParameterBound(nameof(BillToCustomerId)))
        body.BillToCustomerId = BillToCustomerId;

    if (this.IsParameterBound(nameof(BillToCustomerNumber)))
        body.BillToCustomerNumber = BillToCustomerNumber;

    if (this.IsParameterBound(nameof(BillToName)))
        body.BillToName = BillToName;

    if (this.IsParameterBound(nameof(CurrencyCode)))
        body.CurrencyCode = CurrencyCode;

    if (this.IsParameterBound(nameof(CurrencyId)))
        body.CurrencyId = CurrencyId;

    if (this.IsParameterBound(nameof(CustomerId)))
        body.CustomerId = CustomerId;

    if (this.IsParameterBound(nameof(CustomerName)))
        body.CustomerName = CustomerName;

    if (this.IsParameterBound(nameof(CustomerNumber)))
        body.CustomerNumber = CustomerNumber;

    if (this.IsParameterBound(nameof(CustomerPurchaseOrderReference)))
        body.CustomerPurchaseOrderReference = CustomerPurchaseOrderReference;

    if (this.IsParameterBound(nameof(DiscountAmount)))
        body.DiscountAmount = DiscountAmount;

    if (this.IsParameterBound(nameof(DiscountAppliedBeforeTax)))
        body.DiscountAppliedBeforeTax = DiscountAppliedBeforeTax;

    if (this.IsParameterBound(nameof(DueDate)))
        body.DueDate = DueDate;

    if (this.IsParameterBound(nameof(Email)))
        body.Email = Email;

    if (this.IsParameterBound(nameof(ExternalDocumentNumber)))
        body.ExternalDocumentNumber = ExternalDocumentNumber;

    if (this.IsParameterBound(nameof(InvoiceDate)))
        body.InvoiceDate = InvoiceDate;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Number)))
        body.Number = Number;

    if (this.IsParameterBound(nameof(OrderId)))
        body.OrderId = OrderId;

    if (this.IsParameterBound(nameof(OrderNumber)))
        body.OrderNumber = OrderNumber;

    if (this.IsParameterBound(nameof(PaymentTermsId)))
        body.PaymentTermsId = PaymentTermsId;

    if (this.IsParameterBound(nameof(PhoneNumber)))
        body.PhoneNumber = PhoneNumber;

    if (this.IsParameterBound(nameof(PricesIncludeTax)))
        body.PricesIncludeTax = PricesIncludeTax;

    if (this.IsParameterBound(nameof(Salesperson)))
        body.Salesperson = Salesperson;

    if (this.IsParameterBound(nameof(ShipmentMethodId)))
        body.ShipmentMethodId = ShipmentMethodId;

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

    if (this.IsParameterBound(nameof(BillingPostalAddress)))
        body.BillingPostalAddress = BillingPostalAddress;

    if (this.IsParameterBound(nameof(SellingPostalAddress)))
        body.SellingPostalAddress = SellingPostalAddress;

    if (this.IsParameterBound(nameof(ShippingPostalAddress)))
        body.ShippingPostalAddress = ShippingPostalAddress;


        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.SalesInvoice? result;
            try
            {
                result = client.Financials.Companies[CompanyId].SalesInvoices[SalesInvoiceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SalesInvoiceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Financials.Companies[CompanyId].SalesInvoices[SalesInvoiceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SalesInvoiceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
