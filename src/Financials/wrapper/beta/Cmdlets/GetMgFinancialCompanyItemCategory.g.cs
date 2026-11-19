#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("GET", "/financials/companies/{company-id}/itemCategories", ParameterSetName = "RootList")]
    [GraphRoute("GET", "/financials/companies/{company-id}/itemCategories/{itemCategory-id}", ParameterSetName = "RootGet")]
    [GraphRoute("GET", "/financials/companies/{company-id}/items/{item-id}/itemCategory", ParameterSetName = "NestedGet")]
    [Cmdlet(VerbsCommon.Get, "MgFinancialCompanyItemCategory", DefaultParameterSetName = "RootList")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.ItemCategory), ParameterSetName = new[] { "RootList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.ItemCategory), ParameterSetName = new[] { "RootGet" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.ItemCategory), ParameterSetName = new[] { "NestedGet" })]
    public class GetMgFinancialCompanyItemCategoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "RootList", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "RootGet", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedGet", Position = 0)]
        public string CompanyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "RootGet")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedGet")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "RootGet")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedGet")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        public SwitchParameter Count { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        public SwitchParameter All { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "RootGet", Position = 1)]
        public string ItemCategoryId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "NestedGet", Position = 1)]
        public string ItemId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootList" => "Get-MgFinancialCompanyItemCategory_Route0",
                "RootGet" => "Get-MgFinancialCompanyItemCategory_Route1",
                "NestedGet" => "Get-MgFinancialCompanyItemCategory_Route2",
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
