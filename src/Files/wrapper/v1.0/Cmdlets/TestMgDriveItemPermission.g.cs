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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/validatePermission")]
    [Cmdlet(VerbsDiagnostic.Test, "MgDriveItemPermission", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class TestMgDriveItemPermissionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ChallengeToken { get; set; }

        [Parameter(Mandatory = false)]
        public string? Password { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Test"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.ValidatePermission.ValidatePermissionPostRequestBody();

    if (this.IsParameterBound(nameof(ChallengeToken)))
        body.ChallengeToken = ChallengeToken;

    if (this.IsParameterBound(nameof(Password)))
        body.Password = Password;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Drives[DriveId].Items[DriveItemId].ValidatePermission.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DriveItemId);
                return;
            }

        }
    }
}
