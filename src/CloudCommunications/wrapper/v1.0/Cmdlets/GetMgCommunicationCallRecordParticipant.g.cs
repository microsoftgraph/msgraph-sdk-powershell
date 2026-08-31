#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("GET", "/communications/callRecords/{callRecord-id}/participants_v2/$count")]
    [Cmdlet(VerbsCommon.Get, "MgCommunicationCallRecordParticipant")]
    [OutputType(typeof(int))]
    public class GetMgCommunicationCallRecordParticipantCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallRecordId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.Communications.CallRecords[CallRecordId].Participants_v2.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CallRecordId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
