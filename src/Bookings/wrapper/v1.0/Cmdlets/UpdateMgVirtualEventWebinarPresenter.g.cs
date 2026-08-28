#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Bookings.Client;
using Microsoft.Graph.PowerShell.Bookings.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Bookings
{
    [GraphRoute("PATCH", "/solutions/virtualEvents/webinars/{virtualEventWebinar-id}/presenters/{virtualEventPresenter-id}")]
    [Cmdlet(VerbsData.Update, "MgVirtualEventWebinarPresenter", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventPresenter))]
    public class UpdateMgVirtualEventWebinarPresenterCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventWebinarId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string VirtualEventPresenterId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Email { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.Identity? Identity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventPresenterDetails? PresenterDetails { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VirtualEventPresenterId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventPresenter();

    if (this.IsParameterBound(nameof(Email)))
        body.Email = Email;

    if (this.IsParameterBound(nameof(Identity)))
        body.Identity = Identity;

    if (this.IsParameterBound(nameof(PresenterDetails)))
        body.PresenterDetails = PresenterDetails;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventPresenter? result;
            try
            {
                result = client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].Presenters[VirtualEventPresenterId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, VirtualEventPresenterId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].Presenters[VirtualEventPresenterId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, VirtualEventPresenterId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
