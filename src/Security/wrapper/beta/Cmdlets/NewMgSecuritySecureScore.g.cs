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
    [GraphRoute("POST", "/security/secureScores")]
    [Cmdlet(VerbsCommon.New, "MgSecuritySecureScore", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.SecureScore))]
    public class NewMgSecuritySecureScoreCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public int? ActiveUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? AzureTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public double? CurrentScore { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? EnabledServices { get; set; }

        [Parameter(Mandatory = false)]
        public int? LicensedUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public double? MaxScore { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AverageComparativeScore[]? AverageComparativeScores { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.ControlScore[]? ControlScores { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SecurityVendorInformation? VendorInformation { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.SecureScore();

    if (this.IsParameterBound(nameof(ActiveUserCount)))
        body.ActiveUserCount = ActiveUserCount;

    if (this.IsParameterBound(nameof(AzureTenantId)))
        body.AzureTenantId = AzureTenantId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CurrentScore)))
        body.CurrentScore = CurrentScore;

    if (this.IsParameterBound(nameof(EnabledServices)))
        body.EnabledServices = EnabledServices!.ToList();

    if (this.IsParameterBound(nameof(LicensedUserCount)))
        body.LicensedUserCount = LicensedUserCount;

    if (this.IsParameterBound(nameof(MaxScore)))
        body.MaxScore = MaxScore;

    if (this.IsParameterBound(nameof(AverageComparativeScores)))
        body.AverageComparativeScores = AverageComparativeScores!.ToList();

    if (this.IsParameterBound(nameof(ControlScores)))
        body.ControlScores = ControlScores!.ToList();

    if (this.IsParameterBound(nameof(VendorInformation)))
        body.VendorInformation = VendorInformation;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.SecureScore? result;
            try
            {
                result = client.Security.SecureScores.PostAsync(body, requestConfiguration =>
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
