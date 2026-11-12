#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("PATCH", "/financials/companies/{company-id}/journalLines/{journalLine-id}", ParameterSetName = "RootUpdate")]
    [GraphRoute("PATCH", "/financials/companies/{company-id}/journals/{journal-id}/journalLines/{journalLine-id}", ParameterSetName = "NestedUpdate")]
    [Cmdlet(VerbsData.Update, "MgFinancialCompanyJournalLine", DefaultParameterSetName = "RootUpdate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.JournalLine), ParameterSetName = new[] { "RootUpdate" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.JournalLine), ParameterSetName = new[] { "NestedUpdate" })]
    public class UpdateMgFinancialCompanyJournalLineCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "RootUpdate", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedUpdate", Position = 0)]
        public string CompanyId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "RootUpdate", Position = 1)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedUpdate", Position = 2)]
        public string JournalLineId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public global::System.Guid? AccountId { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public string? AccountNumber { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public decimal? Amount { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public string? Comment { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public string? Description { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public string? DocumentNumber { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public string? ExternalDocumentNumber { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public string? JournalDisplayName { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public int? LineNumber { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedUpdate")]
        public global::Microsoft.Kiota.Abstractions.Date? PostingDate { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "NestedUpdate", Position = 1)]
        public string JournalId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootUpdate" => "Update-MgFinancialCompanyJournalLine_Route0",
                "NestedUpdate" => "Update-MgFinancialCompanyJournalLine_Route1",
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
