#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/devices/{device-id}/commands/{command-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceCommand", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Command))]
    public class UpdateMgDeviceCommandCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CommandId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppServiceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Error { get; set; }

        [Parameter(Mandatory = false)]
        public string? PackageFamilyName { get; set; }

        [Parameter(Mandatory = false)]
        public string? PermissionTicket { get; set; }

        [Parameter(Mandatory = false)]
        public string? PostBackUri { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.PayloadRequest? Payload { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CommandId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Command();

    if (this.IsParameterBound(nameof(AppServiceName)))
        body.AppServiceName = AppServiceName;

    if (this.IsParameterBound(nameof(Error)))
        body.Error = Error;

    if (this.IsParameterBound(nameof(PackageFamilyName)))
        body.PackageFamilyName = PackageFamilyName;

    if (this.IsParameterBound(nameof(PermissionTicket)))
        body.PermissionTicket = PermissionTicket;

    if (this.IsParameterBound(nameof(PostBackUri)))
        body.PostBackUri = PostBackUri;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

    if (this.IsParameterBound(nameof(Payload)))
        body.Payload = Payload;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Command? result;
            try
            {
                result = client.Devices[DeviceId].Commands[CommandId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CommandId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Devices[DeviceId].Commands[CommandId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CommandId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
