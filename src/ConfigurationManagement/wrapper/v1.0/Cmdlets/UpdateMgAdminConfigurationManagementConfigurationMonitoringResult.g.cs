#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.ConfigurationManagement.Client;
using Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.ConfigurationManagement
{
    [GraphRoute("PATCH", "/admin/configurationManagement/configurationMonitoringResults/{configurationMonitoringResult-id}")]
    [Cmdlet(VerbsData.Update, "MgAdminConfigurationManagementConfigurationMonitoringResult", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationMonitoringResult))]
    public class UpdateMgAdminConfigurationManagementConfigurationMonitoringResultCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ConfigurationMonitoringResultId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.MonitorRunStatus? RunStatus { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ConfigurationMonitoringResultId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationMonitoringResult();


    if (this.IsParameterBound(nameof(RunStatus)))
        body.RunStatus = RunStatus;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationMonitoringResult? result;
            try
            {
                result = client.Admin.ConfigurationManagement.ConfigurationMonitoringResults[ConfigurationMonitoringResultId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ConfigurationMonitoringResultId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.ConfigurationManagement.ConfigurationMonitoringResults[ConfigurationMonitoringResultId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ConfigurationMonitoringResultId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
