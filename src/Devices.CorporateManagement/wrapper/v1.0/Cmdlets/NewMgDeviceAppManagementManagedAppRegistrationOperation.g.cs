#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/managedAppRegistrations/{managedAppRegistration-id}/operations")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementManagedAppRegistrationOperation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppOperation))]
    public class NewMgDeviceAppManagementManagedAppRegistrationOperationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedAppRegistrationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? State { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedAppRegistrationId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppOperation();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppOperation? result;
            try
            {
                result = client.DeviceAppManagement.ManagedAppRegistrations[ManagedAppRegistrationId].Operations.PostAsync(body, requestConfiguration =>
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
