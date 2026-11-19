#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Financials.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("GET", "/financials/companies/{company-id}/salesQuotes/{salesQuote-id}/salesQuoteLines/{salesQuoteLine-id}/item/picture/$count")]
    [Cmdlet(VerbsCommon.Get, "MgFinancialCompanySaleQuoteSaleQuoteLineItemPictureCount")]
    [OutputType(typeof(int))]
    public class GetMgFinancialCompanySaleQuoteSaleQuoteLineItemPictureCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SalesQuoteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SalesQuoteLineId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.Financials.Companies[CompanyId].SalesQuotes[SalesQuoteId].SalesQuoteLines[SalesQuoteLineId].Item.Picture.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SalesQuoteLineId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
