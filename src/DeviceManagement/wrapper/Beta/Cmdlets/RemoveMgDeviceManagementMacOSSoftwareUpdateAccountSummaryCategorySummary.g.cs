#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("DELETE", "/deviceManagement/macOSSoftwareUpdateAccountSummaries/{macOSSoftwareUpdateAccountSummary-id}/categorySummaries/{macOSSoftwareUpdateCategorySummary-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgDeviceManagementMacOSSoftwareUpdateAccountSummaryCategorySummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgDeviceManagementMacOSSoftwareUpdateAccountSummaryCategorySummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MacOSSoftwareUpdateAccountSummaryId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MacOSSoftwareUpdateCategorySummaryId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MacOSSoftwareUpdateCategorySummaryId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.DeviceManagement.MacOSSoftwareUpdateAccountSummaries[MacOSSoftwareUpdateAccountSummaryId].CategorySummaries[MacOSSoftwareUpdateCategorySummaryId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MacOSSoftwareUpdateCategorySummaryId);
                return;
            }
        }
    }
}
