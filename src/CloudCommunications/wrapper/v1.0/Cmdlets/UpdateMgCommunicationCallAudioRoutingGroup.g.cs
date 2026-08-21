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
    [GraphRoute("PATCH", "/communications/calls/{call-id}/audioRoutingGroups/{audioRoutingGroup-id}")]
    [Cmdlet(VerbsData.Update, "MgCommunicationCallAudioRoutingGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AudioRoutingGroup))]
    public class UpdateMgCommunicationCallAudioRoutingGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AudioRoutingGroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Receivers { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Sources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.RoutingMode? RoutingMode { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AudioRoutingGroupId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AudioRoutingGroup();

    if (this.IsParameterBound(nameof(Receivers)))
        body.Receivers = Receivers!.ToList();

    if (this.IsParameterBound(nameof(Sources)))
        body.Sources = Sources!.ToList();

    if (this.IsParameterBound(nameof(RoutingMode)))
        body.RoutingMode = RoutingMode;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AudioRoutingGroup? result;
            try
            {
                result = client.Communications.Calls[CallId].AudioRoutingGroups[AudioRoutingGroupId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AudioRoutingGroupId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Communications.Calls[CallId].AudioRoutingGroups[AudioRoutingGroupId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, AudioRoutingGroupId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
