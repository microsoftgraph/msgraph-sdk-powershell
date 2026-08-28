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
    [GraphRoute("POST", "/deviceAppManagement/mdmWindowsInformationProtectionPolicies/{mdmWindowsInformationProtectionPolicy-id}/protectedAppLockerFiles")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementMdmWindowsInformationProtectionPolicyProtectedAppLockerFile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionAppLockerFile))]
    public class NewMgDeviceAppManagementMdmWindowsInformationProtectionPolicyProtectedAppLockerFileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MdmWindowsInformationProtectionPolicyId { get; set; } = string.Empty;

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
            if (!ShouldProcess(MdmWindowsInformationProtectionPolicyId, "New"))
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
                result = client.DeviceAppManagement.MdmWindowsInformationProtectionPolicies[MdmWindowsInformationProtectionPolicyId].ProtectedAppLockerFiles.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
