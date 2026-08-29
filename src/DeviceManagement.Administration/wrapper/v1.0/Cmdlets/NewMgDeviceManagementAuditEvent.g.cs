#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("POST", "/deviceManagement/auditEvents")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementAuditEvent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.AuditEvent))]
    public class NewMgDeviceManagementAuditEventCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Activity { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ActivityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ActivityOperationType { get; set; }

        [Parameter(Mandatory = false)]
        public string? ActivityResult { get; set; }

        [Parameter(Mandatory = false)]
        public string? ActivityType { get; set; }

        [Parameter(Mandatory = false)]
        public string? Category { get; set; }

        [Parameter(Mandatory = false)]
        public string? ComponentName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? CorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.AuditActor? Actor { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.AuditResource[]? Resources { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.AuditEvent();

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;

    if (this.IsParameterBound(nameof(ActivityDateTime)))
        body.ActivityDateTime = ActivityDateTime;

    if (this.IsParameterBound(nameof(ActivityOperationType)))
        body.ActivityOperationType = ActivityOperationType;

    if (this.IsParameterBound(nameof(ActivityResult)))
        body.ActivityResult = ActivityResult;

    if (this.IsParameterBound(nameof(ActivityType)))
        body.ActivityType = ActivityType;

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(ComponentName)))
        body.ComponentName = ComponentName;

    if (this.IsParameterBound(nameof(CorrelationId)))
        body.CorrelationId = CorrelationId;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Actor)))
        body.Actor = Actor;

    if (this.IsParameterBound(nameof(Resources)))
        body.Resources = Resources!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.AuditEvent? result;
            try
            {
                result = client.DeviceManagement.AuditEvents.PostAsync(body, requestConfiguration =>
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
