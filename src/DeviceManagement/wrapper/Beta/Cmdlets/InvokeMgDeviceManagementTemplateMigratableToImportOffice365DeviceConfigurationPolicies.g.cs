#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/deviceManagement/templates/{deviceManagementTemplate-id}/migratableTo/importOffice365DeviceConfigurationPolicies")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementTemplateMigratableToImportOffice365DeviceConfigurationPolicies", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.Templates.Item.MigratableTo.ImportOffice365DeviceConfigurationPolicies.ImportOffice365DeviceConfigurationPoliciesPostResponse))]
    public class InvokeMgDeviceManagementTemplateMigratableToImportOffice365DeviceConfigurationPoliciesCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementTemplateId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementTemplateId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.Templates.Item.MigratableTo.ImportOffice365DeviceConfigurationPolicies.ImportOffice365DeviceConfigurationPoliciesPostResponse? result;
            try
            {
                result = client.DeviceManagement.Templates[DeviceManagementTemplateId].MigratableTo.ImportOffice365DeviceConfigurationPolicies.PostAsImportOffice365DeviceConfigurationPoliciesPostResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementTemplateId);
                return;
            }

            WriteObject(result);
        }
    }
}
