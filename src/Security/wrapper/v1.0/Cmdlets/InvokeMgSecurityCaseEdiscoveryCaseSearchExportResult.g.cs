#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/cases/ediscoveryCases/{ediscoveryCase-id}/searches/{ediscoverySearch-id}/microsoft.graph.security.exportResult")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityCaseEdiscoveryCaseSearchExportResult", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgSecurityCaseEdiscoveryCaseSearchExportResultCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EdiscoveryCaseId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EdiscoverySearchId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ExportSingleItems { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ExportCriteria? ExportCriteria { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ExportLocation? ExportLocation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AdditionalOptions? AdditionalOptions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ExportFormat? ExportFormat { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.CloudAttachmentVersion? CloudAttachmentVersion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.DocumentVersion? DocumentVersion { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EdiscoverySearchId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.Cases.EdiscoveryCases.Item.Searches.Item.MicrosoftGraphSecurityExportResult.ExportResultPostRequestBody();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(ExportSingleItems)))
        body.ExportSingleItems = ExportSingleItems;
    if (this.IsParameterBound(nameof(ExportCriteria)))
        body.ExportCriteria = ExportCriteria;

    if (this.IsParameterBound(nameof(ExportLocation)))
        body.ExportLocation = ExportLocation;

    if (this.IsParameterBound(nameof(AdditionalOptions)))
        body.AdditionalOptions = AdditionalOptions;

    if (this.IsParameterBound(nameof(ExportFormat)))
        body.ExportFormat = ExportFormat;

    if (this.IsParameterBound(nameof(CloudAttachmentVersion)))
        body.CloudAttachmentVersion = CloudAttachmentVersion;

    if (this.IsParameterBound(nameof(DocumentVersion)))
        body.DocumentVersion = DocumentVersion;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].Searches[EdiscoverySearchId].MicrosoftGraphSecurityExportResult.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EdiscoverySearchId);
                return;
            }

        }
    }
}
