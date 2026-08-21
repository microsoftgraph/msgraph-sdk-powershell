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
    [GraphRoute("POST", "/solutions/virtualEvents/webinars/{virtualEventWebinar-id}/registrationConfiguration/questions")]
    [Cmdlet(VerbsCommon.New, "MgVirtualEventWebinarRegistrationConfigurationQuestion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventRegistrationQuestionBase))]
    public class NewMgVirtualEventWebinarRegistrationConfigurationQuestionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventWebinarId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRequired { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VirtualEventWebinarId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventRegistrationQuestionBase();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsRequired)))
        body.IsRequired = IsRequired;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventRegistrationQuestionBase? result;
            try
            {
                result = client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].RegistrationConfiguration.Questions.PostAsync(body, requestConfiguration =>
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
