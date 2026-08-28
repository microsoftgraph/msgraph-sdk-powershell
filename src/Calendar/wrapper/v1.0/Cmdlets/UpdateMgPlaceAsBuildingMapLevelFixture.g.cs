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
    [GraphRoute("PATCH", "/places/{place-id}/graph.building/map/levels/{levelMap-id}/fixtures/{fixtureMap-id}")]
    [Cmdlet(VerbsData.Update, "MgPlaceAsBuildingMapLevelFixture", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.FixtureMap))]
    public class UpdateMgPlaceAsBuildingMapLevelFixtureCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlaceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string LevelMapId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string FixtureMapId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Properties { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlaceId1 { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(FixtureMapId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.FixtureMap();

    if (this.IsParameterBound(nameof(Properties)))
        body.Properties = Properties;

    if (this.IsParameterBound(nameof(PlaceId1)))
        body.PlaceId = PlaceId1;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.FixtureMap? result;
            try
            {
                result = client.Places[PlaceId].GraphBuilding.Map.Levels[LevelMapId].Fixtures[FixtureMapId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, FixtureMapId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Places[PlaceId].GraphBuilding.Map.Levels[LevelMapId].Fixtures[FixtureMapId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, FixtureMapId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
