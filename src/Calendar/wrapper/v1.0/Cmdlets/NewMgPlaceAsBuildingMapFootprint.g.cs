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
    [GraphRoute("POST", "/places/{place-id}/graph.building/map/footprints")]
    [Cmdlet(VerbsCommon.New, "MgPlaceAsBuildingMapFootprint", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.FootprintMap))]
    public class NewMgPlaceAsBuildingMapFootprintCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlaceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Properties { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlaceId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.FootprintMap();

    if (this.IsParameterBound(nameof(Properties)))
        body.Properties = Properties;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.FootprintMap? result;
            try
            {
                result = client.Places[PlaceId].GraphBuilding.Map.Footprints.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
