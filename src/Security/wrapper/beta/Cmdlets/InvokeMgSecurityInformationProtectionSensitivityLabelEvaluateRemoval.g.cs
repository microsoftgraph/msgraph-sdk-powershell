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
    [GraphRoute("POST", "/security/informationProtection/sensitivityLabels/microsoft.graph.security.evaluateRemoval")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityInformationProtectionSensitivityLabelEvaluateRemoval", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Security.Client.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateRemoval.EvaluateRemovalPostResponse))]
    public class InvokeMgSecurityInformationProtectionSensitivityLabelEvaluateRemovalCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ContentInfo? ContentInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.DowngradeJustification? DowngradeJustification { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateRemoval.EvaluateRemovalPostRequestBody();

    if (this.IsParameterBound(nameof(ContentInfo)))
        body.ContentInfo = ContentInfo;

    if (this.IsParameterBound(nameof(DowngradeJustification)))
        body.DowngradeJustification = DowngradeJustification;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Security.Client.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateRemoval.EvaluateRemovalPostResponse? result;
            try
            {
                result = client.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateRemoval.PostAsEvaluateRemovalPostResponseAsync(body, requestConfiguration =>
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
