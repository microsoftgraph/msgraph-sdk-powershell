#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("PATCH", "/deviceManagement/virtualEndpoint/galleryImages/{cloudPcGalleryImage-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementVirtualEndpointGalleryImage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcGalleryImage))]
    public class UpdateMgDeviceManagementVirtualEndpointGalleryImageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudPcGalleryImageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? EndDate { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? ExpirationDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? OfferName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsVersionNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? PublisherName { get; set; }

        [Parameter(Mandatory = false)]
        public int? SizeInGB { get; set; }

        [Parameter(Mandatory = false)]
        public string? SkuName { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? StartDate { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcGalleryImageStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CloudPcGalleryImageId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcGalleryImage();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EndDate)))
        body.EndDate = EndDate;

    if (this.IsParameterBound(nameof(ExpirationDate)))
        body.ExpirationDate = ExpirationDate;

    if (this.IsParameterBound(nameof(OfferName)))
        body.OfferName = OfferName;

    if (this.IsParameterBound(nameof(OsVersionNumber)))
        body.OsVersionNumber = OsVersionNumber;

    if (this.IsParameterBound(nameof(PublisherName)))
        body.PublisherName = PublisherName;

    if (this.IsParameterBound(nameof(SizeInGB)))
        body.SizeInGB = SizeInGB;

    if (this.IsParameterBound(nameof(SkuName)))
        body.SkuName = SkuName;

    if (this.IsParameterBound(nameof(StartDate)))
        body.StartDate = StartDate;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcGalleryImage? result;
            try
            {
                result = client.DeviceManagement.VirtualEndpoint.GalleryImages[CloudPcGalleryImageId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, CloudPcGalleryImageId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.VirtualEndpoint.GalleryImages[CloudPcGalleryImageId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, CloudPcGalleryImageId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
