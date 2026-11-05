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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/customerPayments/{customerPayment-id}")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanyCustomerPayment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.CustomerPayment))]
    public class UpdateMgFinancialCompanyCustomerPaymentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CustomerPaymentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public decimal? Amount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? AppliesToInvoiceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppliesToInvoiceNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? Comment { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContactId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? CustomerId { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomerNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DocumentNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalDocumentNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? JournalDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? LineNumber { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? PostingDate { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomerPaymentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.CustomerPayment();

    if (this.IsParameterBound(nameof(Amount)))
        body.Amount = Amount;

    if (this.IsParameterBound(nameof(AppliesToInvoiceId)))
        body.AppliesToInvoiceId = AppliesToInvoiceId;

    if (this.IsParameterBound(nameof(AppliesToInvoiceNumber)))
        body.AppliesToInvoiceNumber = AppliesToInvoiceNumber;

    if (this.IsParameterBound(nameof(Comment)))
        body.Comment = Comment;

    if (this.IsParameterBound(nameof(ContactId)))
        body.ContactId = ContactId;

    if (this.IsParameterBound(nameof(CustomerId)))
        body.CustomerId = CustomerId;

    if (this.IsParameterBound(nameof(CustomerNumber)))
        body.CustomerNumber = CustomerNumber;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DocumentNumber)))
        body.DocumentNumber = DocumentNumber;

    if (this.IsParameterBound(nameof(ExternalDocumentNumber)))
        body.ExternalDocumentNumber = ExternalDocumentNumber;

    if (this.IsParameterBound(nameof(JournalDisplayName)))
        body.JournalDisplayName = JournalDisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(LineNumber)))
        body.LineNumber = LineNumber;

    if (this.IsParameterBound(nameof(PostingDate)))
        body.PostingDate = PostingDate;



        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.CustomerPayment? result;
            try
            {
                result = client.Financials.Companies[CompanyId].CustomerPayments[CustomerPaymentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CustomerPaymentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Financials.Companies[CompanyId].CustomerPayments[CustomerPaymentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CustomerPaymentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
