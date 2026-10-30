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
    [GraphRoute("POST", "/security/informationProtection/sensitivityLabels/microsoft.graph.security.evaluateApplication")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityInformationProtectionSensitivityLabelEvaluateApplication", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Security.Client.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateApplication.EvaluateApplicationPostResponse))]
    public class InvokeMgSecurityInformationProtectionSensitivityLabelEvaluateApplicationCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ContentInfo? ContentInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.LabelingOptions? LabelingOptions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateApplication.EvaluateApplicationPostRequestBody();

    if (this.IsParameterBound(nameof(ContentInfo)))
        body.ContentInfo = ContentInfo;

    if (this.IsParameterBound(nameof(LabelingOptions)))
        body.LabelingOptions = LabelingOptions;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Security.Client.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateApplication.EvaluateApplicationPostResponse? result;
            try
            {
                result = client.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateApplication.PostAsEvaluateApplicationPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
