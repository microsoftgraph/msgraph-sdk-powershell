#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("POST", "/users/{user-id}/followedSites/remove")]
    [Cmdlet(VerbsCommon.Remove, "MgUserFollowedSite", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Sites.Client.Users.Item.FollowedSites.Remove.RemovePostResponse))]
    public class RemoveMgUserFollowedSiteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.Site[]? Value { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Remove"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Users.Item.FollowedSites.Remove.RemovePostRequestBody();

    if (this.IsParameterBound(nameof(Value)))
        body.Value = Value!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Sites.Client.Users.Item.FollowedSites.Remove.RemovePostResponse? result;
            try
            {
                result = client.Users[UserId].FollowedSites.Remove.PostAsRemovePostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
