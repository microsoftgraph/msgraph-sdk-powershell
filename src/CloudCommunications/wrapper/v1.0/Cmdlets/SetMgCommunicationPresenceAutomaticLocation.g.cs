#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("POST", "/communications/presences/{presence-id}/setAutomaticLocation")]
    [Cmdlet(VerbsCommon.Set, "MgCommunicationPresenceAutomaticLocation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgCommunicationPresenceAutomaticLocationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PresenceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? PlaceId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.WorkLocationType? WorkLocationType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PresenceId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.Presences.Item.SetAutomaticLocation.SetAutomaticLocationPostRequestBody();

    if (this.IsParameterBound(nameof(PlaceId)))
        body.PlaceId = PlaceId;
    if (this.IsParameterBound(nameof(WorkLocationType)))
        body.WorkLocationType = WorkLocationType;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Communications.Presences[PresenceId].SetAutomaticLocation.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PresenceId);
                return;
            }

        }
    }
}
