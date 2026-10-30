#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/directory/templates/deviceTemplates/{deviceTemplate-id}/createDeviceFromTemplate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDirectoryTemplateDeviceTemplateCreateDeviceFromTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Device))]
    public class InvokeMgDirectoryTemplateDeviceTemplateCreateDeviceFromTemplateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceTemplateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ExternalDeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OperatingSystemVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalSourceName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AccountEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? AlternativeNames { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.KeyCredential? KeyCredential { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceTemplateId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryNamespace.Templates.DeviceTemplates.Item.CreateDeviceFromTemplate.CreateDeviceFromTemplatePostRequestBody();

    if (this.IsParameterBound(nameof(ExternalDeviceId)))
        body.ExternalDeviceId = ExternalDeviceId;

    if (this.IsParameterBound(nameof(OperatingSystemVersion)))
        body.OperatingSystemVersion = OperatingSystemVersion;

    if (this.IsParameterBound(nameof(ExternalSourceName)))
        body.ExternalSourceName = ExternalSourceName;

    if (this.IsParameterBound(nameof(AccountEnabled)))
        body.AccountEnabled = AccountEnabled;

    if (this.IsParameterBound(nameof(AlternativeNames)))
        body.AlternativeNames = AlternativeNames!.ToList();
    if (this.IsParameterBound(nameof(KeyCredential)))
        body.KeyCredential = KeyCredential;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Device? result;
            try
            {
                result = client.Directory.Templates.DeviceTemplates[DeviceTemplateId].CreateDeviceFromTemplate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceTemplateId);
                return;
            }

            WriteObject(result);
        }
    }
}
