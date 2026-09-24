#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("GET", "/deviceManagement/templates/{deviceManagementTemplate-id}/migratableTo/{deviceManagementTemplate-id1}/categories/{deviceManagementTemplateSettingCategory-id}/recommendedSettings/{deviceManagementSettingInstance-id}")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementTemplateMigratableToCategoryRecommendedSetting_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettingInstance))]
    public class GetMgDeviceManagementTemplateMigratableToCategoryRecommendedSetting_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementTemplateId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementTemplateId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DeviceManagementTemplateSettingCategoryId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string DeviceManagementSettingInstanceId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettingInstance? result;
            try
            {
                result = client.DeviceManagement.Templates[DeviceManagementTemplateId].MigratableTo[DeviceManagementTemplateId1].Categories[DeviceManagementTemplateSettingCategoryId].RecommendedSettings[DeviceManagementSettingInstanceId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementSettingInstanceId);
                return;
            }

            WriteObject(result);
        }
    }
}
