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
    [GraphRoute("POST", "/users/{user-id}/onlineMeetings/{onlineMeeting-id}/sendVirtualAppointmentSms")]
    [Cmdlet(VerbsCommunications.Send, "MgUserOnlineMeetingVirtualAppointmentSm", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SendMgUserOnlineMeetingVirtualAppointmentSmCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnlineMeetingId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.VirtualAppointmentMessageType? MessageType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AttendeeNotificationInfo[]? Attendees { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnlineMeetingId, "Send"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Users.Item.OnlineMeetings.Item.SendVirtualAppointmentSms.SendVirtualAppointmentSmsPostRequestBody();

    if (this.IsParameterBound(nameof(MessageType)))
        body.MessageType = MessageType;

    if (this.IsParameterBound(nameof(Attendees)))
        body.Attendees = Attendees!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].OnlineMeetings[OnlineMeetingId].SendVirtualAppointmentSms.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OnlineMeetingId);
                return;
            }

        }
    }
}
