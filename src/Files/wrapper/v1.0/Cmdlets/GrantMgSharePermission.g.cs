#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("POST", "/shares/{sharedDriveItem-id}/permission/grant")]
    [Cmdlet(VerbsSecurity.Grant, "MgSharePermission", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Files.Client.Shares.Item.Permission.Grant.GrantPostResponse))]
    public class GrantMgSharePermissionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharedDriveItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Roles { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.DriveRecipient[]? Recipients { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SharedDriveItemId, "Grant"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Shares.Item.Permission.Grant.GrantPostRequestBody();

    if (this.IsParameterBound(nameof(Roles)))
        body.Roles = Roles!.ToList();
    if (this.IsParameterBound(nameof(Recipients)))
        body.Recipients = Recipients!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Files.Client.Shares.Item.Permission.Grant.GrantPostResponse? result;
            try
            {
                result = client.Shares[SharedDriveItemId].Permission.Grant.PostAsGrantPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, SharedDriveItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
