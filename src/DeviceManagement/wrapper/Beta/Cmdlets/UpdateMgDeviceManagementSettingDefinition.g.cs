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
    [GraphRoute("PATCH", "/deviceManagement/settingDefinitions/{deviceManagementSettingDefinition-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementSettingDefinition", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettingDefinition))]
    public class UpdateMgDeviceManagementSettingDefinitionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementSettingDefinitionId { get; set; } = string.Empty;

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
            if (!ShouldProcess(DeviceManagementSettingDefinitionId, "Update"))
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
                result = client.DeviceManagement.SettingDefinitions[DeviceManagementSettingDefinitionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementSettingDefinitionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.SettingDefinitions[DeviceManagementSettingDefinitionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementSettingDefinitionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
