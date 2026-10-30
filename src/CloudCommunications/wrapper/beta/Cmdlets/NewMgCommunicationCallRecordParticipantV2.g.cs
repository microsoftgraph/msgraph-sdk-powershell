#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("POST", "/communications/callRecords/{callRecord-id}/participants_v2")]
    [Cmdlet(VerbsCommon.New, "MgCommunicationCallRecordParticipantV2", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecords.Participant))]
    public class NewMgCommunicationCallRecordParticipantV2Command : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallRecordId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecords.AdministrativeUnitInfo[]? AdministrativeUnitInfos { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CommunicationsIdentitySet? Identity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallRecordId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecords.Participant();


    if (this.IsParameterBound(nameof(AdministrativeUnitInfos)))
        body.AdministrativeUnitInfos = AdministrativeUnitInfos!.ToList();

    if (this.IsParameterBound(nameof(Identity)))
        body.Identity = Identity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecords.Participant? result;
            try
            {
                result = client.Communications.CallRecords[CallRecordId].Participants_v2.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
