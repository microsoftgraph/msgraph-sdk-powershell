#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Education.Client;
using Microsoft.Graph.PowerShell.Education.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Education
{
    [GraphRoute("PATCH", "/education/schools/{educationSchool-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationSchool", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationSchool))]
    public class UpdateMgEducationSchoolCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationSchoolId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalSourceDetail { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalPrincipalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Fax { get; set; }

        [Parameter(Mandatory = false)]
        public string? HighestGrade { get; set; }

        [Parameter(Mandatory = false)]
        public string? LowestGrade { get; set; }

        [Parameter(Mandatory = false)]
        public string? Phone { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalEmail { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? SchoolNumber { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationExternalSource? ExternalSource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.PhysicalAddress? Address { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.IdentitySet? CreatedBy { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationSchoolId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationSchool();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExternalSourceDetail)))
        body.ExternalSourceDetail = ExternalSourceDetail;

    if (this.IsParameterBound(nameof(ExternalId)))
        body.ExternalId = ExternalId;

    if (this.IsParameterBound(nameof(ExternalPrincipalId)))
        body.ExternalPrincipalId = ExternalPrincipalId;

    if (this.IsParameterBound(nameof(Fax)))
        body.Fax = Fax;

    if (this.IsParameterBound(nameof(HighestGrade)))
        body.HighestGrade = HighestGrade;

    if (this.IsParameterBound(nameof(LowestGrade)))
        body.LowestGrade = LowestGrade;

    if (this.IsParameterBound(nameof(Phone)))
        body.Phone = Phone;

    if (this.IsParameterBound(nameof(PrincipalEmail)))
        body.PrincipalEmail = PrincipalEmail;

    if (this.IsParameterBound(nameof(PrincipalName)))
        body.PrincipalName = PrincipalName;

    if (this.IsParameterBound(nameof(SchoolNumber)))
        body.SchoolNumber = SchoolNumber;

    if (this.IsParameterBound(nameof(ExternalSource)))
        body.ExternalSource = ExternalSource;

    if (this.IsParameterBound(nameof(Address)))
        body.Address = Address;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;


        // ── Choose HttpClient + auth provider ─────────────────────────────
        HttpClient httpClient;
        IAuthenticationProvider authProvider;

        if (this.IsParameterBound(nameof(AccessToken)))
        {
            httpClient = new HttpClient();
            authProvider = new StaticBearerTokenAuthenticationProvider(AccessToken!);
        }
        else
        {
            WriteVerbose("No -AccessToken supplied, using the active Connect-MgGraph session.");
            try
            {
                httpClient = HttpHelpers.GetGraphHttpClient();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(
                    new InvalidOperationException(
                        "No active Graph session. Run Connect-MgGraph first, or supply -AccessToken.", ex),
                    "NoGraphSession",
                    ErrorCategory.AuthenticationError,
                    null));
                return;
            }
            authProvider = new AnonymousAuthenticationProvider();
        }

        var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationSchool? result;
            try
            {
                result = client.Education.Schools[EducationSchoolId].PatchAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(Headers)))
                        {
                            foreach (System.Collections.DictionaryEntry entry in Headers!)
                                requestConfiguration.Headers.Add(entry.Key.ToString()!, entry.Value?.ToString() ?? string.Empty);
                        }
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, EducationSchoolId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Schools[EducationSchoolId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, EducationSchoolId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
