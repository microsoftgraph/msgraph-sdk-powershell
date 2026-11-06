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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/salesOrders/{salesOrder-id}/salesOrderLines/{salesOrderLine-id}/item")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanySaleOrderSaleOrderLineItem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.Item))]
    public class UpdateMgFinancialCompanySaleOrderSaleOrderLineItemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SalesOrderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SalesOrderLineId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.Guid? BaseUnitOfMeasureId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Blocked { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Gtin { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? Inventory { get; set; }

        [Parameter(Mandatory = false)]
        public string? ItemCategoryCode { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? ItemCategoryId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Number { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PriceIncludesTax { get; set; }

        [Parameter(Mandatory = false)]
        public string? TaxGroupCode { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? TaxGroupId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? UnitCost { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? UnitPrice { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SalesOrderLineId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.Item();

    if (this.IsParameterBound(nameof(BaseUnitOfMeasureId)))
        body.BaseUnitOfMeasureId = BaseUnitOfMeasureId;

    if (this.IsParameterBound(nameof(Blocked)))
        body.Blocked = Blocked;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Gtin)))
        body.Gtin = Gtin;

    if (this.IsParameterBound(nameof(Inventory)))
        body.Inventory = Inventory;

    if (this.IsParameterBound(nameof(ItemCategoryCode)))
        body.ItemCategoryCode = ItemCategoryCode;

    if (this.IsParameterBound(nameof(ItemCategoryId)))
        body.ItemCategoryId = ItemCategoryId;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Number)))
        body.Number = Number;

    if (this.IsParameterBound(nameof(PriceIncludesTax)))
        body.PriceIncludesTax = PriceIncludesTax;

    if (this.IsParameterBound(nameof(TaxGroupCode)))
        body.TaxGroupCode = TaxGroupCode;

    if (this.IsParameterBound(nameof(TaxGroupId)))
        body.TaxGroupId = TaxGroupId;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

    if (this.IsParameterBound(nameof(UnitCost)))
        body.UnitCost = UnitCost;

    if (this.IsParameterBound(nameof(UnitPrice)))
        body.UnitPrice = UnitPrice;



        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.Item? result;
            try
            {
                result = client.Financials.Companies[CompanyId].SalesOrders[SalesOrderId].SalesOrderLines[SalesOrderLineId].Item.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SalesOrderLineId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
