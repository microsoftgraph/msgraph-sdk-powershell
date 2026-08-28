#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Functions
{
    [GraphRoute("GET", "/deviceManagement/verifyWindowsEnrollmentAutoDiscovery(domainName='{domainName}')")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementVerifyWindowsEnrollmentAutoDiscoveryWithDomainName")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName.VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameGetResponse))]
    public class GetMgDeviceManagementVerifyWindowsEnrollmentAutoDiscoveryWithDomainNameCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'domainName' parameter of this OData function.")]
        public string DomainName { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "domainName", DomainName },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName.VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName.VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameGetResponse? result;
            try
            {
                result = requestBuilder.GetAsVerifyWindowsEnrollmentAutoDiscoveryWithDomainNameGetResponseAsync(requestConfiguration =>
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
