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
    [GraphRoute("POST", "/deviceManagement/androidForWorkAppConfigurationSchemas")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementAndroidForWorkAppConfigurationSchema", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidForWorkAppConfigurationSchema))]
    public class NewMgDeviceManagementAndroidForWorkAppConfigurationSchemaCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public byte[]? ExampleJson { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidForWorkAppConfigurationSchemaItem[]? SchemaItems { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
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
                result = client.DeviceManagement.AndroidForWorkAppConfigurationSchemas.PostAsync(body, requestConfiguration =>
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
