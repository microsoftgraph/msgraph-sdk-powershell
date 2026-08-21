#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("GET", "/directory/recovery/snapshots/{snapshot-id}/recoveryPreviewJobs/{recoveryPreviewJob-id}")]
    [Cmdlet(VerbsCommon.Get, "MgDirectoryRecoverySnapshotRecoveryPreviewJob_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryPreviewJob))]
    public class GetMgDirectoryRecoverySnapshotRecoveryPreviewJob_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SnapshotId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string RecoveryPreviewJobId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryPreviewJob? result;
            try
            {
                result = client.Directory.Recovery.Snapshots[SnapshotId].RecoveryPreviewJobs[RecoveryPreviewJobId].GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, RecoveryPreviewJobId);
                return;
            }

            WriteObject(result);
        }
    }
}
