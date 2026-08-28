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
    [GraphRoute("POST", "/solutions/virtualEvents/events/{virtualEvent-id}/publish")]
    [Cmdlet(VerbsData.Publish, "MgVirtualEvent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class PublishMgVirtualEventCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VirtualEventId, "Publish"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Solutions.VirtualEvents.Events[VirtualEventId].Publish.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, VirtualEventId);
                return;
            }

        }
    }
}
