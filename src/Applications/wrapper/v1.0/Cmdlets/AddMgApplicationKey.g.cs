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
    [GraphRoute("POST", "/applications/{application-id}/addKey")]
    [Cmdlet(VerbsCommon.Add, "MgApplicationKey", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.KeyCredential))]
    public class AddMgApplicationKeyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Proof { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.KeyCredential? KeyCredential { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.PasswordCredential? PasswordCredential { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicationId, "Add"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.AddKey.AddKeyPostRequestBody();

    if (this.IsParameterBound(nameof(Proof)))
        body.Proof = Proof;
    if (this.IsParameterBound(nameof(KeyCredential)))
        body.KeyCredential = KeyCredential;

    if (this.IsParameterBound(nameof(PasswordCredential)))
        body.PasswordCredential = PasswordCredential;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.KeyCredential? result;
            try
            {
                result = client.Applications[ApplicationId].AddKey.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ApplicationId);
                return;
            }

            WriteObject(result);
        }
    }
}
