#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("GET", "/shares/{sharedDriveItem-id}/root")]
    [Cmdlet(VerbsCommon.Get, "MgShareRoot")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.DriveItem))]
    public class GetMgShareRootCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharedDriveItemId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Files.Client.Models.DriveItem? result;
            try
            {
                result = client.Shares[SharedDriveItemId].Root.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SharedDriveItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
