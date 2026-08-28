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
    [GraphRoute("POST", "/groups/{group-id}/calendar/calendarPermissions")]
    [Cmdlet(VerbsCommon.New, "MgGroupCalendarPermission", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.CalendarPermission))]
    public class NewMgGroupCalendarPermissionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

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
            if (!ShouldProcess(GroupId, "New"))
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
                result = client.Groups[GroupId].Calendar.CalendarPermissions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
