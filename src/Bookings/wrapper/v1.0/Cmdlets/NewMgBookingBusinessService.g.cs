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
    [GraphRoute("POST", "/solutions/bookingBusinesses/{bookingBusiness-id}/services")]
    [Cmdlet(VerbsCommon.New, "MgBookingBusinessService", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingService))]
    public class NewMgBookingBusinessServiceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BookingBusinessId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AdditionalInformation { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? DefaultDuration { get; set; }

        [Parameter(Mandatory = false)]
        public double? DefaultPrice { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAnonymousJoinEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCustomerAllowedToManageBooking { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsHiddenFromCustomers { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsLocationOnline { get; set; }

        [Parameter(Mandatory = false)]
        public string? LanguageTag { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? MaximumAttendeesCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? Notes { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? PostBuffer { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? PreBuffer { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SmsNotificationsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? StaffMemberIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingQuestionAssignment[]? CustomQuestions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.Location? DefaultLocation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingPriceType? DefaultPriceType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingReminder[]? DefaultReminders { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingSchedulingPolicy? SchedulingPolicy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BookingBusinessId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingService();

    if (this.IsParameterBound(nameof(AdditionalInformation)))
        body.AdditionalInformation = AdditionalInformation;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DefaultDuration)))
        body.DefaultDuration = DefaultDuration;

    if (this.IsParameterBound(nameof(DefaultPrice)))
        body.DefaultPrice = DefaultPrice;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsAnonymousJoinEnabled)))
        body.IsAnonymousJoinEnabled = IsAnonymousJoinEnabled;

    if (this.IsParameterBound(nameof(IsCustomerAllowedToManageBooking)))
        body.IsCustomerAllowedToManageBooking = IsCustomerAllowedToManageBooking;

    if (this.IsParameterBound(nameof(IsHiddenFromCustomers)))
        body.IsHiddenFromCustomers = IsHiddenFromCustomers;

    if (this.IsParameterBound(nameof(IsLocationOnline)))
        body.IsLocationOnline = IsLocationOnline;

    if (this.IsParameterBound(nameof(LanguageTag)))
        body.LanguageTag = LanguageTag;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(MaximumAttendeesCount)))
        body.MaximumAttendeesCount = MaximumAttendeesCount;

    if (this.IsParameterBound(nameof(Notes)))
        body.Notes = Notes;

    if (this.IsParameterBound(nameof(PostBuffer)))
        body.PostBuffer = PostBuffer;

    if (this.IsParameterBound(nameof(PreBuffer)))
        body.PreBuffer = PreBuffer;

    if (this.IsParameterBound(nameof(SmsNotificationsEnabled)))
        body.SmsNotificationsEnabled = SmsNotificationsEnabled;

    if (this.IsParameterBound(nameof(StaffMemberIds)))
        body.StaffMemberIds = StaffMemberIds!.ToList();

    if (this.IsParameterBound(nameof(CustomQuestions)))
        body.CustomQuestions = CustomQuestions!.ToList();

    if (this.IsParameterBound(nameof(DefaultLocation)))
        body.DefaultLocation = DefaultLocation;

    if (this.IsParameterBound(nameof(DefaultPriceType)))
        body.DefaultPriceType = DefaultPriceType;

    if (this.IsParameterBound(nameof(DefaultReminders)))
        body.DefaultReminders = DefaultReminders!.ToList();

    if (this.IsParameterBound(nameof(SchedulingPolicy)))
        body.SchedulingPolicy = SchedulingPolicy;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingService? result;
            try
            {
                result = client.Solutions.BookingBusinesses[BookingBusinessId].Services.PostAsync(body, requestConfiguration =>
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
