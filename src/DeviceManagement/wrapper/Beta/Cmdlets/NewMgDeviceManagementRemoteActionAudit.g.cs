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
    [GraphRoute("POST", "/deviceManagement/remoteActionAudits")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementRemoteActionAudit", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.RemoteActionAudit))]
    public class NewMgDeviceManagementRemoteActionAuditCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? BulkDeviceActionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceIMEI { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceOwnerUserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? InitiatedByUserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagedDeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RequestDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.RemoteAction? Action { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ActionState? ActionState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceActionCategory? DeviceActionCategory { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.RemoteActionAudit();

    if (this.IsParameterBound(nameof(BulkDeviceActionId)))
        body.BulkDeviceActionId = BulkDeviceActionId;

    if (this.IsParameterBound(nameof(DeviceDisplayName)))
        body.DeviceDisplayName = DeviceDisplayName;

    if (this.IsParameterBound(nameof(DeviceIMEI)))
        body.DeviceIMEI = DeviceIMEI;

    if (this.IsParameterBound(nameof(DeviceOwnerUserPrincipalName)))
        body.DeviceOwnerUserPrincipalName = DeviceOwnerUserPrincipalName;

    if (this.IsParameterBound(nameof(InitiatedByUserPrincipalName)))
        body.InitiatedByUserPrincipalName = InitiatedByUserPrincipalName;

    if (this.IsParameterBound(nameof(ManagedDeviceId)))
        body.ManagedDeviceId = ManagedDeviceId;

    if (this.IsParameterBound(nameof(RequestDateTime)))
        body.RequestDateTime = RequestDateTime;

    if (this.IsParameterBound(nameof(UserName)))
        body.UserName = UserName;

    if (this.IsParameterBound(nameof(Action)))
        body.Action = Action;

    if (this.IsParameterBound(nameof(ActionState)))
        body.ActionState = ActionState;

    if (this.IsParameterBound(nameof(DeviceActionCategory)))
        body.DeviceActionCategory = DeviceActionCategory;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.RemoteActionAudit? result;
            try
            {
                result = client.DeviceManagement.RemoteActionAudits.PostAsync(body, requestConfiguration =>
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
