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
    [GraphRoute("POST", "/deviceManagement/notificationMessageTemplates/{notificationMessageTemplate-id}/localizedNotificationMessages")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementNotificationMessageTemplateLocalizedNotificationMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.LocalizedNotificationMessage))]
    public class NewMgDeviceManagementNotificationMessageTemplateLocalizedNotificationMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string NotificationMessageTemplateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsDefault { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Locale { get; set; }

        [Parameter(Mandatory = false)]
        public string? MessageTemplate { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subject { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(NotificationMessageTemplateId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.LocalizedNotificationMessage();

    if (this.IsParameterBound(nameof(IsDefault)))
        body.IsDefault = IsDefault;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Locale)))
        body.Locale = Locale;

    if (this.IsParameterBound(nameof(MessageTemplate)))
        body.MessageTemplate = MessageTemplate;

    if (this.IsParameterBound(nameof(Subject)))
        body.Subject = Subject;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.LocalizedNotificationMessage? result;
            try
            {
                result = client.DeviceManagement.NotificationMessageTemplates[NotificationMessageTemplateId].LocalizedNotificationMessages.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
