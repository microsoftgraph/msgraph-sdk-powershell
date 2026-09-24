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
    [GraphRoute("GET", "/deviceManagement/getSuggestedEnrollmentLimit(enrollmentType='{enrollmentType}')")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementGetSuggestedEnrollmentLimitWithEnrollmentType")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.Models.SuggestedEnrollmentLimit))]
    public class GetMgDeviceManagementGetSuggestedEnrollmentLimitWithEnrollmentTypeCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'enrollmentType' parameter of this OData function.")]
        public string EnrollmentType { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "enrollmentType", EnrollmentType },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.DeviceManagement.GetSuggestedEnrollmentLimitWithEnrollmentType.GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.Models.SuggestedEnrollmentLimit? result;
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
