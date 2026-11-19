#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Financials.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("DELETE", "/financials/companies/{company-id}/salesQuotes/{salesQuote-id}/salesQuoteLines/{salesQuoteLine-id}/item/itemCategory")]
    [Cmdlet(VerbsCommon.Remove, "MgFinancialCompanySaleQuoteSaleQuoteLineItemCategory", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgFinancialCompanySaleQuoteSaleQuoteLineItemCategoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SalesQuoteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SalesQuoteLineId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SalesQuoteLineId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.Financials.Companies[CompanyId].SalesQuotes[SalesQuoteId].SalesQuoteLines[SalesQuoteLineId].Item.ItemCategory.DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SalesQuoteLineId);
                return;
            }
        }
    }
}
