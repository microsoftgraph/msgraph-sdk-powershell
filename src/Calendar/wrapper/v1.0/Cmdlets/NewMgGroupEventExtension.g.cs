#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Calendar.Client;
using Microsoft.Graph.PowerShell.Calendar.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Calendar
{
    [GraphRoute("POST", "/groups/{group-id}/events/{event-id}/extensions")]
    [Cmdlet(VerbsCommon.New, "MgGroupEventExtension", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.Extension))]
    public class NewMgGroupEventExtensionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EventId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EventId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.Extension();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.Extension? result;
            try
            {
                result = client.Groups[GroupId].Events[EventId].Extensions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
