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
    [GraphRoute("PATCH", "/reports/healthMonitoring/alertConfigurations/{alertConfiguration-id}")]
    [Cmdlet(VerbsData.Update, "MgReportHealthMonitoringAlertConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.AlertConfiguration))]
    public class UpdateMgReportHealthMonitoringAlertConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AlertConfigurationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.EmailNotificationConfiguration[]? EmailNotificationConfigurations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AlertConfigurationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.AlertConfiguration();


    if (this.IsParameterBound(nameof(EmailNotificationConfigurations)))
        body.EmailNotificationConfigurations = EmailNotificationConfigurations!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.HealthMonitoring.AlertConfiguration? result;
            try
            {
                result = client.Reports.HealthMonitoring.AlertConfigurations[AlertConfigurationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AlertConfigurationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.HealthMonitoring.AlertConfigurations[AlertConfigurationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AlertConfigurationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
