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
    [GraphRoute("PUT", "/financials/companies/{company-id}/salesInvoices/{salesInvoice-id}/salesInvoiceLines/{salesInvoiceLine-id}/item/picture/{picture-id}/content")]
    [Cmdlet(VerbsCommon.Set, "MgFinancialCompanySaleInvoiceSaleInvoiceLineItemPictureContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.Picture))]
    public class SetMgFinancialCompanySaleInvoiceSaleInvoiceLineItemPictureContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SalesInvoiceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SalesInvoiceLineId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string PictureId { get; set; } = string.Empty;

                [Parameter(Mandatory = true,
                    HelpMessage = "Path to the file whose contents are uploaded.")]
                public string InFile { get; set; } = string.Empty;






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PictureId, "Set"))
                return;

        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.Picture? result;
            try
            {
                using var content = System.IO.File.OpenRead(InFile);
                result = client.Financials.Companies[CompanyId].SalesInvoices[SalesInvoiceId].SalesInvoiceLines[SalesInvoiceLineId].Item.Picture[PictureId].Content.PutAsync(content, requestConfiguration =>
                {

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
