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
    [GraphRoute("PATCH", "/deviceManagement/notificationMessageTemplates/{notificationMessageTemplate-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementNotificationMessageTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.NotificationMessageTemplate))]
    public class UpdateMgDeviceManagementNotificationMessageTemplateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string NotificationMessageTemplateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DefaultLocale { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.NotificationTemplateBrandingOptions? BrandingOptions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(NotificationMessageTemplateId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.NotificationMessageTemplate();

    if (this.IsParameterBound(nameof(DefaultLocale)))
        body.DefaultLocale = DefaultLocale;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(BrandingOptions)))
        body.BrandingOptions = BrandingOptions;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.NotificationMessageTemplate? result;
            try
            {
                result = client.DeviceManagement.NotificationMessageTemplates[NotificationMessageTemplateId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, NotificationMessageTemplateId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.NotificationMessageTemplates[NotificationMessageTemplateId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, NotificationMessageTemplateId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
