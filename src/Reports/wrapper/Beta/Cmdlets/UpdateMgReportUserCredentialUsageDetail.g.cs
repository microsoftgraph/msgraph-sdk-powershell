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
    [GraphRoute("PATCH", "/reports/userCredentialUsageDetails/{userCredentialUsageDetails-id}")]
    [Cmdlet(VerbsData.Update, "MgReportUserCredentialUsageDetail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.UserCredentialUsageDetails))]
    public class UpdateMgReportUserCredentialUsageDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserCredentialUsageDetailsId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EventDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? FailureReason { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSuccess { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.UsageAuthMethod? AuthMethod { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.FeatureType? Feature { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserCredentialUsageDetailsId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.UserCredentialUsageDetails();

    if (this.IsParameterBound(nameof(EventDateTime)))
        body.EventDateTime = EventDateTime;

    if (this.IsParameterBound(nameof(FailureReason)))
        body.FailureReason = FailureReason;

    if (this.IsParameterBound(nameof(IsSuccess)))
        body.IsSuccess = IsSuccess;

    if (this.IsParameterBound(nameof(UserDisplayName)))
        body.UserDisplayName = UserDisplayName;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(AuthMethod)))
        body.AuthMethod = AuthMethod;

    if (this.IsParameterBound(nameof(Feature)))
        body.Feature = Feature;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.UserCredentialUsageDetails? result;
            try
            {
                result = client.Reports.UserCredentialUsageDetails[UserCredentialUsageDetailsId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserCredentialUsageDetailsId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.UserCredentialUsageDetails[UserCredentialUsageDetailsId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UserCredentialUsageDetailsId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
