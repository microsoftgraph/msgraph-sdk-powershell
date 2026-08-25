#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Notes.Client;
using Microsoft.Graph.PowerShell.Notes.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Notes
{
    [GraphRoute("PATCH", "/groups/{group-id}/onenote")]
    [Cmdlet(VerbsData.Update, "MgGroupOnenote", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.Onenote))]
    public class UpdateMgGroupOnenoteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Notes.Client.Models.Onenote();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Notes.Client.Models.Onenote? result;
            try
            {
                result = client.Groups[GroupId].Onenote.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Onenote.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, GroupId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
