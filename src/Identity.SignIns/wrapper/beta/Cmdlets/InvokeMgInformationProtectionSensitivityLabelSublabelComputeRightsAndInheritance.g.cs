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
    [GraphRoute("POST", "/informationProtection/sensitivityLabels/{sensitivityLabel-id}/sublabels/computeRightsAndInheritance")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgInformationProtectionSensitivityLabelSublabelComputeRightsAndInheritance", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ComputeRightsAndInheritanceResult))]
    public class InvokeMgInformationProtectionSensitivityLabelSublabelComputeRightsAndInheritanceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SensitivityLabelId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DelegatedUserEmail { get; set; }

        [Parameter(Mandatory = false)]
        public string? Locale { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SupportedContentFormats { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ProtectedContent[]? ProtectedContents { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SensitivityLabelId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.InformationProtection.SensitivityLabels.Item.Sublabels.ComputeRightsAndInheritance.ComputeRightsAndInheritancePostRequestBody();

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

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ComputeRightsAndInheritanceResult? result;
            try
            {
                result = client.InformationProtection.SensitivityLabels[SensitivityLabelId].Sublabels.ComputeRightsAndInheritance.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SensitivityLabelId);
                return;
            }

            WriteObject(result);
        }
    }
}
