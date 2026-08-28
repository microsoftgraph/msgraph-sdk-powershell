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
    [GraphRoute("PATCH", "/communications/calls/{call-id}/operations/{commsOperation-id}")]
    [Cmdlet(VerbsData.Update, "MgCommunicationCallOperation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CommsOperation))]
    public class UpdateMgCommunicationCallOperationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CommsOperationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ClientContext { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ResultInfo? ResultInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.OperationStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CommsOperationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CommsOperation();

    if (this.IsParameterBound(nameof(ClientContext)))
        body.ClientContext = ClientContext;

    if (this.IsParameterBound(nameof(ResultInfo)))
        body.ResultInfo = ResultInfo;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.CommsOperation? result;
            try
            {
                result = client.Communications.Calls[CallId].Operations[CommsOperationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CommsOperationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Communications.Calls[CallId].Operations[CommsOperationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, CommsOperationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
