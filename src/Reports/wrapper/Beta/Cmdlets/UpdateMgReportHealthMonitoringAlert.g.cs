#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("PATCH", "/reports/healthMonitoring/alerts/{alert-id}")]
    [Cmdlet(VerbsData.Update, "MgReportHealthMonitoringAlert", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.Alert))]
    public class UpdateMgReportHealthMonitoringAlertCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AlertId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.AlertType? AlertType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.Category? Category { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.Documentation? Documentation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.Enrichment? Enrichment { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.Scenario? Scenario { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.Signals? Signals { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.AlertState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AlertId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.Alert();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(AlertType)))
        body.AlertType = AlertType;

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(Documentation)))
        body.Documentation = Documentation;

    if (this.IsParameterBound(nameof(Enrichment)))
        body.Enrichment = Enrichment;

    if (this.IsParameterBound(nameof(Scenario)))
        body.Scenario = Scenario;

    if (this.IsParameterBound(nameof(Signals)))
        body.Signals = Signals;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.Alert? result;
            try
            {
                result = client.Reports.HealthMonitoring.Alerts[AlertId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AlertId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.HealthMonitoring.Alerts[AlertId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AlertId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
