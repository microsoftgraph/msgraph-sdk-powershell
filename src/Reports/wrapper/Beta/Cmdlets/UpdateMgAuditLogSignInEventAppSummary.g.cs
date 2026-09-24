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
    [GraphRoute("PATCH", "/auditLogs/signInEventsAppSummary/{signInEventsAppActivity-appId}")]
    [Cmdlet(VerbsData.Update, "MgAuditLogSignInEventAppSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.SignInEventsAppActivity))]
    public class UpdateMgAuditLogSignInEventAppSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SignInEventsAppActivityAppId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }

        [Parameter(Mandatory = false)]
        public int? SignInCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.Application? Application { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SignInEventsAppActivityAppId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.SignInEventsAppActivity();

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;

    if (this.IsParameterBound(nameof(SignInCount)))
        body.SignInCount = SignInCount;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(Application)))
        body.Application = Application;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.SignInEventsAppActivity? result;
            try
            {
                result = client.AuditLogs.SignInEventsAppSummary[SignInEventsAppActivityAppId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SignInEventsAppActivityAppId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.AuditLogs.SignInEventsAppSummary[SignInEventsAppActivityAppId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SignInEventsAppActivityAppId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
