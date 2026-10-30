#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/informationProtection/sensitivityLabels/evaluate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgGroupSiteInformationProtectionSensitivityLabelEvaluate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.EvaluateLabelJobResponse))]
    public class InvokeMgGroupSiteInformationProtectionSensitivityLabelEvaluateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.DiscoveredSensitiveType[]? DiscoveredSensitiveTypes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.CurrentLabel? CurrentLabel { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SiteId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.Item.InformationProtection.SensitivityLabels.Evaluate.EvaluatePostRequestBody();

    if (this.IsParameterBound(nameof(DiscoveredSensitiveTypes)))
        body.DiscoveredSensitiveTypes = DiscoveredSensitiveTypes!.ToList();

    if (this.IsParameterBound(nameof(CurrentLabel)))
        body.CurrentLabel = CurrentLabel;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.EvaluateLabelJobResponse? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].InformationProtection.SensitivityLabels.Evaluate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SiteId);
                return;
            }

            WriteObject(result);
        }
    }
}
