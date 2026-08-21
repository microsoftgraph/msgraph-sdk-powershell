#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("GET", "/deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfiguration-id}/assignments/$count")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementDeviceEnrollmentConfigurationAssignmentCount")]
    [OutputType(typeof(int))]
    public class GetMgDeviceManagementDeviceEnrollmentConfigurationAssignmentCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceEnrollmentConfigurationId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.DeviceManagement.DeviceEnrollmentConfigurations[DeviceEnrollmentConfigurationId].Assignments.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DeviceEnrollmentConfigurationId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
