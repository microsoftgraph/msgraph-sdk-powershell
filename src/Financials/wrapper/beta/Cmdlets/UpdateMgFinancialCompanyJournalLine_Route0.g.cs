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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/journalLines/{journalLine-id}")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanyJournalLine_Route0", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.JournalLine))]
    public class UpdateMgFinancialCompanyJournalLine_Route0Command : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string JournalLineId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.Guid? AccountId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AccountNumber { get; set; }

        [Parameter(Mandatory = false)]
        public decimal? Amount { get; set; }

        [Parameter(Mandatory = false)]
        public string? Comment { get; set; }

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
            if (!ShouldProcess(JournalLineId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.JournalLine();

    if (this.IsParameterBound(nameof(AccountId)))
        body.AccountId = AccountId;

    if (this.IsParameterBound(nameof(AccountNumber)))
        body.AccountNumber = AccountNumber;

    if (this.IsParameterBound(nameof(Amount)))
        body.Amount = Amount;

    if (this.IsParameterBound(nameof(Comment)))
        body.Comment = Comment;

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

            Microsoft.Graph.PowerShell.Financials.Client.Models.JournalLine? result;
            try
            {
                result = client.Financials.Companies[CompanyId].JournalLines[JournalLineId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, JournalLineId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
