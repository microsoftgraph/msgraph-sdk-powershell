#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/teamwork/determineIfInteractionIsAllowed")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgTeamworkDetermineIfInteractionIsAllowed", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Teams.Client.Teamwork.DetermineIfInteractionIsAllowed.DetermineIfInteractionIsAllowedPostResponse))]
    public class InvokeMgTeamworkDetermineIfInteractionIsAllowedCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.Identity[]? Users { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkInteractionType? InteractionType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Teamwork.DetermineIfInteractionIsAllowed.DetermineIfInteractionIsAllowedPostRequestBody();

    if (this.IsParameterBound(nameof(Users)))
        body.Users = Users!.ToList();

    if (this.IsParameterBound(nameof(InteractionType)))
        body.InteractionType = InteractionType;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Teams.Client.Teamwork.DetermineIfInteractionIsAllowed.DetermineIfInteractionIsAllowedPostResponse? result;
            try
            {
                result = client.Teamwork.DetermineIfInteractionIsAllowed.PostAsDetermineIfInteractionIsAllowedPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
