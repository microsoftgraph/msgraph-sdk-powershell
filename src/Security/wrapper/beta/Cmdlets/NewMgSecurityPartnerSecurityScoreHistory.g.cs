#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/partner/securityScore/history")]
    [Cmdlet(VerbsCommon.New, "MgSecurityPartnerSecurityScoreHistory", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityScoreHistory))]
    public class NewMgSecurityPartnerSecurityScoreHistoryCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public long? CompliantRequirementsCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public float? Score { get; set; }

        [Parameter(Mandatory = false)]
        public long? TotalRequirementsCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityScoreHistory();

    if (this.IsParameterBound(nameof(CompliantRequirementsCount)))
        body.CompliantRequirementsCount = CompliantRequirementsCount;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Score)))
        body.Score = Score;

    if (this.IsParameterBound(nameof(TotalRequirementsCount)))
        body.TotalRequirementsCount = TotalRequirementsCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityScoreHistory? result;
            try
            {
                result = client.Security.Partner.SecurityScore.History.PostAsync(body, requestConfiguration =>
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
