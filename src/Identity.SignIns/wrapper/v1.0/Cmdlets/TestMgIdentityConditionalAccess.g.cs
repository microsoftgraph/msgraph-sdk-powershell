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
    [GraphRoute("POST", "/identity/conditionalAccess/evaluate")]
    [Cmdlet(VerbsDiagnostic.Test, "MgIdentityConditionalAccess", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Identity.ConditionalAccess.Evaluate.EvaluatePostResponse))]
    public class TestMgIdentityConditionalAccessCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? AppliedPoliciesOnly { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.SignInIdentity? SignInIdentity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.SignInContext? SignInContext { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.SignInConditions? SignInConditions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Test"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Identity.ConditionalAccess.Evaluate.EvaluatePostRequestBody();

    if (this.IsParameterBound(nameof(AppliedPoliciesOnly)))
        body.AppliedPoliciesOnly = AppliedPoliciesOnly;
    if (this.IsParameterBound(nameof(SignInIdentity)))
        body.SignInIdentity = SignInIdentity;

    if (this.IsParameterBound(nameof(SignInContext)))
        body.SignInContext = SignInContext;

    if (this.IsParameterBound(nameof(SignInConditions)))
        body.SignInConditions = SignInConditions;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Identity.ConditionalAccess.Evaluate.EvaluatePostResponse? result;
            try
            {
                result = client.Identity.ConditionalAccess.Evaluate.PostAsEvaluatePostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
