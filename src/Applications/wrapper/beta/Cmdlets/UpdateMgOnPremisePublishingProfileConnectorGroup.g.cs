#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("PATCH", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/connectorGroups/{connectorGroup-id}")]
    [Cmdlet(VerbsData.Update, "MgOnPremisePublishingProfileConnectorGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.ConnectorGroup))]
    public class UpdateMgOnPremisePublishingProfileConnectorGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnPremisesPublishingProfileId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ConnectorGroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsDefault { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.ConnectorGroupType? ConnectorGroupType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.ConnectorGroupRegion? Region { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ConnectorGroupId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.ConnectorGroup();

    if (this.IsParameterBound(nameof(IsDefault)))
        body.IsDefault = IsDefault;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(ConnectorGroupType)))
        body.ConnectorGroupType = ConnectorGroupType;

    if (this.IsParameterBound(nameof(Region)))
        body.Region = Region;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.ConnectorGroup? result;
            try
            {
                result = client.OnPremisesPublishingProfiles[OnPremisesPublishingProfileId].ConnectorGroups[ConnectorGroupId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ConnectorGroupId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.OnPremisesPublishingProfiles[OnPremisesPublishingProfileId].ConnectorGroups[ConnectorGroupId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ConnectorGroupId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
