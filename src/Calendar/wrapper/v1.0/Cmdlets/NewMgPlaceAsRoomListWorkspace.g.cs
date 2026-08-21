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
    [GraphRoute("POST", "/places/{place-id}/graph.roomList/workspaces")]
    [Cmdlet(VerbsCommon.New, "MgPlaceAsRoomListWorkspace", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.Workspace))]
    public class NewMgPlaceAsRoomListWorkspaceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlaceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsWheelChairAccessible { get; set; }

        [Parameter(Mandatory = false)]
        public string? Label { get; set; }

        [Parameter(Mandatory = false)]
        public string? ParentId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Phone { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlaceId1 { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Tags { get; set; }

        [Parameter(Mandatory = false)]
        public int? Capacity { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayDeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? EmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? Nickname { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.PhysicalAddress? Address { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.OutlookGeoCoordinates? GeoCoordinates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.PlaceMode? Mode { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlaceId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.Workspace();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsWheelChairAccessible)))
        body.IsWheelChairAccessible = IsWheelChairAccessible;

    if (this.IsParameterBound(nameof(Label)))
        body.Label = Label;

    if (this.IsParameterBound(nameof(ParentId)))
        body.ParentId = ParentId;

    if (this.IsParameterBound(nameof(Phone)))
        body.Phone = Phone;

    if (this.IsParameterBound(nameof(PlaceId1)))
        body.PlaceId = PlaceId1;

    if (this.IsParameterBound(nameof(Tags)))
        body.Tags = Tags!.ToList();

    if (this.IsParameterBound(nameof(Capacity)))
        body.Capacity = Capacity;

    if (this.IsParameterBound(nameof(DisplayDeviceName)))
        body.DisplayDeviceName = DisplayDeviceName;

    if (this.IsParameterBound(nameof(EmailAddress)))
        body.EmailAddress = EmailAddress;

    if (this.IsParameterBound(nameof(Nickname)))
        body.Nickname = Nickname;

    if (this.IsParameterBound(nameof(Address)))
        body.Address = Address;

    if (this.IsParameterBound(nameof(GeoCoordinates)))
        body.GeoCoordinates = GeoCoordinates;

    if (this.IsParameterBound(nameof(Mode)))
        body.Mode = Mode;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.Workspace? result;
            try
            {
                result = client.Places[PlaceId].GraphRoomList.Workspaces.PostAsync(body, requestConfiguration =>
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
