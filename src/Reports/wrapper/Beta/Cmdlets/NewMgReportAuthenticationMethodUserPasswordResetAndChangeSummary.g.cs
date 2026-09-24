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
    [GraphRoute("POST", "/reports/authenticationMethods/userPasswordResetsAndChangesSummary")]
    [Cmdlet(VerbsCommon.New, "MgReportAuthenticationMethodUserPasswordResetAndChangeSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.UserPasswordResetsAndChangesSummary))]
    public class NewMgReportAuthenticationMethodUserPasswordResetAndChangeSummaryCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AggregatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public long? ChangePasswordSelfServiceCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? PasswordResetsByAdminCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? PasswordResetsSelfServiceCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.UserPasswordResetsAndChangesSummary();

    if (this.IsParameterBound(nameof(AggregatedDateTime)))
        body.AggregatedDateTime = AggregatedDateTime;

    if (this.IsParameterBound(nameof(ChangePasswordSelfServiceCount)))
        body.ChangePasswordSelfServiceCount = ChangePasswordSelfServiceCount;

    if (this.IsParameterBound(nameof(PasswordResetsByAdminCount)))
        body.PasswordResetsByAdminCount = PasswordResetsByAdminCount;

    if (this.IsParameterBound(nameof(PasswordResetsSelfServiceCount)))
        body.PasswordResetsSelfServiceCount = PasswordResetsSelfServiceCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.UserPasswordResetsAndChangesSummary? result;
            try
            {
                result = client.Reports.AuthenticationMethods.UserPasswordResetsAndChangesSummary.PostAsync(body, requestConfiguration =>
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
