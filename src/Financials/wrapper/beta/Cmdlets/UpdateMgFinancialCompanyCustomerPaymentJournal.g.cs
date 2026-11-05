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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/customerPaymentJournals/{customerPaymentJournal-id}")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanyCustomerPaymentJournal", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.CustomerPaymentJournal))]
    public class UpdateMgFinancialCompanyCustomerPaymentJournalCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CustomerPaymentJournalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.Guid? BalancingAccountId { get; set; }

        [Parameter(Mandatory = false)]
        public string? BalancingAccountNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? Code { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomerPaymentJournalId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.CustomerPaymentJournal();

    if (this.IsParameterBound(nameof(BalancingAccountId)))
        body.BalancingAccountId = BalancingAccountId;

    if (this.IsParameterBound(nameof(BalancingAccountNumber)))
        body.BalancingAccountNumber = BalancingAccountNumber;

    if (this.IsParameterBound(nameof(Code)))
        body.Code = Code;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;



        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.CustomerPaymentJournal? result;
            try
            {
                result = client.Financials.Companies[CompanyId].CustomerPaymentJournals[CustomerPaymentJournalId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CustomerPaymentJournalId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Financials.Companies[CompanyId].CustomerPaymentJournals[CustomerPaymentJournalId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CustomerPaymentJournalId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
