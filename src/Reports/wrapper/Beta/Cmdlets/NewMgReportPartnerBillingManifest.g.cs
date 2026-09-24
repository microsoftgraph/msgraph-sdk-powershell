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
    [GraphRoute("POST", "/reports/partners/billing/manifests")]
    [Cmdlet(VerbsCommon.New, "MgReportPartnerBillingManifest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.Manifest))]
    public class NewMgReportPartnerBillingManifestCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public int? BlobCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DataFormat { get; set; }

        [Parameter(Mandatory = false)]
        public string? ETag { get; set; }

        [Parameter(Mandatory = false)]
        public string? PartitionType { get; set; }

        [Parameter(Mandatory = false)]
        public string? PartnerTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RootDirectory { get; set; }

        [Parameter(Mandatory = false)]
        public string? SasToken { get; set; }

        [Parameter(Mandatory = false)]
        public string? SchemaVersion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.Blob[]? Blobs { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.Manifest();

    if (this.IsParameterBound(nameof(BlobCount)))
        body.BlobCount = BlobCount;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DataFormat)))
        body.DataFormat = DataFormat;

    if (this.IsParameterBound(nameof(ETag)))
        body.ETag = ETag;

    if (this.IsParameterBound(nameof(PartitionType)))
        body.PartitionType = PartitionType;

    if (this.IsParameterBound(nameof(PartnerTenantId)))
        body.PartnerTenantId = PartnerTenantId;

    if (this.IsParameterBound(nameof(RootDirectory)))
        body.RootDirectory = RootDirectory;

    if (this.IsParameterBound(nameof(SasToken)))
        body.SasToken = SasToken;

    if (this.IsParameterBound(nameof(SchemaVersion)))
        body.SchemaVersion = SchemaVersion;

    if (this.IsParameterBound(nameof(Blobs)))
        body.Blobs = Blobs!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.Partners.Billing.Manifest? result;
            try
            {
                result = client.Reports.Partners.Billing.Manifests.PostAsync(body, requestConfiguration =>
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
