#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Calendar.Client;
using Microsoft.Graph.PowerShell.Calendar.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Calendar
{
    [GraphRoute("GET", "/users/{user-id}/calendarGroups/{calendarGroup-id}/calendars/{calendar-id}/allowedCalendarSharingRoles(User='{User}')")]
    [Cmdlet(VerbsCommon.Get, "MgUserCalendarGroupCalendarAllowedCalendarSharingRolesWithUser")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Calendar.Client.Users.Item.CalendarGroups.Item.Calendars.Item.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserGetResponse))]
    public class GetMgUserCalendarGroupCalendarAllowedCalendarSharingRolesWithUserCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CalendarGroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CalendarId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 3,
            HelpMessage = "Value for the 'User' parameter of this OData function.")]
        public string User { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }

        [Parameter(Mandatory = false)]
        public int Top { get; set; }

        [Parameter(Mandatory = false)]
        public int Skip { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter Count { get; set; }




        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "user%2Did", UserId },
            { "calendarGroup%2Did", CalendarGroupId },
            { "calendar%2Did", CalendarId },
            { "User", User },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Calendar.Client.Users.Item.CalendarGroups.Item.Calendars.Item.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.Calendar.Client.Users.Item.CalendarGroups.Item.Calendars.Item.AllowedCalendarSharingRolesWithUser.AllowedCalendarSharingRolesWithUserGetResponse? result;
            try
            {
                result = requestBuilder.GetAsAllowedCalendarSharingRolesWithUserGetResponseAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                    if (this.IsParameterBound(nameof(Top)))
                        requestConfiguration.QueryParameters.Top = Top;

                    if (this.IsParameterBound(nameof(Skip)))
                        requestConfiguration.QueryParameters.Skip = Skip;

                    if (Count.IsPresent)
                        requestConfiguration.QueryParameters.Count = true;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, CalendarId);
                return;
            }

            WriteObject(result);
        }
    }
}
