#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DirectoryObjects.Client;
using Microsoft.Graph.PowerShell.DirectoryObjects.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DirectoryObjects
{
    [GraphRoute("PATCH", "/directoryObjects/{directoryObject-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryObject", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DirectoryObjects.Client.Models.DirectoryObject))]
    public class UpdateMgDirectoryObjectCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DirectoryObjectId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DirectoryObjectId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DirectoryObjects.Client.Models.DirectoryObject();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DirectoryObjects.Client.Models.DirectoryObject? result;
            try
            {
                result = client.DirectoryObjects[DirectoryObjectId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DirectoryObjectId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DirectoryObjects[DirectoryObjectId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, DirectoryObjectId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
