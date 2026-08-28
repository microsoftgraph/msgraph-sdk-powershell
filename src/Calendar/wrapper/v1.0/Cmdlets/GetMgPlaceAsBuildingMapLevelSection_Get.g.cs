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
    [GraphRoute("GET", "/places/{place-id}/graph.building/map/levels/{levelMap-id}/sections/{sectionMap-id}")]
    [Cmdlet(VerbsCommon.Get, "MgPlaceAsBuildingMapLevelSection_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.SectionMap))]
    public class GetMgPlaceAsBuildingMapLevelSection_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlaceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string LevelMapId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SectionMapId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Calendar.Client.Models.SectionMap? result;
            try
            {
                result = client.Places[PlaceId].GraphBuilding.Map.Levels[LevelMapId].Sections[SectionMapId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SectionMapId);
                return;
            }

            WriteObject(result);
        }
    }
}
