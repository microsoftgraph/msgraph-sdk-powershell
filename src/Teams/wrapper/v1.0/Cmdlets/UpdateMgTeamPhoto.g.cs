#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("PATCH", "/teams/{team-id}/photo")]
    [Cmdlet(VerbsData.Update, "MgTeamPhoto", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.ProfilePhoto))]
    public class UpdateMgTeamPhotoCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? Height { get; set; }

        [Parameter(Mandatory = false)]
        public int? Width { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.ProfilePhoto();

    if (this.IsParameterBound(nameof(Height)))
        body.Height = Height;

    if (this.IsParameterBound(nameof(Width)))
        body.Width = Width;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.ProfilePhoto? result;
            try
            {
                result = client.Teams[TeamId].Photo.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TeamId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Teams[TeamId].Photo.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, TeamId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
