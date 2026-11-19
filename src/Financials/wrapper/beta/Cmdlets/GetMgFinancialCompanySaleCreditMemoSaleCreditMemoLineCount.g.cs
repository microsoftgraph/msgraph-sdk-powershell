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
    [GraphRoute("GET", "/financials/companies/{company-id}/salesCreditMemos/{salesCreditMemo-id}/salesCreditMemoLines/$count")]
    [Cmdlet(VerbsCommon.Get, "MgFinancialCompanySaleCreditMemoSaleCreditMemoLineCount")]
    [OutputType(typeof(int))]
    public class GetMgFinancialCompanySaleCreditMemoSaleCreditMemoLineCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SalesCreditMemoId { get; set; } = string.Empty;



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
                result = client.Financials.Companies[CompanyId].SalesCreditMemos[SalesCreditMemoId].SalesCreditMemoLines.Count.GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, SalesCreditMemoId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
