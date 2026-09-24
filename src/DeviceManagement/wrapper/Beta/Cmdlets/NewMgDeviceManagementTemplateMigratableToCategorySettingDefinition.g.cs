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
    [GraphRoute("POST", "/deviceManagement/templates/{deviceManagementTemplate-id}/migratableTo/{deviceManagementTemplate-id1}/categories/{deviceManagementTemplateSettingCategory-id}/settingDefinitions")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementTemplateMigratableToCategorySettingDefinition", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettingDefinition))]
    public class NewMgDeviceManagementTemplateMigratableToCategorySettingDefinitionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementTemplateId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementTemplateId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DeviceManagementTemplateSettingCategoryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DocumentationUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? HeaderSubtitle { get; set; }

        [Parameter(Mandatory = false)]
        public string? HeaderTitle { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsTopLevel { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Keywords { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlaceholderText { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConstraint[]? Constraints { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettingDependency[]? Dependencies { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManangementIntentValueType? ValueType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementTemplateSettingCategoryId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettingDefinition();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DocumentationUrl)))
        body.DocumentationUrl = DocumentationUrl;

    if (this.IsParameterBound(nameof(HeaderSubtitle)))
        body.HeaderSubtitle = HeaderSubtitle;

    if (this.IsParameterBound(nameof(HeaderTitle)))
        body.HeaderTitle = HeaderTitle;

    if (this.IsParameterBound(nameof(IsTopLevel)))
        body.IsTopLevel = IsTopLevel;

    if (this.IsParameterBound(nameof(Keywords)))
        body.Keywords = Keywords!.ToList();

    if (this.IsParameterBound(nameof(PlaceholderText)))
        body.PlaceholderText = PlaceholderText;

    if (this.IsParameterBound(nameof(Constraints)))
        body.Constraints = Constraints!.ToList();

    if (this.IsParameterBound(nameof(Dependencies)))
        body.Dependencies = Dependencies!.ToList();

    if (this.IsParameterBound(nameof(ValueType)))
        body.ValueType = ValueType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettingDefinition? result;
            try
            {
                result = client.DeviceManagement.Templates[DeviceManagementTemplateId].MigratableTo[DeviceManagementTemplateId1].Categories[DeviceManagementTemplateSettingCategoryId].SettingDefinitions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
