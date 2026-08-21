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
    [GraphRoute("PATCH", "/communications/callRecords/{callRecord-id}/organizer_v2")]
    [Cmdlet(VerbsData.Update, "MgCommunicationCallRecordOrganizerV2", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecords.Organizer))]
    public class UpdateMgCommunicationCallRecordOrganizerV2Command : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallRecordId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecords.AdministrativeUnitInfo[]? AdministrativeUnitInfos { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CommunicationsIdentitySet? Identity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallRecordId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecords.Organizer();


    if (this.IsParameterBound(nameof(AdministrativeUnitInfos)))
        body.AdministrativeUnitInfos = AdministrativeUnitInfos!.ToList();

    if (this.IsParameterBound(nameof(Identity)))
        body.Identity = Identity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CallRecords.Organizer? result;
            try
            {
                result = client.Communications.CallRecords[CallRecordId].Organizer_v2.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, CallRecordId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Communications.CallRecords[CallRecordId].Organizer_v2.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, CallRecordId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
