#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("PATCH", "/groups/{group-id}/sites/{site-id}/informationProtection/sensitivityPolicySettings")]
    [Cmdlet(VerbsData.Update, "MgGroupSiteInformationProtectionSensitivityPolicySetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.SensitivityPolicySettings))]
    public class UpdateMgGroupSiteInformationProtectionSensitivityPolicySettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? DowngradeSensitivityRequiresJustification { get; set; }

        [Parameter(Mandatory = false)]
        public string? HelpWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMandatory { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.SensitivityLabelTarget? ApplicableTo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SiteId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.SensitivityPolicySettings();

    if (this.IsParameterBound(nameof(DowngradeSensitivityRequiresJustification)))
        body.DowngradeSensitivityRequiresJustification = DowngradeSensitivityRequiresJustification;

    if (this.IsParameterBound(nameof(HelpWebUrl)))
        body.HelpWebUrl = HelpWebUrl;

    if (this.IsParameterBound(nameof(IsMandatory)))
        body.IsMandatory = IsMandatory;

    if (this.IsParameterBound(nameof(ApplicableTo)))
        body.ApplicableTo = ApplicableTo;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.SensitivityPolicySettings? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].InformationProtection.SensitivityPolicySettings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SiteId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Sites[SiteId].InformationProtection.SensitivityPolicySettings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SiteId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
