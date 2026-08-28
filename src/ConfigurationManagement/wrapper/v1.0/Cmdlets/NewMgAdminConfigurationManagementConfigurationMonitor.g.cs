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
    [GraphRoute("POST", "/admin/configurationManagement/configurationMonitors")]
    [Cmdlet(VerbsCommon.New, "MgAdminConfigurationManagementConfigurationMonitor", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationMonitor))]
    public class NewMgAdminConfigurationManagementConfigurationMonitorCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.MonitorMode? Mode { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.OpenComplexDictionaryType? Parameters { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.MonitorStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationBaseline? Baseline { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationMonitor();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(Mode)))
        body.Mode = Mode;

    if (this.IsParameterBound(nameof(Parameters)))
        body.Parameters = Parameters;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Baseline)))
        body.Baseline = Baseline;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationMonitor? result;
            try
            {
                result = client.Admin.ConfigurationManagement.ConfigurationMonitors.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
