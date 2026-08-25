#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/assignSensitivityLabel")]
    [Cmdlet(VerbsCommon.Set, "MgDriveItemSensitivityLabel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgDriveItemSensitivityLabelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? SensitivityLabelId { get; set; }

        [Parameter(Mandatory = false)]
        public string? JustificationText { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.SensitivityLabelAssignmentMethod? AssignmentMethod { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.AssignSensitivityLabel.AssignSensitivityLabelPostRequestBody();

    if (this.IsParameterBound(nameof(SensitivityLabelId)))
        body.SensitivityLabelId = SensitivityLabelId;

    if (this.IsParameterBound(nameof(JustificationText)))
        body.JustificationText = JustificationText;
    if (this.IsParameterBound(nameof(AssignmentMethod)))
        body.AssignmentMethod = AssignmentMethod;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Drives[DriveId].Items[DriveItemId].AssignSensitivityLabel.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DriveItemId);
                return;
            }

        }
    }
}
