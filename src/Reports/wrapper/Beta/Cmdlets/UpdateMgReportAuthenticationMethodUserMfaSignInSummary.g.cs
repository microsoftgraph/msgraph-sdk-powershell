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
    [GraphRoute("PATCH", "/reports/authenticationMethods/userMfaSignInSummary/{userMfaSignInSummary-id}")]
    [Cmdlet(VerbsData.Update, "MgReportAuthenticationMethodUserMfaSignInSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.UserMfaSignInSummary))]
    public class UpdateMgReportAuthenticationMethodUserMfaSignInSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserMfaSignInSummaryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public long? MultiFactorSignIns { get; set; }

        [Parameter(Mandatory = false)]
        public long? SingleFactorSignIns { get; set; }

        [Parameter(Mandatory = false)]
        public long? TotalSignIns { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserMfaSignInSummaryId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.UserMfaSignInSummary();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(MultiFactorSignIns)))
        body.MultiFactorSignIns = MultiFactorSignIns;

    if (this.IsParameterBound(nameof(SingleFactorSignIns)))
        body.SingleFactorSignIns = SingleFactorSignIns;

    if (this.IsParameterBound(nameof(TotalSignIns)))
        body.TotalSignIns = TotalSignIns;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.UserMfaSignInSummary? result;
            try
            {
                result = client.Reports.AuthenticationMethods.UserMfaSignInSummary[UserMfaSignInSummaryId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserMfaSignInSummaryId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.AuthenticationMethods.UserMfaSignInSummary[UserMfaSignInSummaryId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UserMfaSignInSummaryId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
