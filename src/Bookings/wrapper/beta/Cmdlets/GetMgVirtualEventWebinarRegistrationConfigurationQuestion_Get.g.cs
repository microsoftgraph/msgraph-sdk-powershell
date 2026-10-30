#nullable enable

using System;
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
    [GraphRoute("GET", "/solutions/virtualEvents/webinars/{virtualEventWebinar-id}/registrationConfiguration/questions/{virtualEventRegistrationQuestionBase-id}")]
    [Cmdlet(VerbsCommon.Get, "MgVirtualEventWebinarRegistrationConfigurationQuestion_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventRegistrationQuestionBase))]
    public class GetMgVirtualEventWebinarRegistrationConfigurationQuestion_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventWebinarId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string VirtualEventRegistrationQuestionBaseId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventRegistrationQuestionBase? result;
            try
            {
                result = client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].RegistrationConfiguration.Questions[VirtualEventRegistrationQuestionBaseId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, VirtualEventRegistrationQuestionBaseId);
                return;
            }

            WriteObject(result);
        }
    }
}
