#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("GET", "/deviceManagement/macOSSoftwareUpdateAccountSummaries/{macOSSoftwareUpdateAccountSummary-id}/categorySummaries/{macOSSoftwareUpdateCategorySummary-id}/updateStateSummaries/{macOSSoftwareUpdateStateSummary-id}")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementMacOSSoftwareUpdateAccountSummaryCategorySummaryUpdateStateSummary_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MacOSSoftwareUpdateStateSummary))]
    public class GetMgDeviceManagementMacOSSoftwareUpdateAccountSummaryCategorySummaryUpdateStateSummary_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MacOSSoftwareUpdateAccountSummaryId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MacOSSoftwareUpdateCategorySummaryId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MacOSSoftwareUpdateStateSummaryId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MacOSSoftwareUpdateStateSummary? result;
            try
            {
                result = client.DeviceManagement.MacOSSoftwareUpdateAccountSummaries[MacOSSoftwareUpdateAccountSummaryId].CategorySummaries[MacOSSoftwareUpdateCategorySummaryId].UpdateStateSummaries[MacOSSoftwareUpdateStateSummaryId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MacOSSoftwareUpdateStateSummaryId);
                return;
            }

            WriteObject(result);
        }
    }
}
