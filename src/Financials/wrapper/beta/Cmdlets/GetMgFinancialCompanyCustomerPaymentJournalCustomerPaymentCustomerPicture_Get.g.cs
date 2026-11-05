#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Financials.Client;
using Microsoft.Graph.PowerShell.Financials.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("GET", "/financials/companies/{company-id}/customerPaymentJournals/{customerPaymentJournal-id}/customerPayments/{customerPayment-id}/customer/picture/{picture-id}")]
    [Cmdlet(VerbsCommon.Get, "MgFinancialCompanyCustomerPaymentJournalCustomerPaymentCustomerPicture_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.Picture))]
    public class GetMgFinancialCompanyCustomerPaymentJournalCustomerPaymentCustomerPicture_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CustomerPaymentJournalId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CustomerPaymentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string PictureId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.Picture? result;
            try
            {
                result = client.Financials.Companies[CompanyId].CustomerPaymentJournals[CustomerPaymentJournalId].CustomerPayments[CustomerPaymentId].Customer.Picture[PictureId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PictureId);
                return;
            }

            WriteObject(result);
        }
    }
}
