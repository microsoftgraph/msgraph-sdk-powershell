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
    [GraphRoute("PATCH", "/reports/azureADPremiumLicenseInsight")]
    [Cmdlet(VerbsData.Update, "MgReportAzureADPremiumLicenseInsight", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.AzureADPremiumLicenseInsight))]
    public class UpdateMgReportAzureADPremiumLicenseInsightCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public long? EntitledP1LicenseCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? EntitledP2LicenseCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? EntitledTotalLicenseCount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.InternetAccessFeatureUtilizations? InternetAccessFeatureUtilizations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AzureADPremiumP1FeatureUtilizations? P1FeatureUtilizations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AzureADPremiumP2FeatureUtilizations? P2FeatureUtilizations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.PrivateAccessFeatureUtilizations? PrivateAccessFeatureUtilizations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.AzureADPremiumLicenseInsight();

    if (this.IsParameterBound(nameof(EntitledP1LicenseCount)))
        body.EntitledP1LicenseCount = EntitledP1LicenseCount;

    if (this.IsParameterBound(nameof(EntitledP2LicenseCount)))
        body.EntitledP2LicenseCount = EntitledP2LicenseCount;

    if (this.IsParameterBound(nameof(EntitledTotalLicenseCount)))
        body.EntitledTotalLicenseCount = EntitledTotalLicenseCount;

    if (this.IsParameterBound(nameof(InternetAccessFeatureUtilizations)))
        body.InternetAccessFeatureUtilizations = InternetAccessFeatureUtilizations;

    if (this.IsParameterBound(nameof(P1FeatureUtilizations)))
        body.P1FeatureUtilizations = P1FeatureUtilizations;

    if (this.IsParameterBound(nameof(P2FeatureUtilizations)))
        body.P2FeatureUtilizations = P2FeatureUtilizations;

    if (this.IsParameterBound(nameof(PrivateAccessFeatureUtilizations)))
        body.PrivateAccessFeatureUtilizations = PrivateAccessFeatureUtilizations;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.AzureADPremiumLicenseInsight? result;
            try
            {
                result = client.Reports.AzureADPremiumLicenseInsight.PatchAsync(body, requestConfiguration =>
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
                    result = client.Reports.AzureADPremiumLicenseInsight.GetAsync().GetAwaiter().GetResult();
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
