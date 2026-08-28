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
    [GraphRoute("PATCH", "/teamwork")]
    [Cmdlet(VerbsData.Update, "MgTeamwork", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.Teamwork))]
    public class UpdateMgTeamworkCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? IsTeamsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? Region { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.Teamwork();

    if (this.IsParameterBound(nameof(IsTeamsEnabled)))
        body.IsTeamsEnabled = IsTeamsEnabled;

    if (this.IsParameterBound(nameof(Region)))
        body.Region = Region;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.Teamwork? result;
            try
            {
                result = client.Teamwork.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Teamwork.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
