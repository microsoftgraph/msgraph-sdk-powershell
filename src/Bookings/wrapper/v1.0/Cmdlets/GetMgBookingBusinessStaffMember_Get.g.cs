#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Bookings.Client;
using Microsoft.Graph.PowerShell.Bookings.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Bookings
{
    [GraphRoute("GET", "/solutions/bookingBusinesses/{bookingBusiness-id}/staffMembers/{bookingStaffMemberBase-id}")]
    [Cmdlet(VerbsCommon.Get, "MgBookingBusinessStaffMember_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingStaffMemberBase))]
    public class GetMgBookingBusinessStaffMember_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BookingBusinessId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BookingStaffMemberBaseId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingStaffMemberBase? result;
            try
            {
                result = client.Solutions.BookingBusinesses[BookingBusinessId].StaffMembers[BookingStaffMemberBaseId].GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, BookingStaffMemberBaseId);
                return;
            }

            WriteObject(result);
        }
    }
}
