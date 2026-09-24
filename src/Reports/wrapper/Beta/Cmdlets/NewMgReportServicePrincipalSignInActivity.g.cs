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
    [GraphRoute("POST", "/reports/servicePrincipalSignInActivities")]
    [Cmdlet(VerbsCommon.New, "MgReportServicePrincipalSignInActivity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.ServicePrincipalSignInActivity))]
    public class NewMgReportServicePrincipalSignInActivityCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInActivity? ApplicationAuthenticationClientSignInActivity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInActivity? ApplicationAuthenticationResourceSignInActivity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInActivity? DelegatedClientSignInActivity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInActivity? DelegatedResourceSignInActivity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInActivity? LastSignInActivity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.ServicePrincipalSignInActivity();

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;

    if (this.IsParameterBound(nameof(ApplicationAuthenticationClientSignInActivity)))
        body.ApplicationAuthenticationClientSignInActivity = ApplicationAuthenticationClientSignInActivity;

    if (this.IsParameterBound(nameof(ApplicationAuthenticationResourceSignInActivity)))
        body.ApplicationAuthenticationResourceSignInActivity = ApplicationAuthenticationResourceSignInActivity;

    if (this.IsParameterBound(nameof(DelegatedClientSignInActivity)))
        body.DelegatedClientSignInActivity = DelegatedClientSignInActivity;

    if (this.IsParameterBound(nameof(DelegatedResourceSignInActivity)))
        body.DelegatedResourceSignInActivity = DelegatedResourceSignInActivity;

    if (this.IsParameterBound(nameof(LastSignInActivity)))
        body.LastSignInActivity = LastSignInActivity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.ServicePrincipalSignInActivity? result;
            try
            {
                result = client.Reports.ServicePrincipalSignInActivities.PostAsync(body, requestConfiguration =>
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
