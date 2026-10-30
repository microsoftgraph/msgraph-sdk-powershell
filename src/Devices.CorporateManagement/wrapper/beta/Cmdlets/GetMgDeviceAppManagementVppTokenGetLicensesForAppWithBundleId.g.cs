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
    [GraphRoute("GET", "/deviceAppManagement/vppTokens/getLicensesForApp(bundleId='{bundleId}')")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceAppManagementVppTokenGetLicensesForAppWithBundleId")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.VppTokens.GetLicensesForAppWithBundleId.GetLicensesForAppWithBundleIdGetResponse))]
    public class GetMgDeviceAppManagementVppTokenGetLicensesForAppWithBundleIdCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'bundleId' parameter of this OData function.")]
        public string BundleId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }

        [Parameter(Mandatory = false)]
        public int Top { get; set; }

        [Parameter(Mandatory = false)]
        public int Skip { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter Count { get; set; }




        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "bundleId", BundleId },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.VppTokens.GetLicensesForAppWithBundleId.GetLicensesForAppWithBundleIdRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.VppTokens.GetLicensesForAppWithBundleId.GetLicensesForAppWithBundleIdGetResponse? result;
            try
            {
                result = requestBuilder.GetAsGetLicensesForAppWithBundleIdGetResponseAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                    if (this.IsParameterBound(nameof(Top)))
                        requestConfiguration.QueryParameters.Top = Top;

                    if (this.IsParameterBound(nameof(Skip)))
                        requestConfiguration.QueryParameters.Skip = Skip;

                    if (Count.IsPresent)
                        requestConfiguration.QueryParameters.Count = true;

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
