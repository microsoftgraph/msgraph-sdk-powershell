#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("PATCH", "/groups/{group-id}/extensions/{extension-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupExtension", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.Extension))]
    public class UpdateMgGroupExtensionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ExtensionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ExtensionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Groups.Client.Models.Extension();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.Extension? result;
            try
            {
                result = client.Groups[GroupId].Extensions[ExtensionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ExtensionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Extensions[ExtensionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
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
