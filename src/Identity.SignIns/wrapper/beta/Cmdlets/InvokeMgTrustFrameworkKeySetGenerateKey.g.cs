#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/trustFramework/keySets/{trustFrameworkKeySet-id}/generateKey")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgTrustFrameworkKeySetGenerateKey", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TrustFrameworkKey))]
    public class InvokeMgTrustFrameworkKeySetGenerateKeyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TrustFrameworkKeySetId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Use { get; set; }

        [Parameter(Mandatory = false)]
        public string? Kty { get; set; }

        [Parameter(Mandatory = false)]
        public long? Nbf { get; set; }

        [Parameter(Mandatory = false)]
        public long? Exp { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TrustFrameworkKeySetId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.TrustFramework.KeySets.Item.GenerateKey.GenerateKeyPostRequestBody();

    if (this.IsParameterBound(nameof(Use)))
        body.Use = Use;

    if (this.IsParameterBound(nameof(Kty)))
        body.Kty = Kty;

    if (this.IsParameterBound(nameof(Nbf)))
        body.Nbf = Nbf;

    if (this.IsParameterBound(nameof(Exp)))
        body.Exp = Exp;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TrustFrameworkKey? result;
            try
            {
                result = client.TrustFramework.KeySets[TrustFrameworkKeySetId].GenerateKey.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TrustFrameworkKeySetId);
                return;
            }

            WriteObject(result);
        }
    }
}
