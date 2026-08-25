#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Actions.Client;
using Microsoft.Graph.PowerShell.Users.Actions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users.Actions
{
    [GraphRoute("POST", "/users/{user-id}/revokeSignInSessions")]
    [Cmdlet(VerbsSecurity.Revoke, "MgUserSignInSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.RevokeSignInSessions.RevokeSignInSessionsPostResponse))]
    public class RevokeMgUserSignInSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Revoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.RevokeSignInSessions.RevokeSignInSessionsPostResponse? result;
            try
            {
                result = client.Users[UserId].RevokeSignInSessions.PostAsRevokeSignInSessionsPostResponseAsync(requestConfiguration =>
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
