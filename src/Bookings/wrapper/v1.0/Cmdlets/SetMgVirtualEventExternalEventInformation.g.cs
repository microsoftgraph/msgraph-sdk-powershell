#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Bookings.Client;
using Microsoft.Graph.PowerShell.Bookings.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Bookings
{
    [GraphRoute("POST", "/solutions/virtualEvents/events/{virtualEvent-id}/setExternalEventInformation")]
    [Cmdlet(VerbsCommon.Set, "MgVirtualEventExternalEventInformation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgVirtualEventExternalEventInformationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ExternalEventId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VirtualEventId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Bookings.Client.Solutions.VirtualEvents.Events.Item.SetExternalEventInformation.SetExternalEventInformationPostRequestBody();

    if (this.IsParameterBound(nameof(ExternalEventId)))
        body.ExternalEventId = ExternalEventId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Solutions.VirtualEvents.Events[VirtualEventId].SetExternalEventInformation.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, VirtualEventId);
                return;
            }

        }
    }
}
