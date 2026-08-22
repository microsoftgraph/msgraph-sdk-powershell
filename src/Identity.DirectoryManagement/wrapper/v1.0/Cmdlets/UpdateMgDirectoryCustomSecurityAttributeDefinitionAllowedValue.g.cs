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
    [GraphRoute("PATCH", "/directory/customSecurityAttributeDefinitions/{customSecurityAttributeDefinition-id}/allowedValues/{allowedValue-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryCustomSecurityAttributeDefinitionAllowedValue", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AllowedValue))]
    public class UpdateMgDirectoryCustomSecurityAttributeDefinitionAllowedValueCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CustomSecurityAttributeDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AllowedValueId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsActive { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AllowedValueId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AllowedValue();

    if (this.IsParameterBound(nameof(IsActive)))
        body.IsActive = IsActive;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AllowedValue? result;
            try
            {
                result = client.Directory.CustomSecurityAttributeDefinitions[CustomSecurityAttributeDefinitionId].AllowedValues[AllowedValueId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AllowedValueId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.CustomSecurityAttributeDefinitions[CustomSecurityAttributeDefinitionId].AllowedValues[AllowedValueId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, AllowedValueId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
