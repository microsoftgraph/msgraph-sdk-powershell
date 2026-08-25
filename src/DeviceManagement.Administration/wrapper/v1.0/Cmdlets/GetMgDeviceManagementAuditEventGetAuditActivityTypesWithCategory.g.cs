#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("GET", "/deviceManagement/auditEvents/getAuditActivityTypes(category='{category}')")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementAuditEventGetAuditActivityTypesWithCategory")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.DeviceManagement.AuditEvents.GetAuditActivityTypesWithCategory.GetAuditActivityTypesWithCategoryGetResponse))]
    public class GetMgDeviceManagementAuditEventGetAuditActivityTypesWithCategoryCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'category' parameter of this OData function.")]
        public string Category { get; set; } = string.Empty;



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
            { "category", Category },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.DeviceManagement.AuditEvents.GetAuditActivityTypesWithCategory.GetAuditActivityTypesWithCategoryRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.DeviceManagement.AuditEvents.GetAuditActivityTypesWithCategory.GetAuditActivityTypesWithCategoryGetResponse? result;
            try
            {
                result = requestBuilder.GetAsGetAuditActivityTypesWithCategoryGetResponseAsync(requestConfiguration =>
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
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
