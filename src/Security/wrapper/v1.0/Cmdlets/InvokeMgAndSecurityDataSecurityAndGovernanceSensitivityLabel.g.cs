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
    [GraphRoute("POST", "/security/dataSecurityAndGovernance/sensitivityLabels/computeRightsAndInheritance")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgAndSecurityDataSecurityAndGovernanceSensitivityLabel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.ComputeRightsAndInheritanceResult))]
    public class InvokeMgAndSecurityDataSecurityAndGovernanceSensitivityLabelCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? DelegatedUserEmail { get; set; }

        [Parameter(Mandatory = false)]
        public string? Locale { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SupportedContentFormats { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.ProtectedContent[]? ProtectedContents { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.SensitivityLabels.ComputeRightsAndInheritance.ComputeRightsAndInheritancePostRequestBody();

    if (this.IsParameterBound(nameof(DelegatedUserEmail)))
        body.DelegatedUserEmail = DelegatedUserEmail;

    if (this.IsParameterBound(nameof(Locale)))
        body.Locale = Locale;

    if (this.IsParameterBound(nameof(SupportedContentFormats)))
        body.SupportedContentFormats = SupportedContentFormats!.ToList();
    if (this.IsParameterBound(nameof(ProtectedContents)))
        body.ProtectedContents = ProtectedContents!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.ComputeRightsAndInheritanceResult? result;
            try
            {
                result = client.Security.DataSecurityAndGovernance.SensitivityLabels.ComputeRightsAndInheritance.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
