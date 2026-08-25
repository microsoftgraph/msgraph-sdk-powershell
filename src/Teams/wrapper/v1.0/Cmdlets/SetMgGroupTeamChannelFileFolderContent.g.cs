#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("PUT", "/groups/{group-id}/team/channels/{channel-id}/filesFolder/content")]
    [Cmdlet(VerbsCommon.Set, "MgGroupTeamChannelFileFolderContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.DriveItem))]
    public class SetMgGroupTeamChannelFileFolderContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChannelId { get; set; } = string.Empty;

                [Parameter(Mandatory = true,
                    HelpMessage = "Path to the file whose contents are uploaded.")]
                public string InFile { get; set; } = string.Empty;






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChannelId, "Set"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.DriveItem? result;
            try
            {
                using var content = System.IO.File.OpenRead(InFile);
                result = client.Groups[GroupId].Team.Channels[ChannelId].FilesFolder.Content.PutAsync(content, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ChannelId);
                return;
            }

            WriteObject(result);
        }
    }
}
