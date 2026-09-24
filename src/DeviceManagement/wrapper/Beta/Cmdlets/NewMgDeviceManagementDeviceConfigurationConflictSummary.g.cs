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
    [GraphRoute("POST", "/deviceManagement/deviceConfigurationConflictSummary")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementDeviceConfigurationConflictSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationConflictSummary))]
    public class NewMgDeviceManagementDeviceConfigurationConflictSummaryCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? ContributingSettings { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeviceCheckinsImpacted { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SettingSource[]? ConflictingDeviceConfigurations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationConflictSummary();

    if (this.IsParameterBound(nameof(ContributingSettings)))
        body.ContributingSettings = ContributingSettings!.ToList();

    if (this.IsParameterBound(nameof(DeviceCheckinsImpacted)))
        body.DeviceCheckinsImpacted = DeviceCheckinsImpacted;

    if (this.IsParameterBound(nameof(ConflictingDeviceConfigurations)))
        body.ConflictingDeviceConfigurations = ConflictingDeviceConfigurations!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationConflictSummary? result;
            try
            {
                result = client.DeviceManagement.DeviceConfigurationConflictSummary.PostAsync(body, requestConfiguration =>
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
