#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/users/{user-id}/informationProtection/dataLossPreventionPolicies/evaluate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserInformationProtectionDataLossPreventionPolicyEvaluate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DlpEvaluatePoliciesJobResponse))]
    public class InvokeMgUserInformationProtectionDataLossPreventionPolicyEvaluateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Target { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DlpEvaluationInput? EvaluationInput { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DlpNotification? NotificationInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TextClassificationRequest? ClassifyText { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Users.Item.InformationProtection.DataLossPreventionPolicies.Evaluate.EvaluatePostRequestBody();

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

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DlpEvaluatePoliciesJobResponse? result;
            try
            {
                result = client.Users[UserId].InformationProtection.DataLossPreventionPolicies.Evaluate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
