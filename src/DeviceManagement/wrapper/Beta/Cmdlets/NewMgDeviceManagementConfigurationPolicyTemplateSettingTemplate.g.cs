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
    [GraphRoute("POST", "/deviceManagement/configurationPolicyTemplates/{deviceManagementConfigurationPolicyTemplate-id}/settingTemplates")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementConfigurationPolicyTemplateSettingTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingTemplate))]
    public class NewMgDeviceManagementConfigurationPolicyTemplateSettingTemplateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementConfigurationPolicyTemplateId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingInstanceTemplate? SettingInstanceTemplate { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementConfigurationPolicyTemplateId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingTemplate();


    if (this.IsParameterBound(nameof(SettingInstanceTemplate)))
        body.SettingInstanceTemplate = SettingInstanceTemplate;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingTemplate? result;
            try
            {
                result = client.DeviceManagement.ConfigurationPolicyTemplates[DeviceManagementConfigurationPolicyTemplateId].SettingTemplates.PostAsync(body, requestConfiguration =>
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
