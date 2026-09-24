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
    [GraphRoute("PATCH", "/deviceManagement/templates/{deviceManagementTemplate-id}/migratableTo/{deviceManagementTemplate-id1}/categories/{deviceManagementTemplateSettingCategory-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementTemplateMigratableToCategory", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementTemplateSettingCategory))]
    public class UpdateMgDeviceManagementTemplateMigratableToCategoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementTemplateId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementTemplateId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DeviceManagementTemplateSettingCategoryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasRequiredSetting { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementTemplateSettingCategoryId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementTemplateSettingCategory();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(HasRequiredSetting)))
        body.HasRequiredSetting = HasRequiredSetting;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementTemplateSettingCategory? result;
            try
            {
                result = client.DeviceManagement.Templates[DeviceManagementTemplateId].MigratableTo[DeviceManagementTemplateId1].Categories[DeviceManagementTemplateSettingCategoryId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementTemplateSettingCategoryId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.Templates[DeviceManagementTemplateId].MigratableTo[DeviceManagementTemplateId1].Categories[DeviceManagementTemplateSettingCategoryId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementTemplateSettingCategoryId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
