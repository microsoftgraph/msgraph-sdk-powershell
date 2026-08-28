#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.BackupRestore.Client;
using Microsoft.Graph.PowerShell.BackupRestore.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.BackupRestore
{
    [GraphRoute("GET", "/solutions/backupRestore/oneDriveForBusinessRestoreSessions/{oneDriveForBusinessRestoreSession-id}/driveRestoreArtifacts/{driveRestoreArtifact-id}")]
    [Cmdlet(VerbsCommon.Get, "MgSolutionBackupRestoreOneDriveForBusinessRestoreSessionDriveRestoreArtifact_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.DriveRestoreArtifact))]
    public class GetMgSolutionBackupRestoreOneDriveForBusinessRestoreSessionDriveRestoreArtifact_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OneDriveForBusinessRestoreSessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveRestoreArtifactId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.DriveRestoreArtifact? result;
            try
            {
                result = client.Solutions.BackupRestore.OneDriveForBusinessRestoreSessions[OneDriveForBusinessRestoreSessionId].DriveRestoreArtifacts[DriveRestoreArtifactId].GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, DriveRestoreArtifactId);
                return;
            }

            WriteObject(result);
        }
    }
}
