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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/vendors/{vendor-id}/currency")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanyVendorCurrency", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.Currency))]
    public class UpdateMgFinancialCompanyVendorCurrencyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string VendorId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AmountDecimalPlaces { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? AmountRoundingPrecision { get; set; }

        [Parameter(Mandatory = false)]
        public string? Code { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Symbol { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VendorId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.Currency();

    if (this.IsParameterBound(nameof(AmountDecimalPlaces)))
        body.AmountDecimalPlaces = AmountDecimalPlaces;

    if (this.IsParameterBound(nameof(AmountRoundingPrecision)))
        body.AmountRoundingPrecision = AmountRoundingPrecision;

    if (this.IsParameterBound(nameof(Code)))
        body.Code = Code;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Symbol)))
        body.Symbol = Symbol;



        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.Currency? result;
            try
            {
                result = client.Financials.Companies[CompanyId].Vendors[VendorId].Currency.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, VendorId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
