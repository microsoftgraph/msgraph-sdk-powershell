#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/directory/templates/deviceTemplates/{deviceTemplate-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryTemplateDeviceTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DeviceTemplate))]
    public class UpdateMgDirectoryTemplateDeviceTemplateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceTemplateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceAuthority { get; set; }

        [Parameter(Mandatory = false)]
        public string? Manufacturer { get; set; }

        [Parameter(Mandatory = false)]
        public string? Model { get; set; }

        [Parameter(Mandatory = false)]
        public string? MutualTlsOauthConfigurationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? MutualTlsOauthConfigurationTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OperatingSystem { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceTemplateId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DeviceTemplate();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(DeviceAuthority)))
        body.DeviceAuthority = DeviceAuthority;

    if (this.IsParameterBound(nameof(Manufacturer)))
        body.Manufacturer = Manufacturer;

    if (this.IsParameterBound(nameof(Model)))
        body.Model = Model;

    if (this.IsParameterBound(nameof(MutualTlsOauthConfigurationId)))
        body.MutualTlsOauthConfigurationId = MutualTlsOauthConfigurationId;

    if (this.IsParameterBound(nameof(MutualTlsOauthConfigurationTenantId)))
        body.MutualTlsOauthConfigurationTenantId = MutualTlsOauthConfigurationTenantId;

    if (this.IsParameterBound(nameof(OperatingSystem)))
        body.OperatingSystem = OperatingSystem;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.DeviceTemplate? result;
            try
            {
                result = client.Directory.Templates.DeviceTemplates[DeviceTemplateId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceTemplateId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.Templates.DeviceTemplates[DeviceTemplateId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceTemplateId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
