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
    [GraphRoute("POST", "/places")]
    [Cmdlet(VerbsCommon.New, "MgPlace", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.Place))]
    public class NewMgPlaceCommand : GraphClientCmdlet
    {


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
        public string? PlaceId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Tags { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.PhysicalAddress? Address { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.OutlookGeoCoordinates? GeoCoordinates { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.Place();

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

    if (this.IsParameterBound(nameof(PlaceId)))
        body.PlaceId = PlaceId;

    if (this.IsParameterBound(nameof(Tags)))
        body.Tags = Tags!.ToList();

    if (this.IsParameterBound(nameof(Address)))
        body.Address = Address;

    if (this.IsParameterBound(nameof(GeoCoordinates)))
        body.GeoCoordinates = GeoCoordinates;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.Place? result;
            try
            {
                result = client.Places.PostAsync(body, requestConfiguration =>
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
