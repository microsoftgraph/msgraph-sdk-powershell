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
    [GraphRoute("POST", "/security/dataSecurityAndGovernance/sensitivityLabels/evaluate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityDataSecurityAndGovernanceSensitivityLabelEvaluate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.EvaluateLabelJobResponse))]
    public class InvokeMgSecurityDataSecurityAndGovernanceSensitivityLabelEvaluateCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.DiscoveredSensitiveType[]? DiscoveredSensitiveTypes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.CurrentLabel? CurrentLabel { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.SensitivityLabels.Evaluate.EvaluatePostRequestBody();

    if (this.IsParameterBound(nameof(DiscoveredSensitiveTypes)))
        body.DiscoveredSensitiveTypes = DiscoveredSensitiveTypes!.ToList();

    if (this.IsParameterBound(nameof(CurrentLabel)))
        body.CurrentLabel = CurrentLabel;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.EvaluateLabelJobResponse? result;
            try
            {
                result = client.Security.DataSecurityAndGovernance.SensitivityLabels.Evaluate.PostAsync(body, requestConfiguration =>
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
