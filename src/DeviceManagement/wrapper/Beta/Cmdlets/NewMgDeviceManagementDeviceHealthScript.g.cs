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
    [GraphRoute("POST", "/deviceManagement/deviceHealthScripts")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementDeviceHealthScript", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScript))]
    public class NewMgDeviceManagementDeviceHealthScriptCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? DetectionScriptContent { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? EnforceSignatureCheck { get; set; }

        [Parameter(Mandatory = false)]
        public string? HighestAvailableVersion { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsGlobalScript { get; set; }

        [Parameter(Mandatory = false)]
        public string? Publisher { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? RemediationScriptContent { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RunAs32Bit { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptParameter[]? DetectionScriptParameters { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptType? DeviceHealthScriptType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptParameter[]? RemediationScriptParameters { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.RunAsAccountType? RunAsAccount { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScript();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DetectionScriptContent)))
        body.DetectionScriptContent = DetectionScriptContent;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EnforceSignatureCheck)))
        body.EnforceSignatureCheck = EnforceSignatureCheck;

    if (this.IsParameterBound(nameof(HighestAvailableVersion)))
        body.HighestAvailableVersion = HighestAvailableVersion;

    if (this.IsParameterBound(nameof(IsGlobalScript)))
        body.IsGlobalScript = IsGlobalScript;

    if (this.IsParameterBound(nameof(Publisher)))
        body.Publisher = Publisher;

    if (this.IsParameterBound(nameof(RemediationScriptContent)))
        body.RemediationScriptContent = RemediationScriptContent;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(RunAs32Bit)))
        body.RunAs32Bit = RunAs32Bit;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(DetectionScriptParameters)))
        body.DetectionScriptParameters = DetectionScriptParameters!.ToList();

    if (this.IsParameterBound(nameof(DeviceHealthScriptType)))
        body.DeviceHealthScriptType = DeviceHealthScriptType;

    if (this.IsParameterBound(nameof(RemediationScriptParameters)))
        body.RemediationScriptParameters = RemediationScriptParameters!.ToList();

    if (this.IsParameterBound(nameof(RunAsAccount)))
        body.RunAsAccount = RunAsAccount;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScript? result;
            try
            {
                result = client.DeviceManagement.DeviceHealthScripts.PostAsync(body, requestConfiguration =>
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
