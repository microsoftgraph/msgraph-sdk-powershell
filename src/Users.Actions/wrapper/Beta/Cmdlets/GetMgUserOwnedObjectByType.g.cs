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
    [GraphRoute("POST", "/users/getUserOwnedObjects")]
    [Cmdlet(VerbsCommon.Get, "MgUserOwnedObjectByType", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Actions.Client.Models.DirectoryObject))]
    public class GetMgUserOwnedObjectByTypeCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.GetUserOwnedObjects.GetUserOwnedObjectsPostRequestBody();

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Actions.Client.Models.DirectoryObject? result;
            try
            {
                result = client.Users.GetUserOwnedObjects.PostAsync(body, requestConfiguration =>
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
