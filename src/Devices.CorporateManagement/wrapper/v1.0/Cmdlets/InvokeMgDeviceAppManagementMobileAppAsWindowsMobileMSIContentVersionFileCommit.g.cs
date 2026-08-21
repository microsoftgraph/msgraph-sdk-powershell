#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/mobileApps/{mobileApp-id}/graph.windowsMobileMSI/contentVersions/{mobileAppContent-id}/files/{mobileAppContentFile-id}/commit")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceAppManagementMobileAppAsWindowsMobileMSIContentVersionFileCommit", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceAppManagementMobileAppAsWindowsMobileMSIContentVersionFileCommitCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MobileAppContentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MobileAppContentFileId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.FileEncryptionInfo? FileEncryptionInfo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppContentFileId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.MobileApps.Item.GraphWindowsMobileMSI.ContentVersions.Item.Files.Item.Commit.CommitPostRequestBody();

    if (this.IsParameterBound(nameof(FileEncryptionInfo)))
        body.FileEncryptionInfo = FileEncryptionInfo;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceAppManagement.MobileApps[MobileAppId].GraphWindowsMobileMSI.ContentVersions[MobileAppContentId].Files[MobileAppContentFileId].Commit.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, MobileAppContentFileId);
                return;
            }

        }
    }
}
