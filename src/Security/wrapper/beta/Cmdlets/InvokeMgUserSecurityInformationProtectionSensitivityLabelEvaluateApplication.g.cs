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
    [GraphRoute("POST", "/users/{user-id}/security/informationProtection/sensitivityLabels/microsoft.graph.security.evaluateApplication")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserSecurityInformationProtectionSensitivityLabelEvaluateApplication", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Security.Client.Users.Item.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateApplication.EvaluateApplicationPostResponse))]
    public class InvokeMgUserSecurityInformationProtectionSensitivityLabelEvaluateApplicationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ContentInfo? ContentInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.LabelingOptions? LabelingOptions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Users.Item.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateApplication.EvaluateApplicationPostRequestBody();

    if (this.IsParameterBound(nameof(ContentInfo)))
        body.ContentInfo = ContentInfo;

    if (this.IsParameterBound(nameof(LabelingOptions)))
        body.LabelingOptions = LabelingOptions;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Security.Client.Users.Item.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateApplication.EvaluateApplicationPostResponse? result;
            try
            {
                result = client.Users[UserId].Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateApplication.PostAsEvaluateApplicationPostResponseAsync(body, requestConfiguration =>
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
