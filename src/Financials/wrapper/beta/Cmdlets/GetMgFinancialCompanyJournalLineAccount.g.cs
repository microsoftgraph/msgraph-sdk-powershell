#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("GET", "/financials/companies/{company-id}/journalLines/{journalLine-id}/account", ParameterSetName = "RootGet")]
    [GraphRoute("GET", "/financials/companies/{company-id}/journals/{journal-id}/journalLines/{journalLine-id}/account", ParameterSetName = "NestedGet")]
    [Cmdlet(VerbsCommon.Get, "MgFinancialCompanyJournalLineAccount", DefaultParameterSetName = "RootGet")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.Account), ParameterSetName = new[] { "RootGet" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.Account), ParameterSetName = new[] { "NestedGet" })]
    public class GetMgFinancialCompanyJournalLineAccountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "RootGet", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedGet", Position = 0)]
        public string CompanyId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "RootGet", Position = 1)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedGet", Position = 2)]
        public string JournalLineId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "RootGet")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedGet")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootGet")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedGet")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "NestedGet", Position = 1)]
        public string JournalId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootGet" => "Get-MgFinancialCompanyJournalLineAccount_Route0",
                "NestedGet" => "Get-MgFinancialCompanyJournalLineAccount_Route1",
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
