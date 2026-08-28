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
    [GraphRoute("POST", "/applications/{application-id}/synchronization/templates/{synchronizationTemplate-id}/schema/parseExpression")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgParseApplicationSynchronizationTemplateSchemaExpression", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.ParseExpressionResponse))]
    public class InvokeMgParseApplicationSynchronizationTemplateSchemaExpressionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationTemplateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Expression { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.ExpressionInputObject? TestInputObject { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.AttributeDefinition? TargetAttributeDefinition { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SynchronizationTemplateId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.Synchronization.Templates.Item.Schema.ParseExpression.ParseExpressionPostRequestBody();

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
                result = client.Applications[ApplicationId].Synchronization.Templates[SynchronizationTemplateId].Schema.ParseExpression.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SynchronizationTemplateId);
                return;
            }

            WriteObject(result);
        }
    }
}
