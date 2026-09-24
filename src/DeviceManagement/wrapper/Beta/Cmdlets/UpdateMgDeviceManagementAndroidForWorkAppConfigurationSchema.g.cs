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
    [GraphRoute("PATCH", "/deviceManagement/androidForWorkAppConfigurationSchemas/{androidForWorkAppConfigurationSchema-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementAndroidForWorkAppConfigurationSchema", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidForWorkAppConfigurationSchema))]
    public class UpdateMgDeviceManagementAndroidForWorkAppConfigurationSchemaCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AndroidForWorkAppConfigurationSchemaId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public byte[]? ExampleJson { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidForWorkAppConfigurationSchemaItem[]? SchemaItems { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AndroidForWorkAppConfigurationSchemaId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidForWorkAppConfigurationSchema();

    if (this.IsParameterBound(nameof(ExampleJson)))
        body.ExampleJson = ExampleJson;

    if (this.IsParameterBound(nameof(SchemaItems)))
        body.SchemaItems = SchemaItems!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidForWorkAppConfigurationSchema? result;
            try
            {
                result = client.DeviceManagement.AndroidForWorkAppConfigurationSchemas[AndroidForWorkAppConfigurationSchemaId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AndroidForWorkAppConfigurationSchemaId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.AndroidForWorkAppConfigurationSchemas[AndroidForWorkAppConfigurationSchemaId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AndroidForWorkAppConfigurationSchemaId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
