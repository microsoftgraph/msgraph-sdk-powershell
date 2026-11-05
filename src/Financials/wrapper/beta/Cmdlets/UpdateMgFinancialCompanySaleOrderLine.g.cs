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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/salesOrderLines/{salesOrderLine-id}")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanySaleOrderLine", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.SalesOrderLine))]
    public class UpdateMgFinancialCompanySaleOrderLineCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SalesOrderLineId { get; set; } = string.Empty;

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
        public decimal? InvoiceDiscountAllocation { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? InvoicedQuantity { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? InvoiceQuantity { get; set; }

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
        public global::Microsoft.Kiota.Abstractions.Date? ShipmentDate { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? ShippedQuantity { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? ShipQuantity { get; set; }

        [Parameter(Mandatory = false)]
        public string? TaxCode { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? TaxPercent { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? TotalTaxAmount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? UnitOfMeasureId { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? UnitPrice { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SalesOrderLineId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.SalesOrderLine();

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

    if (this.IsParameterBound(nameof(InvoiceDiscountAllocation)))
        body.InvoiceDiscountAllocation = InvoiceDiscountAllocation;

    if (this.IsParameterBound(nameof(InvoicedQuantity)))
        body.InvoicedQuantity = InvoicedQuantity;

    if (this.IsParameterBound(nameof(InvoiceQuantity)))
        body.InvoiceQuantity = InvoiceQuantity;

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

    if (this.IsParameterBound(nameof(ShipmentDate)))
        body.ShipmentDate = ShipmentDate;

    if (this.IsParameterBound(nameof(ShippedQuantity)))
        body.ShippedQuantity = ShippedQuantity;

    if (this.IsParameterBound(nameof(ShipQuantity)))
        body.ShipQuantity = ShipQuantity;

    if (this.IsParameterBound(nameof(TaxCode)))
        body.TaxCode = TaxCode;

    if (this.IsParameterBound(nameof(TaxPercent)))
        body.TaxPercent = TaxPercent;

    if (this.IsParameterBound(nameof(TotalTaxAmount)))
        body.TotalTaxAmount = TotalTaxAmount;

    if (this.IsParameterBound(nameof(UnitOfMeasureId)))
        body.UnitOfMeasureId = UnitOfMeasureId;

    if (this.IsParameterBound(nameof(UnitPrice)))
        body.UnitPrice = UnitPrice;



        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.SalesOrderLine? result;
            try
            {
                result = client.Financials.Companies[CompanyId].SalesOrderLines[SalesOrderLineId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SalesOrderLineId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Financials.Companies[CompanyId].SalesOrderLines[SalesOrderLineId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SalesOrderLineId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
