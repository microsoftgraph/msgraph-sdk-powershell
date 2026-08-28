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
    [GraphRoute("POST", "/deviceAppManagement/mobileApps/{mobileApp-id}/graph.macOSLobApp/contentVersions/{mobileAppContent-id}/containedApps")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementMobileAppAsMacOSLobAppContentVersionContainedApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileContainedApp))]
    public class NewMgDeviceAppManagementMobileAppAsMacOSLobAppContentVersionContainedAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MobileAppContentId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppContentId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileContainedApp();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileContainedApp? result;
            try
            {
                result = client.DeviceAppManagement.MobileApps[MobileAppId].GraphMacOSLobApp.ContentVersions[MobileAppContentId].ContainedApps.PostAsync(body, requestConfiguration =>
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
