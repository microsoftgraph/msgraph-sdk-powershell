#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/directory/customSecurityAttributeDefinitions/{customSecurityAttributeDefinition-id}/allowedValues")]
    [Cmdlet(VerbsCommon.New, "MgDirectoryCustomSecurityAttributeDefinitionAllowedValue", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AllowedValue))]
    public class NewMgDirectoryCustomSecurityAttributeDefinitionAllowedValueCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CustomSecurityAttributeDefinitionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsActive { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomSecurityAttributeDefinitionId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AllowedValue();

    if (this.IsParameterBound(nameof(IsActive)))
        body.IsActive = IsActive;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AllowedValue? result;
            try
            {
                result = client.Directory.CustomSecurityAttributeDefinitions[CustomSecurityAttributeDefinitionId].AllowedValues.PostAsync(body, requestConfiguration =>
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
