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
    [GraphRoute("POST", "/communications/onlineMeetings/{onlineMeeting-id}/sendVirtualAppointmentSms")]
    [Cmdlet(VerbsCommunications.Send, "MgCommunicationOnlineMeetingVirtualAppointmentSm", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SendMgCommunicationOnlineMeetingVirtualAppointmentSmCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnlineMeetingId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.VirtualAppointmentMessageType? MessageType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.AttendeeNotificationInfo[]? Attendees { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnlineMeetingId, "Send"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.OnlineMeetings.Item.SendVirtualAppointmentSms.SendVirtualAppointmentSmsPostRequestBody();

    if (this.IsParameterBound(nameof(MessageType)))
        body.MessageType = MessageType;

    if (this.IsParameterBound(nameof(Attendees)))
        body.Attendees = Attendees!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Communications.OnlineMeetings[OnlineMeetingId].SendVirtualAppointmentSms.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, OnlineMeetingId);
                return;
            }

        }
    }
}
