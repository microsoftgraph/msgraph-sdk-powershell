#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("PATCH", "/admin/windows/updates/products/{product-id}/editions/{edition-id}")]
    [Cmdlet(VerbsData.Update, "MgWindowsUpdatesProductEdition", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.Edition))]
    public class UpdateMgWindowsUpdatesProductEditionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ProductId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EditionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DeviceFamily { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndOfServiceDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? GeneralAvailabilityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsInService { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReleasedName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ServicingPeriod[]? ServicingPeriods { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EditionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.Edition();

    if (this.IsParameterBound(nameof(DeviceFamily)))
        body.DeviceFamily = DeviceFamily;

    if (this.IsParameterBound(nameof(EndOfServiceDateTime)))
        body.EndOfServiceDateTime = EndOfServiceDateTime;

    if (this.IsParameterBound(nameof(GeneralAvailabilityDateTime)))
        body.GeneralAvailabilityDateTime = GeneralAvailabilityDateTime;

    if (this.IsParameterBound(nameof(IsInService)))
        body.IsInService = IsInService;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(ReleasedName)))
        body.ReleasedName = ReleasedName;

    if (this.IsParameterBound(nameof(ServicingPeriods)))
        body.ServicingPeriods = ServicingPeriods!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.Edition? result;
            try
            {
                result = client.Admin.Windows.Updates.Products[ProductId].Editions[EditionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EditionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.Windows.Updates.Products[ProductId].Editions[EditionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, EditionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
