#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("PUT", "/groups/{group-id}/sites/{site-id}/onenote/resources/{onenoteResource-id}/content")]
    [Cmdlet(VerbsCommon.Set, "MgGroupSiteOnenoteResourceContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.OnenoteResource))]
    public class SetMgGroupSiteOnenoteResourceContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string OnenoteResourceId { get; set; } = string.Empty;

                [Parameter(Mandatory = true,
                    HelpMessage = "Path to the file whose contents are uploaded.")]
                public string InFile { get; set; } = string.Empty;






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnenoteResourceId, "Set"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.OnenoteResource? result;
            try
            {
                using var content = System.IO.File.OpenRead(InFile);
                result = client.Groups[GroupId].Sites[SiteId].Onenote.Resources[OnenoteResourceId].Content.PutAsync(content, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OnenoteResourceId);
                return;
            }

            WriteObject(result);
        }
    }
}
