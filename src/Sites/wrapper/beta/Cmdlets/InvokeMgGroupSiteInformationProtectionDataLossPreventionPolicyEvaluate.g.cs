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
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/informationProtection/dataLossPreventionPolicies/evaluate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgGroupSiteInformationProtectionDataLossPreventionPolicyEvaluate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.DlpEvaluatePoliciesJobResponse))]
    public class InvokeMgGroupSiteInformationProtectionDataLossPreventionPolicyEvaluateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Target { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.DlpEvaluationInput? EvaluationInput { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.DlpNotification? NotificationInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.TextClassificationRequest? ClassifyText { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SiteId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.Item.InformationProtection.DataLossPreventionPolicies.Evaluate.EvaluatePostRequestBody();

    if (this.IsParameterBound(nameof(Target)))
        body.Target = Target;
    if (this.IsParameterBound(nameof(EvaluationInput)))
        body.EvaluationInput = EvaluationInput;

    if (this.IsParameterBound(nameof(NotificationInfo)))
        body.NotificationInfo = NotificationInfo;

    if (this.IsParameterBound(nameof(ClassifyText)))
        body.ClassifyText = ClassifyText;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.DlpEvaluatePoliciesJobResponse? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].InformationProtection.DataLossPreventionPolicies.Evaluate.PostAsync(body, requestConfiguration =>
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
