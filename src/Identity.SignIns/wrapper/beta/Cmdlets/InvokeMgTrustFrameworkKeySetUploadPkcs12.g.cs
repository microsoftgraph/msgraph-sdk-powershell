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
    [GraphRoute("POST", "/trustFramework/keySets/{trustFrameworkKeySet-id}/uploadPkcs12")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgTrustFrameworkKeySetUploadPkcs12", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TrustFrameworkKey))]
    public class InvokeMgTrustFrameworkKeySetUploadPkcs12Command : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TrustFrameworkKeySetId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Key { get; set; }

        [Parameter(Mandatory = false)]
        public string? Password { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TrustFrameworkKeySetId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.TrustFramework.KeySets.Item.UploadPkcs12.UploadPkcs12PostRequestBody();

    if (this.IsParameterBound(nameof(Key)))
        body.Key = Key;

    if (this.IsParameterBound(nameof(Password)))
        body.Password = Password;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TrustFrameworkKey? result;
            try
            {
                result = client.TrustFramework.KeySets[TrustFrameworkKeySetId].UploadPkcs12.PostAsync(body, requestConfiguration =>
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
