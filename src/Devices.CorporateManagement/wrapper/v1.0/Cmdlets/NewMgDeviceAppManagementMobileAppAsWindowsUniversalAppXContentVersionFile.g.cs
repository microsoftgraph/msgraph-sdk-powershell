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
    [GraphRoute("POST", "/deviceAppManagement/mobileApps/{mobileApp-id}/graph.windowsUniversalAppX/contentVersions/{mobileAppContent-id}/files")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementMobileAppAsWindowsUniversalAppXContentVersionFile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentFile))]
    public class NewMgDeviceAppManagementMobileAppAsWindowsUniversalAppXContentVersionFileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MobileAppContentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsDependency { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Manifest { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public long? Size { get; set; }

        [Parameter(Mandatory = false)]
        public long? SizeEncrypted { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentFileUploadState? UploadState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppContentId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentFile();

    if (this.IsParameterBound(nameof(IsDependency)))
        body.IsDependency = IsDependency;

    if (this.IsParameterBound(nameof(Manifest)))
        body.Manifest = Manifest;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Size)))
        body.Size = Size;

    if (this.IsParameterBound(nameof(SizeEncrypted)))
        body.SizeEncrypted = SizeEncrypted;

    if (this.IsParameterBound(nameof(UploadState)))
        body.UploadState = UploadState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentFile? result;
            try
            {
                result = client.DeviceAppManagement.MobileApps[MobileAppId].GraphWindowsUniversalAppX.ContentVersions[MobileAppContentId].Files.PostAsync(body, requestConfiguration =>
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
