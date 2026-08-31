#nullable enable

using System;
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
    [GraphRoute("GET", "/communications/calls/{call-id}/participants/{participant-id}")]
    [Cmdlet(VerbsCommon.Get, "MgCommunicationCallParticipant_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Participant))]
    public class GetMgCommunicationCallParticipant_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ParticipantId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Participant? result;
            try
            {
                result = client.Communications.Calls[CallId].Participants[ParticipantId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ParticipantId);
                return;
            }

            WriteObject(result);
        }
    }
}
