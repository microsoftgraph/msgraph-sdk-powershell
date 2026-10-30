#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/deviceAppManagement/mobileApps/convertFromMobileAppCatalogPackage(mobileAppCatalogPackageId='{mobileAppCatalogPackageId}')")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceAppManagementMobileAppConvertFromMobileAppCatalogPackageWithMobileAppCatalogPackageId")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileApp))]
    public class GetMgDeviceAppManagementMobileAppConvertFromMobileAppCatalogPackageWithMobileAppCatalogPackageIdCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'mobileAppCatalogPackageId' parameter of this OData function.")]
        public string MobileAppCatalogPackageId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "mobileAppCatalogPackageId", MobileAppCatalogPackageId },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.MobileApps.ConvertFromMobileAppCatalogPackageWithMobileAppCatalogPackageId.ConvertFromMobileAppCatalogPackageWithMobileAppCatalogPackageIdRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileApp? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
