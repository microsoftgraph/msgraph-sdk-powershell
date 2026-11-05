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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/companyInformation/{companyInformation-id}")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanyInformation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.CompanyInformation))]
    public class UpdateMgFinancialCompanyInformationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CompanyInformationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CurrencyCode { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? CurrentFiscalYearStartDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Email { get; set; }

        [Parameter(Mandatory = false)]
        public string? FaxNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? Industry { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PhoneNumber { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Picture { get; set; }

        [Parameter(Mandatory = false)]
        public string? TaxRegistrationNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? Website { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Financials.Client.Models.PostalAddressType? Address { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CompanyInformationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.CompanyInformation();

    if (this.IsParameterBound(nameof(CurrencyCode)))
        body.CurrencyCode = CurrencyCode;

    if (this.IsParameterBound(nameof(CurrentFiscalYearStartDate)))
        body.CurrentFiscalYearStartDate = CurrentFiscalYearStartDate;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Email)))
        body.Email = Email;

    if (this.IsParameterBound(nameof(FaxNumber)))
        body.FaxNumber = FaxNumber;

    if (this.IsParameterBound(nameof(Industry)))
        body.Industry = Industry;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(PhoneNumber)))
        body.PhoneNumber = PhoneNumber;

    if (this.IsParameterBound(nameof(Picture)))
        body.Picture = Picture;

    if (this.IsParameterBound(nameof(TaxRegistrationNumber)))
        body.TaxRegistrationNumber = TaxRegistrationNumber;

    if (this.IsParameterBound(nameof(Website)))
        body.Website = Website;

    if (this.IsParameterBound(nameof(Address)))
        body.Address = Address;


        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.CompanyInformation? result;
            try
            {
                result = client.Financials.Companies[CompanyId].CompanyInformation[CompanyInformationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CompanyInformationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Financials.Companies[CompanyId].CompanyInformation[CompanyInformationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CompanyInformationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
