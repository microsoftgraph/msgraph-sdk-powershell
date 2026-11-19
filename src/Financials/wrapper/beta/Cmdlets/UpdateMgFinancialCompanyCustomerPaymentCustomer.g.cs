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
    [GraphRoute("PATCH", "/financials/companies/{company-id}/customerPayments/{customerPayment-id}/customer")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanyCustomerPaymentCustomer", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.Customer))]
    public class UpdateMgFinancialCompanyCustomerPaymentCustomerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CustomerPaymentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Blocked { get; set; }

        [Parameter(Mandatory = false)]
        public string? CurrencyCode { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? CurrencyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Email { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Number { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? PaymentMethodId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? PaymentTermsId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PhoneNumber { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? ShipmentMethodId { get; set; }

        [Parameter(Mandatory = false)]
        public string? TaxAreaDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? TaxAreaId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? TaxLiable { get; set; }

        [Parameter(Mandatory = false)]
        public string? TaxRegistrationNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public string? Website { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Financials.Client.Models.PostalAddressType? Address { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomerPaymentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.Customer();

    if (this.IsParameterBound(nameof(Blocked)))
        body.Blocked = Blocked;

    if (this.IsParameterBound(nameof(CurrencyCode)))
        body.CurrencyCode = CurrencyCode;

    if (this.IsParameterBound(nameof(CurrencyId)))
        body.CurrencyId = CurrencyId;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Email)))
        body.Email = Email;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Number)))
        body.Number = Number;

    if (this.IsParameterBound(nameof(PaymentMethodId)))
        body.PaymentMethodId = PaymentMethodId;

    if (this.IsParameterBound(nameof(PaymentTermsId)))
        body.PaymentTermsId = PaymentTermsId;

    if (this.IsParameterBound(nameof(PhoneNumber)))
        body.PhoneNumber = PhoneNumber;

    if (this.IsParameterBound(nameof(ShipmentMethodId)))
        body.ShipmentMethodId = ShipmentMethodId;

    if (this.IsParameterBound(nameof(TaxAreaDisplayName)))
        body.TaxAreaDisplayName = TaxAreaDisplayName;

    if (this.IsParameterBound(nameof(TaxAreaId)))
        body.TaxAreaId = TaxAreaId;

    if (this.IsParameterBound(nameof(TaxLiable)))
        body.TaxLiable = TaxLiable;

    if (this.IsParameterBound(nameof(TaxRegistrationNumber)))
        body.TaxRegistrationNumber = TaxRegistrationNumber;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

    if (this.IsParameterBound(nameof(Website)))
        body.Website = Website;

    if (this.IsParameterBound(nameof(Address)))
        body.Address = Address;


        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.Customer? result;
            try
            {
                result = client.Financials.Companies[CompanyId].CustomerPayments[CustomerPaymentId].Customer.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CustomerPaymentId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
