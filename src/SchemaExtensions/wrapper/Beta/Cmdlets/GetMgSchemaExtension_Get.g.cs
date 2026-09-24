#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.SchemaExtensions.Client;
using Microsoft.Graph.PowerShell.SchemaExtensions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.SchemaExtensions
{
    [GraphRoute("GET", "/schemaExtensions/{schemaExtension-id}")]
    [Cmdlet(VerbsCommon.Get, "MgSchemaExtension_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.SchemaExtensions.Client.Models.SchemaExtension))]
    public class GetMgSchemaExtension_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SchemaExtensionId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.SchemaExtensions.Client.Models.SchemaExtension? result;
            try
            {
                result = client.SchemaExtensions[SchemaExtensionId].GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, SchemaExtensionId);
                return;
            }

            WriteObject(result);
        }
    }
}
