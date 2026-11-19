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
    [GraphRoute("POST", "/financials/companies/{company-id}/taxGroups")]
    [Cmdlet(VerbsCommon.New, "MgFinancialCompanyTaxGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.TaxGroup))]
    public class NewMgFinancialCompanyTaxGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Code { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TaxType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CompanyId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.TaxGroup();

    if (this.IsParameterBound(nameof(Code)))
        body.Code = Code;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(TaxType)))
        body.TaxType = TaxType;



        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.TaxGroup? result;
            try
            {
                result = client.Financials.Companies[CompanyId].TaxGroups.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
