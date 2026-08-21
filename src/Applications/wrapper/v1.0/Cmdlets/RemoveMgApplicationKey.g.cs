#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/applications/{application-id}/removeKey")]
    [Cmdlet(VerbsCommon.Remove, "MgApplicationKey", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RemoveMgApplicationKeyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.Guid? KeyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Proof { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicationId, "Remove"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.RemoveKey.RemoveKeyPostRequestBody();

    if (this.IsParameterBound(nameof(KeyId)))
        body.KeyId = KeyId;

    if (this.IsParameterBound(nameof(Proof)))
        body.Proof = Proof;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Applications[ApplicationId].RemoveKey.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ApplicationId);
                return;
            }

        }
    }
}
