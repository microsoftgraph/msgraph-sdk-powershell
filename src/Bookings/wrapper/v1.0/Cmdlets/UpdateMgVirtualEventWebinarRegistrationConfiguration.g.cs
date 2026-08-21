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
    [GraphRoute("PATCH", "/solutions/virtualEvents/webinars/{virtualEventWebinar-id}/registrationConfiguration")]
    [Cmdlet(VerbsData.Update, "MgVirtualEventWebinarRegistrationConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventWebinarRegistrationConfiguration))]
    public class UpdateMgVirtualEventWebinarRegistrationConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventWebinarId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? Capacity { get; set; }

        [Parameter(Mandatory = false)]
        public string? RegistrationWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsManualApprovalEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsWaitlistEnabled { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VirtualEventWebinarId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventWebinarRegistrationConfiguration();

    if (this.IsParameterBound(nameof(Capacity)))
        body.Capacity = Capacity;

    if (this.IsParameterBound(nameof(RegistrationWebUrl)))
        body.RegistrationWebUrl = RegistrationWebUrl;

    if (this.IsParameterBound(nameof(IsManualApprovalEnabled)))
        body.IsManualApprovalEnabled = IsManualApprovalEnabled;

    if (this.IsParameterBound(nameof(IsWaitlistEnabled)))
        body.IsWaitlistEnabled = IsWaitlistEnabled;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventWebinarRegistrationConfiguration? result;
            try
            {
                result = client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].RegistrationConfiguration.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, VirtualEventWebinarId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].RegistrationConfiguration.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, VirtualEventWebinarId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
