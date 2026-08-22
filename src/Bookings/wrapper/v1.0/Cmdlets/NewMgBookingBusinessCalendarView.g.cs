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
    [GraphRoute("POST", "/solutions/bookingBusinesses/{bookingBusiness-id}/calendarView")]
    [Cmdlet(VerbsCommon.New, "MgBookingBusinessCalendarView", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingAppointment))]
    public class NewMgBookingBusinessCalendarViewCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BookingBusinessId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AdditionalInformation { get; set; }

        [Parameter(Mandatory = false)]
        public string? AnonymousJoinWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppointmentLabel { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomerEmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomerName { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomerNotes { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomerPhone { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomerTimeZone { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCustomerAllowedToManageBooking { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsLocationOnline { get; set; }

        [Parameter(Mandatory = false)]
        public string? JoinWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? MaximumAttendeesCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OptOutOfCustomerEmail { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? PostBuffer { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? PreBuffer { get; set; }

        [Parameter(Mandatory = false)]
        public double? Price { get; set; }

        [Parameter(Mandatory = false)]
        public string? SelfServiceAppointmentId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServiceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServiceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServiceNotes { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SmsNotificationsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? StaffMemberIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCustomerInformationBase[]? Customers { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.DateTimeTimeZone? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingPriceType? PriceType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingReminder[]? Reminders { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.Location? ServiceLocation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.DateTimeTimeZone? StartDateTime { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BookingBusinessId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingAppointment();

    if (this.IsParameterBound(nameof(AdditionalInformation)))
        body.AdditionalInformation = AdditionalInformation;

    if (this.IsParameterBound(nameof(AnonymousJoinWebUrl)))
        body.AnonymousJoinWebUrl = AnonymousJoinWebUrl;

    if (this.IsParameterBound(nameof(AppointmentLabel)))
        body.AppointmentLabel = AppointmentLabel;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CustomerEmailAddress)))
        body.CustomerEmailAddress = CustomerEmailAddress;

    if (this.IsParameterBound(nameof(CustomerName)))
        body.CustomerName = CustomerName;

    if (this.IsParameterBound(nameof(CustomerNotes)))
        body.CustomerNotes = CustomerNotes;

    if (this.IsParameterBound(nameof(CustomerPhone)))
        body.CustomerPhone = CustomerPhone;

    if (this.IsParameterBound(nameof(CustomerTimeZone)))
        body.CustomerTimeZone = CustomerTimeZone;

    if (this.IsParameterBound(nameof(IsCustomerAllowedToManageBooking)))
        body.IsCustomerAllowedToManageBooking = IsCustomerAllowedToManageBooking;

    if (this.IsParameterBound(nameof(IsLocationOnline)))
        body.IsLocationOnline = IsLocationOnline;

    if (this.IsParameterBound(nameof(JoinWebUrl)))
        body.JoinWebUrl = JoinWebUrl;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(MaximumAttendeesCount)))
        body.MaximumAttendeesCount = MaximumAttendeesCount;

    if (this.IsParameterBound(nameof(OptOutOfCustomerEmail)))
        body.OptOutOfCustomerEmail = OptOutOfCustomerEmail;

    if (this.IsParameterBound(nameof(PostBuffer)))
        body.PostBuffer = PostBuffer;

    if (this.IsParameterBound(nameof(PreBuffer)))
        body.PreBuffer = PreBuffer;

    if (this.IsParameterBound(nameof(Price)))
        body.Price = Price;

    if (this.IsParameterBound(nameof(SelfServiceAppointmentId)))
        body.SelfServiceAppointmentId = SelfServiceAppointmentId;

    if (this.IsParameterBound(nameof(ServiceId)))
        body.ServiceId = ServiceId;

    if (this.IsParameterBound(nameof(ServiceName)))
        body.ServiceName = ServiceName;

    if (this.IsParameterBound(nameof(ServiceNotes)))
        body.ServiceNotes = ServiceNotes;

    if (this.IsParameterBound(nameof(SmsNotificationsEnabled)))
        body.SmsNotificationsEnabled = SmsNotificationsEnabled;

    if (this.IsParameterBound(nameof(StaffMemberIds)))
        body.StaffMemberIds = StaffMemberIds!.ToList();

    if (this.IsParameterBound(nameof(Customers)))
        body.Customers = Customers!.ToList();

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(PriceType)))
        body.PriceType = PriceType;

    if (this.IsParameterBound(nameof(Reminders)))
        body.Reminders = Reminders!.ToList();

    if (this.IsParameterBound(nameof(ServiceLocation)))
        body.ServiceLocation = ServiceLocation;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingAppointment? result;
            try
            {
                result = client.Solutions.BookingBusinesses[BookingBusinessId].CalendarView.PostAsync(body, requestConfiguration =>
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
