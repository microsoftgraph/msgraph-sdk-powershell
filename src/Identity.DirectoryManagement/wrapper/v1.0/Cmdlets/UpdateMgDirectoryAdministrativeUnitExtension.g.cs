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
    [GraphRoute("PATCH", "/directory/administrativeUnits/{administrativeUnit-id}/extensions/{extension-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryAdministrativeUnitExtension", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Extension))]
    public class UpdateMgDirectoryAdministrativeUnitExtensionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AdministrativeUnitId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ExtensionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ExtensionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Extension();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Extension? result;
            try
            {
                result = client.Directory.AdministrativeUnits[AdministrativeUnitId].Extensions[ExtensionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ExtensionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.AdministrativeUnits[AdministrativeUnitId].Extensions[ExtensionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ExtensionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
