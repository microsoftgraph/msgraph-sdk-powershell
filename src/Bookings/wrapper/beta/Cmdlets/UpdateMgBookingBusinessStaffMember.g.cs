#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Bookings.Client;
using Microsoft.Graph.PowerShell.Bookings.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Bookings
{
    [GraphRoute("PATCH", "/solutions/bookingBusinesses/{bookingBusiness-id}/staffMembers/{bookingStaffMember-id}")]
    [Cmdlet(VerbsData.Update, "MgBookingBusinessStaffMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingStaffMember))]
    public class UpdateMgBookingBusinessStaffMemberCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BookingBusinessId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BookingStaffMemberId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? EmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AvailabilityIsAffectedByPersonalCalendar { get; set; }

        [Parameter(Mandatory = false)]
        public int? ColorIndex { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEmailNotificationEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeZone { get; set; }

        [Parameter(Mandatory = false)]
        public bool? UseBusinessHours { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingStaffMembershipStatus? MembershipStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingStaffRole? Role { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingWorkHours[]? WorkingHours { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BookingStaffMemberId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingStaffMember();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EmailAddress)))
        body.EmailAddress = EmailAddress;

    if (this.IsParameterBound(nameof(AvailabilityIsAffectedByPersonalCalendar)))
        body.AvailabilityIsAffectedByPersonalCalendar = AvailabilityIsAffectedByPersonalCalendar;

    if (this.IsParameterBound(nameof(ColorIndex)))
        body.ColorIndex = ColorIndex;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(IsEmailNotificationEnabled)))
        body.IsEmailNotificationEnabled = IsEmailNotificationEnabled;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(TimeZone)))
        body.TimeZone = TimeZone;

    if (this.IsParameterBound(nameof(UseBusinessHours)))
        body.UseBusinessHours = UseBusinessHours;

    if (this.IsParameterBound(nameof(MembershipStatus)))
        body.MembershipStatus = MembershipStatus;

    if (this.IsParameterBound(nameof(Role)))
        body.Role = Role;

    if (this.IsParameterBound(nameof(WorkingHours)))
        body.WorkingHours = WorkingHours!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingStaffMember? result;
            try
            {
                result = client.Solutions.BookingBusinesses[BookingBusinessId].StaffMembers[BookingStaffMemberId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, BookingStaffMemberId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BookingBusinesses[BookingBusinessId].StaffMembers[BookingStaffMemberId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, BookingStaffMemberId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
