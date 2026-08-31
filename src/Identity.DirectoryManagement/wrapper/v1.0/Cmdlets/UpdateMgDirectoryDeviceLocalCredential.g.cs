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
    [GraphRoute("PATCH", "/directory/deviceLocalCredentials/{deviceLocalCredentialInfo-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryDeviceLocalCredential", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DeviceLocalCredentialInfo))]
    public class UpdateMgDirectoryDeviceLocalCredentialCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceLocalCredentialInfoId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastBackupDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RefreshDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DeviceLocalCredential[]? Credentials { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceLocalCredentialInfoId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DeviceLocalCredentialInfo();

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(LastBackupDateTime)))
        body.LastBackupDateTime = LastBackupDateTime;

    if (this.IsParameterBound(nameof(RefreshDateTime)))
        body.RefreshDateTime = RefreshDateTime;

    if (this.IsParameterBound(nameof(Credentials)))
        body.Credentials = Credentials!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DeviceLocalCredentialInfo? result;
            try
            {
                result = client.Directory.DeviceLocalCredentials[DeviceLocalCredentialInfoId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceLocalCredentialInfoId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.DeviceLocalCredentials[DeviceLocalCredentialInfoId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceLocalCredentialInfoId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
