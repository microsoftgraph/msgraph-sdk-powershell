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
    [GraphRoute("POST", "/reports/userInsights/monthly/mfaRegisteredUsers")]
    [Cmdlet(VerbsCommon.New, "MgReportUserInsightMonthlyMfaRegisteredUser", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.MfaUserCountMetric))]
    public class NewMgReportUserInsightMonthlyMfaRegisteredUserCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public long? Count { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? FactDate { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.MfaType? MfaType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.MfaUserCountMetric();

    if (this.IsParameterBound(nameof(Count)))
        body.Count = Count;

    if (this.IsParameterBound(nameof(FactDate)))
        body.FactDate = FactDate;

    if (this.IsParameterBound(nameof(MfaType)))
        body.MfaType = MfaType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.MfaUserCountMetric? result;
            try
            {
                result = client.Reports.UserInsights.Monthly.MfaRegisteredUsers.PostAsync(body, requestConfiguration =>
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
