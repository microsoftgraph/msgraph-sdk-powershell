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
    [GraphRoute("POST", "/deviceAppManagement/mobileApps/{mobileApp-id}/graph.managedMobileLobApp/contentVersions")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementMobileAppAsManagedMobileLobAppContentVersion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContent))]
    public class NewMgDeviceAppManagementMobileAppAsManagedMobileLobAppContentVersionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContent();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContent? result;
            try
            {
                result = client.DeviceAppManagement.MobileApps[MobileAppId].GraphManagedMobileLobApp.ContentVersions.PostAsync(body, requestConfiguration =>
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
