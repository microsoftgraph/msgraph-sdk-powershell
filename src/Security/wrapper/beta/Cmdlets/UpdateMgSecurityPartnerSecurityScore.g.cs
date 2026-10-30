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
    [GraphRoute("PATCH", "/security/partner/securityScore")]
    [Cmdlet(VerbsData.Update, "MgSecurityPartnerSecurityScore", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.PartnerSecurityScore))]
    public class UpdateMgSecurityPartnerSecurityScoreCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public float? CurrentScore { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastRefreshDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public float? MaxScore { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? UpdatedDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.PartnerSecurityScore();

    if (this.IsParameterBound(nameof(CurrentScore)))
        body.CurrentScore = CurrentScore;

    if (this.IsParameterBound(nameof(LastRefreshDateTime)))
        body.LastRefreshDateTime = LastRefreshDateTime;

    if (this.IsParameterBound(nameof(MaxScore)))
        body.MaxScore = MaxScore;

    if (this.IsParameterBound(nameof(UpdatedDateTime)))
        body.UpdatedDateTime = UpdatedDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.PartnerSecurityScore? result;
            try
            {
                result = client.Security.Partner.SecurityScore.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Partner.SecurityScore.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
