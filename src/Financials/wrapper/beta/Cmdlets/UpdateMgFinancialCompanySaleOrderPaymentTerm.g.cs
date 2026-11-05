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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/salesOrders/{salesOrder-id}/paymentTerm")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanySaleOrderPaymentTerm", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.PaymentTerm))]
    public class UpdateMgFinancialCompanySaleOrderPaymentTermCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SalesOrderId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? CalculateDiscountOnCreditMemos { get; set; }

        [Parameter(Mandatory = false)]
        public string? Code { get; set; }

        [Parameter(Mandatory = false)]
        public string? DiscountDateCalculation { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? DiscountPercent { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DueDateCalculation { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SalesOrderId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.PaymentTerm();

    if (this.IsParameterBound(nameof(CalculateDiscountOnCreditMemos)))
        body.CalculateDiscountOnCreditMemos = CalculateDiscountOnCreditMemos;

    if (this.IsParameterBound(nameof(Code)))
        body.Code = Code;

    if (this.IsParameterBound(nameof(DiscountDateCalculation)))
        body.DiscountDateCalculation = DiscountDateCalculation;

    if (this.IsParameterBound(nameof(DiscountPercent)))
        body.DiscountPercent = DiscountPercent;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DueDateCalculation)))
        body.DueDateCalculation = DueDateCalculation;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;



        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.PaymentTerm? result;
            try
            {
                result = client.Financials.Companies[CompanyId].SalesOrders[SalesOrderId].PaymentTerm.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SalesOrderId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Financials.Companies[CompanyId].SalesOrders[SalesOrderId].PaymentTerm.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SalesOrderId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
