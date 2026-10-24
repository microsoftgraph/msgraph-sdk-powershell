#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Calendar.Client;
using Microsoft.Graph.PowerShell.Calendar.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Calendar
{
    [GraphRoute("PATCH", "/users/{user-id}/calendar/calendarPermissions/{calendarPermission-id}")]
    [Cmdlet(VerbsData.Update, "MgUserCalendarPermission", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.CalendarPermission))]
    public class UpdateMgUserCalendarPermissionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CalendarPermissionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsInsideOrganization { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRemovable { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.CalendarRoleType?[]? AllowedRoles { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.EmailAddress? EmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.CalendarRoleType? Role { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CalendarPermissionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.CalendarPermission();

    if (this.IsParameterBound(nameof(IsInsideOrganization)))
        body.IsInsideOrganization = IsInsideOrganization;

    if (this.IsParameterBound(nameof(IsRemovable)))
        body.IsRemovable = IsRemovable;

    if (this.IsParameterBound(nameof(AllowedRoles)))
        body.AllowedRoles = AllowedRoles!.ToList();

    if (this.IsParameterBound(nameof(EmailAddress)))
        body.EmailAddress = EmailAddress;

    if (this.IsParameterBound(nameof(Role)))
        body.Role = Role;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.CalendarPermission? result;
            try
            {
                result = client.Users[UserId].Calendar.CalendarPermissions[CalendarPermissionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CalendarPermissionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Calendar.CalendarPermissions[CalendarPermissionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CalendarPermissionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
