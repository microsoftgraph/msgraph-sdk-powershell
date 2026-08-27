#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/solutions/backupRestore/restorePoints/search")]
    [Cmdlet(VerbsCommon.Search, "MgSolutionBackupRestorePoint", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.RestorePointSearchResponse))]
    public class SearchMgSolutionBackupRestorePointCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? ProtectionUnitIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.TimePeriod? ProtectionTimePeriod { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.RestorePointPreference? RestorePointPreference { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.RestorePointTags? Tags { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ArtifactQuery? ArtifactQuery { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Search"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.BackupRestore.Client.Solutions.BackupRestore.RestorePoints.Search.SearchPostRequestBody();

    if (this.IsParameterBound(nameof(ProtectionUnitIds)))
        body.ProtectionUnitIds = ProtectionUnitIds!.ToList();
    if (this.IsParameterBound(nameof(ProtectionTimePeriod)))
        body.ProtectionTimePeriod = ProtectionTimePeriod;

    if (this.IsParameterBound(nameof(RestorePointPreference)))
        body.RestorePointPreference = RestorePointPreference;

    if (this.IsParameterBound(nameof(Tags)))
        body.Tags = Tags;

    if (this.IsParameterBound(nameof(ArtifactQuery)))
        body.ArtifactQuery = ArtifactQuery;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.RestorePointSearchResponse? result;
            try
            {
                result = client.Solutions.BackupRestore.RestorePoints.Search.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
