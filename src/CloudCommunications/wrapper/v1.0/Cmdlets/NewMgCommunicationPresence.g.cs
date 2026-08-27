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
    [GraphRoute("POST", "/communications/presences")]
    [Cmdlet(VerbsCommon.New, "MgCommunicationPresence", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Presence))]
    public class NewMgCommunicationPresenceCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Activity { get; set; }

        [Parameter(Mandatory = false)]
        public string? Availability { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.OutOfOfficeSettings? OutOfOfficeSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.PresenceStatusMessage? StatusMessage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.UserWorkLocation? WorkLocation { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Presence();

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;

    if (this.IsParameterBound(nameof(Availability)))
        body.Availability = Availability;

    if (this.IsParameterBound(nameof(OutOfOfficeSettings)))
        body.OutOfOfficeSettings = OutOfOfficeSettings;

    if (this.IsParameterBound(nameof(StatusMessage)))
        body.StatusMessage = StatusMessage;

    if (this.IsParameterBound(nameof(WorkLocation)))
        body.WorkLocation = WorkLocation;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Presence? result;
            try
            {
                result = client.Communications.Presences.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
