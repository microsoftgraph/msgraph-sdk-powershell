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
    [GraphRoute("POST", "/informationProtection/sensitivityLabels/evaluate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgInformationProtectionSensitivityLabelEvaluate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.EvaluateLabelJobResponse))]
    public class InvokeMgInformationProtectionSensitivityLabelEvaluateCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DiscoveredSensitiveType[]? DiscoveredSensitiveTypes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CurrentLabel? CurrentLabel { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.InformationProtection.SensitivityLabels.Evaluate.EvaluatePostRequestBody();

    if (this.IsParameterBound(nameof(DiscoveredSensitiveTypes)))
        body.DiscoveredSensitiveTypes = DiscoveredSensitiveTypes!.ToList();

    if (this.IsParameterBound(nameof(CurrentLabel)))
        body.CurrentLabel = CurrentLabel;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.EvaluateLabelJobResponse? result;
            try
            {
                result = client.InformationProtection.SensitivityLabels.Evaluate.PostAsync(body, requestConfiguration =>
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
