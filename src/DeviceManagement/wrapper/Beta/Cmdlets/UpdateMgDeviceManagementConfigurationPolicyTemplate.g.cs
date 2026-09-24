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
    [GraphRoute("PATCH", "/deviceManagement/configurationPolicyTemplates/{deviceManagementConfigurationPolicyTemplate-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementConfigurationPolicyTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationPolicyTemplate))]
    public class UpdateMgDeviceManagementConfigurationPolicyTemplateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementConfigurationPolicyTemplateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? AllowUnmanagedSettings { get; set; }

        [Parameter(Mandatory = false)]
        public string? BaseId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DisableEntraGroupPolicyAssignment { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayVersion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementTemplateLifecycleState? LifecycleState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationPlatforms? Platforms { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationTechnologies? Technologies { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationTemplateFamily? TemplateFamily { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementConfigurationPolicyTemplateId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationPolicyTemplate();

    if (this.IsParameterBound(nameof(AllowUnmanagedSettings)))
        body.AllowUnmanagedSettings = AllowUnmanagedSettings;

    if (this.IsParameterBound(nameof(BaseId)))
        body.BaseId = BaseId;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisableEntraGroupPolicyAssignment)))
        body.DisableEntraGroupPolicyAssignment = DisableEntraGroupPolicyAssignment;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DisplayVersion)))
        body.DisplayVersion = DisplayVersion;

    if (this.IsParameterBound(nameof(LifecycleState)))
        body.LifecycleState = LifecycleState;

    if (this.IsParameterBound(nameof(Platforms)))
        body.Platforms = Platforms;

    if (this.IsParameterBound(nameof(Technologies)))
        body.Technologies = Technologies;

    if (this.IsParameterBound(nameof(TemplateFamily)))
        body.TemplateFamily = TemplateFamily;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationPolicyTemplate? result;
            try
            {
                result = client.DeviceManagement.ConfigurationPolicyTemplates[DeviceManagementConfigurationPolicyTemplateId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementConfigurationPolicyTemplateId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ConfigurationPolicyTemplates[DeviceManagementConfigurationPolicyTemplateId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementConfigurationPolicyTemplateId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
