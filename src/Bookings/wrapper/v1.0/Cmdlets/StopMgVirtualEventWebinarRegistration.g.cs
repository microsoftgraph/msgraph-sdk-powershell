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
    [GraphRoute("POST", "/solutions/virtualEvents/webinars/{virtualEventWebinar-id}/registrations/{virtualEventRegistration-id}/cancel")]
    [Cmdlet(VerbsLifecycle.Stop, "MgVirtualEventWebinarRegistration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class StopMgVirtualEventWebinarRegistrationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventWebinarId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string VirtualEventRegistrationId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VirtualEventRegistrationId, "Stop"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].Registrations[VirtualEventRegistrationId].Cancel.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, VirtualEventRegistrationId);
                return;
            }

        }
    }
}
