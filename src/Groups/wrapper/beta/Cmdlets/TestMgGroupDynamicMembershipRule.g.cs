#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("POST", "/groups/evaluateDynamicMembership")]
    [Cmdlet(VerbsDiagnostic.Test, "MgGroupDynamicMembershipRule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.EvaluateDynamicMembershipResult))]
    public class TestMgGroupDynamicMembershipRuleCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? MemberId { get; set; }

        [Parameter(Mandatory = false)]
        public string? MembershipRule { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Test"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Groups.Client.Groups.EvaluateDynamicMembership.EvaluateDynamicMembershipPostRequestBody();

    if (this.IsParameterBound(nameof(MemberId)))
        body.MemberId = MemberId;

    if (this.IsParameterBound(nameof(MembershipRule)))
        body.MembershipRule = MembershipRule;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.EvaluateDynamicMembershipResult? result;
            try
            {
                result = client.Groups.EvaluateDynamicMembership.PostAsync(body, requestConfiguration =>
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
