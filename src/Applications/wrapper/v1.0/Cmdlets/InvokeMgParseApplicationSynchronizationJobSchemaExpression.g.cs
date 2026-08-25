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
    [GraphRoute("POST", "/applications/{application-id}/synchronization/jobs/{synchronizationJob-id}/schema/parseExpression")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgParseApplicationSynchronizationJobSchemaExpression", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.ParseExpressionResponse))]
    public class InvokeMgParseApplicationSynchronizationJobSchemaExpressionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationJobId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Expression { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.ExpressionInputObject? TestInputObject { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.AttributeDefinition? TargetAttributeDefinition { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SynchronizationJobId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.Synchronization.Jobs.Item.Schema.ParseExpression.ParseExpressionPostRequestBody();

    if (this.IsParameterBound(nameof(Expression)))
        body.Expression = Expression;
    if (this.IsParameterBound(nameof(TestInputObject)))
        body.TestInputObject = TestInputObject;

    if (this.IsParameterBound(nameof(TargetAttributeDefinition)))
        body.TargetAttributeDefinition = TargetAttributeDefinition;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.ParseExpressionResponse? result;
            try
            {
                result = client.Applications[ApplicationId].Synchronization.Jobs[SynchronizationJobId].Schema.ParseExpression.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SynchronizationJobId);
                return;
            }

            WriteObject(result);
        }
    }
}
