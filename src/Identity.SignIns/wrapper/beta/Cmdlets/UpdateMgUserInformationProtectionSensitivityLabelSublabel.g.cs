#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PATCH", "/users/{user-id}/informationProtection/sensitivityLabels/{sensitivityLabel-id}/sublabels/{sensitivityLabel-id1}")]
    [Cmdlet(VerbsData.Update, "MgUserInformationProtectionSensitivityLabelSublabel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.SensitivityLabel))]
    public class UpdateMgUserInformationProtectionSensitivityLabelSublabelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SensitivityLabelId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SensitivityLabelId1 { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AutoTooltip { get; set; }

        [Parameter(Mandatory = false)]
        public string? Color { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasProtection { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDefault { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEndpointProtectionEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsScopedToUser { get; set; }

        [Parameter(Mandatory = false)]
        public string? Locale { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public int? Priority { get; set; }

        [Parameter(Mandatory = false)]
        public string? ToolTip { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.LabelActionSource? ActionSource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.SensitivityLabelTarget? ApplicableTo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ApplicationMode? ApplicationMode { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SensitivityLabelId1, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.SensitivityLabel();

    if (this.IsParameterBound(nameof(AutoTooltip)))
        body.AutoTooltip = AutoTooltip;

    if (this.IsParameterBound(nameof(Color)))
        body.Color = Color;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(HasProtection)))
        body.HasProtection = HasProtection;

    if (this.IsParameterBound(nameof(IsDefault)))
        body.IsDefault = IsDefault;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(IsEndpointProtectionEnabled)))
        body.IsEndpointProtectionEnabled = IsEndpointProtectionEnabled;

    if (this.IsParameterBound(nameof(IsScopedToUser)))
        body.IsScopedToUser = IsScopedToUser;

    if (this.IsParameterBound(nameof(Locale)))
        body.Locale = Locale;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Priority)))
        body.Priority = Priority;

    if (this.IsParameterBound(nameof(ToolTip)))
        body.ToolTip = ToolTip;

    if (this.IsParameterBound(nameof(ActionSource)))
        body.ActionSource = ActionSource;

    if (this.IsParameterBound(nameof(ApplicableTo)))
        body.ApplicableTo = ApplicableTo;

    if (this.IsParameterBound(nameof(ApplicationMode)))
        body.ApplicationMode = ApplicationMode;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.SensitivityLabel? result;
            try
            {
                result = client.Users[UserId].InformationProtection.SensitivityLabels[SensitivityLabelId].Sublabels[SensitivityLabelId1].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SensitivityLabelId1);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].InformationProtection.SensitivityLabels[SensitivityLabelId].Sublabels[SensitivityLabelId1].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SensitivityLabelId1);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
