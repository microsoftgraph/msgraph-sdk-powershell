#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicy-id}/exemptAppLockerFiles/{windowsInformationProtectionAppLockerFile-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementWindowsInformationProtectionPolicyExemptAppLockerFile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionAppLockerFile))]
    public class UpdateMgDeviceAppManagementWindowsInformationProtectionPolicyExemptAppLockerFileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WindowsInformationProtectionPolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string WindowsInformationProtectionAppLockerFileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? File { get; set; }

        [Parameter(Mandatory = false)]
        public string? FileHash { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WindowsInformationProtectionAppLockerFileId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionAppLockerFile();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(File)))
        body.File = File;

    if (this.IsParameterBound(nameof(FileHash)))
        body.FileHash = FileHash;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionAppLockerFile? result;
            try
            {
                result = client.DeviceAppManagement.WindowsInformationProtectionPolicies[WindowsInformationProtectionPolicyId].ExemptAppLockerFiles[WindowsInformationProtectionAppLockerFileId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WindowsInformationProtectionAppLockerFileId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.WindowsInformationProtectionPolicies[WindowsInformationProtectionPolicyId].ExemptAppLockerFiles[WindowsInformationProtectionAppLockerFileId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WindowsInformationProtectionAppLockerFileId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
