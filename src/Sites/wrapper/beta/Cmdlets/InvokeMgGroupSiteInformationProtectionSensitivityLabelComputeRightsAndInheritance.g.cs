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
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/informationProtection/sensitivityLabels/computeRightsAndInheritance")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgGroupSiteInformationProtectionSensitivityLabelComputeRightsAndInheritance", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ComputeRightsAndInheritanceResult))]
    public class InvokeMgGroupSiteInformationProtectionSensitivityLabelComputeRightsAndInheritanceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DelegatedUserEmail { get; set; }

        [Parameter(Mandatory = false)]
        public string? Locale { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SupportedContentFormats { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ProtectedContent[]? ProtectedContents { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SiteId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.Item.InformationProtection.SensitivityLabels.ComputeRightsAndInheritance.ComputeRightsAndInheritancePostRequestBody();

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

            Microsoft.Graph.PowerShell.Sites.Client.Models.ComputeRightsAndInheritanceResult? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].InformationProtection.SensitivityLabels.ComputeRightsAndInheritance.PostAsync(body, requestConfiguration =>
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
