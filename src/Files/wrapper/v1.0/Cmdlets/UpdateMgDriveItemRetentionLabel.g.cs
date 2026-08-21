#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("PATCH", "/drives/{drive-id}/items/{driveItem-id}/retentionLabel")]
    [Cmdlet(VerbsData.Update, "MgDriveItemRetentionLabel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.ItemRetentionLabel))]
    public class UpdateMgDriveItemRetentionLabelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsLabelAppliedExplicitly { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LabelAppliedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.IdentitySet? LabelAppliedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.RetentionLabelSettings? RetentionSettings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.ItemRetentionLabel();

    if (this.IsParameterBound(nameof(IsLabelAppliedExplicitly)))
        body.IsLabelAppliedExplicitly = IsLabelAppliedExplicitly;

    if (this.IsParameterBound(nameof(LabelAppliedDateTime)))
        body.LabelAppliedDateTime = LabelAppliedDateTime;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(LabelAppliedBy)))
        body.LabelAppliedBy = LabelAppliedBy;

    if (this.IsParameterBound(nameof(RetentionSettings)))
        body.RetentionSettings = RetentionSettings;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.ItemRetentionLabel? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].RetentionLabel.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DriveItemId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Drives[DriveId].Items[DriveItemId].RetentionLabel.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, DriveItemId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
