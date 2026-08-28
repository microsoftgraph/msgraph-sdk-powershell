#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/users/{user-id}/onlineMeetings/{onlineMeeting-id}/getVirtualAppointmentJoinWebUrl()")]
    [Cmdlet(VerbsCommon.Get, "MgUserOnlineMeetingVirtualAppointmentJoinWebUrl")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Users.Item.OnlineMeetings.Item.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlGetResponse))]
    public class GetMgUserOnlineMeetingVirtualAppointmentJoinWebUrlCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnlineMeetingId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Users.Item.OnlineMeetings.Item.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlGetResponse? result;
            try
            {
                result = client.Users[UserId].OnlineMeetings[OnlineMeetingId].GetVirtualAppointmentJoinWebUrl.GetAsGetVirtualAppointmentJoinWebUrlGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, OnlineMeetingId);
                return;
            }

            WriteObject(result);
        }
    }
}
