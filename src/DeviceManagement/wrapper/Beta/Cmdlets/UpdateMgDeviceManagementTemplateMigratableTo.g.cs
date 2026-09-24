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
    [GraphRoute("PATCH", "/deviceManagement/templates/{deviceManagementTemplate-id}/migratableTo/{deviceManagementTemplate-id1}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementTemplateMigratableTo", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementTemplate))]
    public class UpdateMgDeviceManagementTemplateMigratableToCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementTemplateId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementTemplateId1 { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? IntentCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDeprecated { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? PublishedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? VersionInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.PolicyPlatformType? PlatformType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementTemplateSubtype? TemplateSubtype { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementTemplateType? TemplateType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementTemplateId1, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementTemplate();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IntentCount)))
        body.IntentCount = IntentCount;

    if (this.IsParameterBound(nameof(IsDeprecated)))
        body.IsDeprecated = IsDeprecated;

    if (this.IsParameterBound(nameof(PublishedDateTime)))
        body.PublishedDateTime = PublishedDateTime;

    if (this.IsParameterBound(nameof(VersionInfo)))
        body.VersionInfo = VersionInfo;

    if (this.IsParameterBound(nameof(PlatformType)))
        body.PlatformType = PlatformType;

    if (this.IsParameterBound(nameof(TemplateSubtype)))
        body.TemplateSubtype = TemplateSubtype;

    if (this.IsParameterBound(nameof(TemplateType)))
        body.TemplateType = TemplateType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementTemplate? result;
            try
            {
                result = client.DeviceManagement.Templates[DeviceManagementTemplateId].MigratableTo[DeviceManagementTemplateId1].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementTemplateId1);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.Templates[DeviceManagementTemplateId].MigratableTo[DeviceManagementTemplateId1].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementTemplateId1);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
