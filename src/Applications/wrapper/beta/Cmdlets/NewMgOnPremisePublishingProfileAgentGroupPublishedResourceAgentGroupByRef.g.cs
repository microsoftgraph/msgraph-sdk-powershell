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
    [GraphRoute("POST", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups/{onPremisesAgentGroup-id}/publishedResources/{publishedResource-id}/agentGroups/$ref")]
    [Cmdlet(VerbsCommon.New, "MgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRef", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class NewMgOnPremisePublishingProfileAgentGroupPublishedResourceAgentGroupByRefCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnPremisesPublishingProfileId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnPremisesAgentGroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PublishedResourceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? OdataId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PublishedResourceId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.ReferenceCreate();

    if (this.IsParameterBound(nameof(OdataId)))
        body.OdataId = OdataId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.OnPremisesPublishingProfiles[OnPremisesPublishingProfileId].AgentGroups[OnPremisesAgentGroupId].PublishedResources[PublishedResourceId].AgentGroups.Ref.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PublishedResourceId);
                return;
            }

        }
    }
}
