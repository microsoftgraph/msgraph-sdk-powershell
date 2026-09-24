#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/sensors")]
    [Cmdlet(VerbsCommon.New, "MgOnPremisePublishingProfileSensor", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.PrivateAccessSensor))]
    public class NewMgOnPremisePublishingProfileSensorCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnPremisesPublishingProfileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ExternalIp { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAuditMode { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsBreakglassEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? MachineName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.SensorStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnPremisesPublishingProfileId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.PrivateAccessSensor();

    if (this.IsParameterBound(nameof(ExternalIp)))
        body.ExternalIp = ExternalIp;

    if (this.IsParameterBound(nameof(IsAuditMode)))
        body.IsAuditMode = IsAuditMode;

    if (this.IsParameterBound(nameof(IsBreakglassEnabled)))
        body.IsBreakglassEnabled = IsBreakglassEnabled;

    if (this.IsParameterBound(nameof(MachineName)))
        body.MachineName = MachineName;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.PrivateAccessSensor? result;
            try
            {
                result = client.OnPremisesPublishingProfiles[OnPremisesPublishingProfileId].Sensors.PostAsync(body, requestConfiguration =>
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
