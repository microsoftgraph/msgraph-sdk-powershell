#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/identities/sensors/{sensor-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityIdentitySensor", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.Sensor))]
    public class UpdateMgSecurityIdentitySensorCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SensorId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DomainName { get; set; }

        [Parameter(Mandatory = false)]
        public long? OpenHealthIssuesCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.DeploymentStatus? DeploymentStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SensorHealthStatus? HealthStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SensorType? SensorType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ServiceStatus? ServiceStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SensorSettings? Settings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SensorId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.Sensor();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DomainName)))
        body.DomainName = DomainName;

    if (this.IsParameterBound(nameof(OpenHealthIssuesCount)))
        body.OpenHealthIssuesCount = OpenHealthIssuesCount;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(DeploymentStatus)))
        body.DeploymentStatus = DeploymentStatus;

    if (this.IsParameterBound(nameof(HealthStatus)))
        body.HealthStatus = HealthStatus;

    if (this.IsParameterBound(nameof(SensorType)))
        body.SensorType = SensorType;

    if (this.IsParameterBound(nameof(ServiceStatus)))
        body.ServiceStatus = ServiceStatus;

    if (this.IsParameterBound(nameof(Settings)))
        body.Settings = Settings;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.Sensor? result;
            try
            {
                result = client.Security.Identities.Sensors[SensorId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SensorId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Identities.Sensors[SensorId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, SensorId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
