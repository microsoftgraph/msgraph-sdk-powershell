#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/macOSSoftwareUpdateAccountSummaries/{macOSSoftwareUpdateAccountSummary-id}/categorySummaries/{macOSSoftwareUpdateCategorySummary-id}/updateStateSummaries")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementMacOSSoftwareUpdateAccountSummaryCategorySummaryUpdateStateSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MacOSSoftwareUpdateStateSummary))]
    public class NewMgDeviceManagementMacOSSoftwareUpdateAccountSummaryCategorySummaryUpdateStateSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MacOSSoftwareUpdateAccountSummaryId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MacOSSoftwareUpdateCategorySummaryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ProductKey { get; set; }

        [Parameter(Mandatory = false)]
        public string? UpdateVersion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MacOSSoftwareUpdateState? State { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MacOSSoftwareUpdateCategory? UpdateCategory { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MacOSSoftwareUpdateCategorySummaryId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MacOSSoftwareUpdateStateSummary();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(ProductKey)))
        body.ProductKey = ProductKey;

    if (this.IsParameterBound(nameof(UpdateVersion)))
        body.UpdateVersion = UpdateVersion;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;

    if (this.IsParameterBound(nameof(UpdateCategory)))
        body.UpdateCategory = UpdateCategory;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MacOSSoftwareUpdateStateSummary? result;
            try
            {
                result = client.DeviceManagement.MacOSSoftwareUpdateAccountSummaries[MacOSSoftwareUpdateAccountSummaryId].CategorySummaries[MacOSSoftwareUpdateCategorySummaryId].UpdateStateSummaries.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
