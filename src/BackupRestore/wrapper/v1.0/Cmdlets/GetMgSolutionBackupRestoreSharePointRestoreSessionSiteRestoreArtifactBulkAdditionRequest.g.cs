#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.BackupRestore.Client.Models;

namespace Microsoft.Graph.PowerShell.BackupRestore
{
    [GraphRoute("GET", "/solutions/backupRestore/sharePointRestoreSessions/{sharePointRestoreSession-id}/siteRestoreArtifactsBulkAdditionRequests")]
    [Cmdlet(VerbsCommon.Get, "MgSolutionBackupRestoreSharePointRestoreSessionSiteRestoreArtifactBulkAdditionRequest", DefaultParameterSetName = "List")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.SiteRestoreArtifactsBulkAdditionRequestCollectionResponse), ParameterSetName = new[] { "List" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.SiteRestoreArtifactsBulkAdditionRequest), ParameterSetName = new[] { "Get" })]
    public class GetMgSolutionBackupRestoreSharePointRestoreSessionSiteRestoreArtifactBulkAdditionRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharePointRestoreSessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, ParameterSetName = "Get", Position = 1)]
        public string SiteRestoreArtifactsBulkAdditionRequestId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public SwitchParameter Count { get; set; }

        // Declared here because the binder rejects a parameter the dispatcher does not accept
        // before ProcessRecord ever runs; once declared, the wholesale BoundParameters splat
        // forwards it to the list worker with no further plumbing.
        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public SwitchParameter All { get; set; }





        // Delegates to Get-MgSolutionBackupRestoreSharePointRestoreSessionSiteRestoreArtifactBulkAdditionRequest_Get or Get-MgSolutionBackupRestoreSharePointRestoreSessionSiteRestoreArtifactBulkAdditionRequest_List, the two cmdlets
        // that actually call Graph.
        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName == "Get" ? "Get-MgSolutionBackupRestoreSharePointRestoreSessionSiteRestoreArtifactBulkAdditionRequest_Get" : "Get-MgSolutionBackupRestoreSharePointRestoreSessionSiteRestoreArtifactBulkAdditionRequest_List";
            try
            {
                InvokeCommand.InvokeScript(
                    "param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters",
                    false,
                    PipelineResultTypes.Output | PipelineResultTypes.Error,
                    null,
                    MyInvocation.BoundParameters, internalCmdletName);
            }
            // The workers signal failure via ThrowTerminatingError, which InvokeScript surfaces
            // as a RuntimeException carrying the worker's ErrorRecord. Rethrow that record
            // unchanged so the caller sees the worker's error identity (NoGraphSession,
            // GraphRequestFailed, ...) instead of every failure collapsing into a generic
            // dispatcher error. A pipeline stop is a RuntimeException too and must NOT be
            // rethrown as a terminating error - both filters here let it pass to the engine.
            catch (RuntimeException rex) when (rex is not PipelineStoppedException && rex.ErrorRecord is not null)
            {
                ThrowTerminatingError(rex.ErrorRecord);
                return;
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ParameterSetName == "Get" ? SiteRestoreArtifactsBulkAdditionRequestId : SharePointRestoreSessionId);
                return;
            }
        }
    }
}
