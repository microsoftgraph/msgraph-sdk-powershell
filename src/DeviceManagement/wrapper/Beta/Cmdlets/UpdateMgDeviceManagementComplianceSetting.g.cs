#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("PATCH", "/deviceManagement/complianceSettings/{deviceManagementConfigurationSettingDefinition-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementComplianceSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingDefinition))]
    public class UpdateMgDeviceManagementComplianceSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementConfigurationSettingDefinitionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? BaseUri { get; set; }

        [Parameter(Mandatory = false)]
        public string? CategoryId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? HelpText { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? InfoUrls { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Keywords { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? OffsetUri { get; set; }

        [Parameter(Mandatory = false)]
        public string? RootDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingAccessTypes? AccessTypes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingApplicability? Applicability { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingOccurrence? Occurrence { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationReferredSettingInformation[]? ReferredSettingInformationList { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingRiskLevel? RiskLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingUsage? SettingUsage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationControlType? UxBehavior { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingVisibility? Visibility { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementConfigurationSettingDefinitionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingDefinition();

    if (this.IsParameterBound(nameof(BaseUri)))
        body.BaseUri = BaseUri;

    if (this.IsParameterBound(nameof(CategoryId)))
        body.CategoryId = CategoryId;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(HelpText)))
        body.HelpText = HelpText;

    if (this.IsParameterBound(nameof(InfoUrls)))
        body.InfoUrls = InfoUrls!.ToList();

    if (this.IsParameterBound(nameof(Keywords)))
        body.Keywords = Keywords!.ToList();

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(OffsetUri)))
        body.OffsetUri = OffsetUri;

    if (this.IsParameterBound(nameof(RootDefinitionId)))
        body.RootDefinitionId = RootDefinitionId;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(AccessTypes)))
        body.AccessTypes = AccessTypes;

    if (this.IsParameterBound(nameof(Applicability)))
        body.Applicability = Applicability;

    if (this.IsParameterBound(nameof(Occurrence)))
        body.Occurrence = Occurrence;

    if (this.IsParameterBound(nameof(ReferredSettingInformationList)))
        body.ReferredSettingInformationList = ReferredSettingInformationList!.ToList();

    if (this.IsParameterBound(nameof(RiskLevel)))
        body.RiskLevel = RiskLevel;

    if (this.IsParameterBound(nameof(SettingUsage)))
        body.SettingUsage = SettingUsage;

    if (this.IsParameterBound(nameof(UxBehavior)))
        body.UxBehavior = UxBehavior;

    if (this.IsParameterBound(nameof(Visibility)))
        body.Visibility = Visibility;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingDefinition? result;
            try
            {
                result = client.DeviceManagement.ComplianceSettings[DeviceManagementConfigurationSettingDefinitionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementConfigurationSettingDefinitionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ComplianceSettings[DeviceManagementConfigurationSettingDefinitionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementConfigurationSettingDefinitionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
