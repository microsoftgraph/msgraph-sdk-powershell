#nullable enable

using System;
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
    [GraphRoute("GET", "/places/{place-id}/graph.roomList/rooms/{room-id}/checkIns/{checkInClaim-calendarEventId}")]
    [Cmdlet(VerbsCommon.Get, "MgPlaceAsRoomListRoomCheckIn_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.CheckInClaim))]
    public class GetMgPlaceAsRoomListRoomCheckIn_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlaceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string RoomId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string CheckInClaimCalendarEventId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.CheckInClaim? result;
            try
            {
                result = client.Places[PlaceId].GraphRoomList.Rooms[RoomId].CheckIns[CheckInClaimCalendarEventId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, CheckInClaimCalendarEventId);
                return;
            }

            WriteObject(result);
        }
    }
}
