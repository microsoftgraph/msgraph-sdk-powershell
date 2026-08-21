#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.BackupRestore.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.BackupRestore
{
    [GraphRoute("DELETE", "/solutions/backupRestore/sharePointRestoreSessions/{sharePointRestoreSession-id}/granularSiteRestoreArtifacts/{granularSiteRestoreArtifact-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgSolutionBackupRestoreSharePointRestoreSessionGranularSiteRestoreArtifact", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgSolutionBackupRestoreSharePointRestoreSessionGranularSiteRestoreArtifactCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharePointRestoreSessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string GranularSiteRestoreArtifactId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GranularSiteRestoreArtifactId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.Solutions.BackupRestore.SharePointRestoreSessions[SharePointRestoreSessionId].GranularSiteRestoreArtifacts[GranularSiteRestoreArtifactId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, GranularSiteRestoreArtifactId);
                return;
            }
        }
    }
}
