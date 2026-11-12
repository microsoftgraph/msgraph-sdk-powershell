#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("DELETE", "/financials/companies/{company-id}/journalLines/{journalLine-id}", ParameterSetName = "RootRemove")]
    [GraphRoute("DELETE", "/financials/companies/{company-id}/journals/{journal-id}/journalLines/{journalLine-id}", ParameterSetName = "NestedRemove")]
    [Cmdlet(VerbsCommon.Remove, "MgFinancialCompanyJournalLine", DefaultParameterSetName = "RootRemove", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]

    public class RemoveMgFinancialCompanyJournalLineCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "RootRemove", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedRemove", Position = 0)]
        public string CompanyId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "RootRemove", Position = 1)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedRemove", Position = 2)]
        public string JournalLineId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "RootRemove")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedRemove")]
        public string? IfMatch { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "NestedRemove", Position = 1)]
        public string JournalId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootRemove" => "Remove-MgFinancialCompanyJournalLine_Route0",
                "NestedRemove" => "Remove-MgFinancialCompanyJournalLine_Route1",
                _ => throw new InvalidOperationException("Unsupported operation parameter set."),
            };
            try
            {
                InvokeCommand.InvokeScript(
                    "param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters",
                    false,
                    global::System.Management.Automation.Runspaces.PipelineResultTypes.Output | global::System.Management.Automation.Runspaces.PipelineResultTypes.Error,
                    null,
                    MyInvocation.BoundParameters, internalCmdletName);
            }
            catch (RuntimeException rex) when (rex is not PipelineStoppedException && rex.ErrorRecord is not null)
            {
                ThrowTerminatingError(rex.ErrorRecord);
                return;
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }
        }
    }
}
