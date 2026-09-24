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
    [GraphRoute("PATCH", "/reports/credentialUserRegistrationDetails/{credentialUserRegistrationDetails-id}")]
    [Cmdlet(VerbsData.Update, "MgReportCredentialUserRegistrationDetail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.CredentialUserRegistrationDetails))]
    public class UpdateMgReportCredentialUserRegistrationDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CredentialUserRegistrationDetailsId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsCapable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMfaRegistered { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRegistered { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.RegistrationAuthMethod?[]? AuthMethods { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CredentialUserRegistrationDetailsId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.CredentialUserRegistrationDetails();

    if (this.IsParameterBound(nameof(IsCapable)))
        body.IsCapable = IsCapable;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(IsMfaRegistered)))
        body.IsMfaRegistered = IsMfaRegistered;

    if (this.IsParameterBound(nameof(IsRegistered)))
        body.IsRegistered = IsRegistered;

    if (this.IsParameterBound(nameof(UserDisplayName)))
        body.UserDisplayName = UserDisplayName;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(AuthMethods)))
        body.AuthMethods = AuthMethods!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.CredentialUserRegistrationDetails? result;
            try
            {
                result = client.Reports.CredentialUserRegistrationDetails[CredentialUserRegistrationDetailsId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CredentialUserRegistrationDetailsId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.CredentialUserRegistrationDetails[CredentialUserRegistrationDetailsId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CredentialUserRegistrationDetailsId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
