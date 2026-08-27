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
    [GraphRoute("PATCH", "/places/{place-id}/graph.building/map")]
    [Cmdlet(VerbsData.Update, "MgPlaceAsBuildingMap", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.BuildingMap))]
    public class UpdateMgPlaceAsBuildingMapCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlaceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Properties { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlaceId1 { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlaceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.BuildingMap();

    if (this.IsParameterBound(nameof(Properties)))
        body.Properties = Properties;

    if (this.IsParameterBound(nameof(PlaceId1)))
        body.PlaceId = PlaceId1;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.BuildingMap? result;
            try
            {
                result = client.Places[PlaceId].GraphBuilding.Map.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, PlaceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Places[PlaceId].GraphBuilding.Map.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, PlaceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
