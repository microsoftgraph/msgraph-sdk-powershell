#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("PATCH", "/reports/authenticationMethods/userRegistrationDetails/{userRegistrationDetails-id}")]
    [Cmdlet(VerbsData.Update, "MgReportAuthenticationMethodUserRegistrationDetail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.UserRegistrationDetails))]
    public class UpdateMgReportAuthenticationMethodUserRegistrationDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserRegistrationDetailsId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsAdmin { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMfaCapable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMfaRegistered { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsPasswordlessCapable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSsprCapable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSsprEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSsprRegistered { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSystemPreferredAuthenticationMethodEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? MethodsRegistered { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SystemPreferredAuthenticationMethods { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.UserDefaultAuthenticationMethod? UserPreferredMethodForSecondaryAuthentication { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInUserType? UserType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserRegistrationDetailsId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.UserRegistrationDetails();

    if (this.IsParameterBound(nameof(IsAdmin)))
        body.IsAdmin = IsAdmin;

    if (this.IsParameterBound(nameof(IsMfaCapable)))
        body.IsMfaCapable = IsMfaCapable;

    if (this.IsParameterBound(nameof(IsMfaRegistered)))
        body.IsMfaRegistered = IsMfaRegistered;

    if (this.IsParameterBound(nameof(IsPasswordlessCapable)))
        body.IsPasswordlessCapable = IsPasswordlessCapable;

    if (this.IsParameterBound(nameof(IsSsprCapable)))
        body.IsSsprCapable = IsSsprCapable;

    if (this.IsParameterBound(nameof(IsSsprEnabled)))
        body.IsSsprEnabled = IsSsprEnabled;

    if (this.IsParameterBound(nameof(IsSsprRegistered)))
        body.IsSsprRegistered = IsSsprRegistered;

    if (this.IsParameterBound(nameof(IsSystemPreferredAuthenticationMethodEnabled)))
        body.IsSystemPreferredAuthenticationMethodEnabled = IsSystemPreferredAuthenticationMethodEnabled;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(MethodsRegistered)))
        body.MethodsRegistered = MethodsRegistered!.ToList();

    if (this.IsParameterBound(nameof(SystemPreferredAuthenticationMethods)))
        body.SystemPreferredAuthenticationMethods = SystemPreferredAuthenticationMethods!.ToList();

    if (this.IsParameterBound(nameof(UserDisplayName)))
        body.UserDisplayName = UserDisplayName;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(UserPreferredMethodForSecondaryAuthentication)))
        body.UserPreferredMethodForSecondaryAuthentication = UserPreferredMethodForSecondaryAuthentication;

    if (this.IsParameterBound(nameof(UserType)))
        body.UserType = UserType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.UserRegistrationDetails? result;
            try
            {
                result = client.Reports.AuthenticationMethods.UserRegistrationDetails[UserRegistrationDetailsId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, UserRegistrationDetailsId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.AuthenticationMethods.UserRegistrationDetails[UserRegistrationDetailsId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, UserRegistrationDetailsId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
