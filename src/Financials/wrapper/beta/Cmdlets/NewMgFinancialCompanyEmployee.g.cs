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
    [GraphRoute("POST", "/financials/companies/{company-id}/employees")]
    [Cmdlet(VerbsCommon.New, "MgFinancialCompanyEmployee", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.Employee))]
    public class NewMgFinancialCompanyEmployeeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CompanyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? BirthDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Email { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? EmploymentDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? GivenName { get; set; }

        [Parameter(Mandatory = false)]
        public string? JobTitle { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? MiddleName { get; set; }

        [Parameter(Mandatory = false)]
        public string? MobilePhone { get; set; }

        [Parameter(Mandatory = false)]
        public string? Number { get; set; }

        [Parameter(Mandatory = false)]
        public string? PersonalEmail { get; set; }

        [Parameter(Mandatory = false)]
        public string? PhoneNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? StatisticsGroupCode { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public string? Surname { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? TerminationDate { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Financials.Client.Models.PostalAddressType? Address { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CompanyId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Financials.Client.Models.Employee();

    if (this.IsParameterBound(nameof(BirthDate)))
        body.BirthDate = BirthDate;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Email)))
        body.Email = Email;

    if (this.IsParameterBound(nameof(EmploymentDate)))
        body.EmploymentDate = EmploymentDate;

    if (this.IsParameterBound(nameof(GivenName)))
        body.GivenName = GivenName;

    if (this.IsParameterBound(nameof(JobTitle)))
        body.JobTitle = JobTitle;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(MiddleName)))
        body.MiddleName = MiddleName;

    if (this.IsParameterBound(nameof(MobilePhone)))
        body.MobilePhone = MobilePhone;

    if (this.IsParameterBound(nameof(Number)))
        body.Number = Number;

    if (this.IsParameterBound(nameof(PersonalEmail)))
        body.PersonalEmail = PersonalEmail;

    if (this.IsParameterBound(nameof(PhoneNumber)))
        body.PhoneNumber = PhoneNumber;

    if (this.IsParameterBound(nameof(StatisticsGroupCode)))
        body.StatisticsGroupCode = StatisticsGroupCode;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Surname)))
        body.Surname = Surname;

    if (this.IsParameterBound(nameof(TerminationDate)))
        body.TerminationDate = TerminationDate;

    if (this.IsParameterBound(nameof(Address)))
        body.Address = Address;


        var requestAdapter = GetRequestAdapter("beta");
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Financials.Client.Models.Employee? result;
            try
            {
                result = client.Financials.Companies[CompanyId].Employees.PostAsync(body, requestConfiguration =>
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
