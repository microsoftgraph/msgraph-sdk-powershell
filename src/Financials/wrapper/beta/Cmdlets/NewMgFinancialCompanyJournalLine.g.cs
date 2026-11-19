#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("POST", "/financials/companies/{company-id}/journalLines", ParameterSetName = "RootNew")]
    [GraphRoute("POST", "/financials/companies/{company-id}/journals/{journal-id}/journalLines", ParameterSetName = "NestedNew")]
    [Cmdlet(VerbsCommon.New, "MgFinancialCompanyJournalLine", DefaultParameterSetName = "RootNew", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.JournalLine), ParameterSetName = new[] { "RootNew" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.JournalLine), ParameterSetName = new[] { "NestedNew" })]
    public class NewMgFinancialCompanyJournalLineCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "RootNew", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedNew", Position = 0)]
        public string CompanyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public global::System.Guid? AccountId { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public string? AccountNumber { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public decimal? Amount { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public string? Comment { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public string? Description { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public string? DocumentNumber { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public string? ExternalDocumentNumber { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public string? JournalDisplayName { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public int? LineNumber { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootNew")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedNew")]
        public global::Microsoft.Kiota.Abstractions.Date? PostingDate { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "NestedNew", Position = 1)]
        public string JournalId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootNew" => "New-MgFinancialCompanyJournalLine_Route0",
                "NestedNew" => "New-MgFinancialCompanyJournalLine_Route1",
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
