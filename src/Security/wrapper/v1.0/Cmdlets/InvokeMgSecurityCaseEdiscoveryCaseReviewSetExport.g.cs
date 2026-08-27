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
    [GraphRoute("POST", "/security/cases/ediscoveryCases/{ediscoveryCase-id}/reviewSets/{ediscoveryReviewSet-id}/microsoft.graph.security.export")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityCaseEdiscoveryCaseReviewSetExport", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgSecurityCaseEdiscoveryCaseReviewSetExportCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EdiscoveryCaseId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EdiscoveryReviewSetId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? OutputName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ExportOptions? ExportOptions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ExportFileStructure? ExportStructure { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EdiscoveryReviewSetId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.Cases.EdiscoveryCases.Item.ReviewSets.Item.MicrosoftGraphSecurityExport.ExportPostRequestBody();

    if (this.IsParameterBound(nameof(OutputName)))
        body.OutputName = OutputName;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;
    if (this.IsParameterBound(nameof(ExportOptions)))
        body.ExportOptions = ExportOptions;

    if (this.IsParameterBound(nameof(ExportStructure)))
        body.ExportStructure = ExportStructure;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].ReviewSets[EdiscoveryReviewSetId].MicrosoftGraphSecurityExport.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, EdiscoveryReviewSetId);
                return;
            }

        }
    }
}
