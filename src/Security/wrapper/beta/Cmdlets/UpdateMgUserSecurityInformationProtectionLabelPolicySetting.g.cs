#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/users/{user-id}/security/informationProtection/labelPolicySettings")]
    [Cmdlet(VerbsData.Update, "MgUserSecurityInformationProtectionLabelPolicySetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.InformationProtectionPolicySetting))]
    public class UpdateMgUserSecurityInformationProtectionLabelPolicySettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DefaultLabelId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDowngradeJustificationRequired { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMandatory { get; set; }

        [Parameter(Mandatory = false)]
        public string? MoreInfoUrl { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.InformationProtectionPolicySetting();

    if (this.IsParameterBound(nameof(DefaultLabelId)))
        body.DefaultLabelId = DefaultLabelId;

    if (this.IsParameterBound(nameof(IsDowngradeJustificationRequired)))
        body.IsDowngradeJustificationRequired = IsDowngradeJustificationRequired;

    if (this.IsParameterBound(nameof(IsMandatory)))
        body.IsMandatory = IsMandatory;

    if (this.IsParameterBound(nameof(MoreInfoUrl)))
        body.MoreInfoUrl = MoreInfoUrl;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.InformationProtectionPolicySetting? result;
            try
            {
                result = client.Users[UserId].Security.InformationProtection.LabelPolicySettings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Security.InformationProtection.LabelPolicySettings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UserId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
