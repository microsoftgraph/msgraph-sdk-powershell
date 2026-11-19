#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("GET", "/financials/companies/{company-id}/dimensionValues", ParameterSetName = "RootList")]
    [GraphRoute("GET", "/financials/companies/{company-id}/dimensionValues/{dimensionValue-id}", ParameterSetName = "RootGet")]
    [GraphRoute("GET", "/financials/companies/{company-id}/dimensions/{dimension-id}/dimensionValues", ParameterSetName = "NestedList")]
    [GraphRoute("GET", "/financials/companies/{company-id}/dimensions/{dimension-id}/dimensionValues/{dimensionValue-id}", ParameterSetName = "NestedGet")]
    [Cmdlet(VerbsCommon.Get, "MgFinancialCompanyDimensionValue", DefaultParameterSetName = "RootList")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.DimensionValue), ParameterSetName = new[] { "RootList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.DimensionValue), ParameterSetName = new[] { "RootGet" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.DimensionValue), ParameterSetName = new[] { "NestedList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Financials.Client.Models.DimensionValue), ParameterSetName = new[] { "NestedGet" })]
    public class GetMgFinancialCompanyDimensionValueCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "RootList", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "RootGet", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedList", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedGet", Position = 0)]
        public string CompanyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedList")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "RootGet")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedList")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedGet")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "RootGet")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedList")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedGet")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedList")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedList")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedList")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedList")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedList")]
        public SwitchParameter Count { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedList")]
        public SwitchParameter All { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "RootGet", Position = 1)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedGet", Position = 2)]
        public string DimensionValueId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "NestedList", Position = 1)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedGet", Position = 1)]
        public string DimensionId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootList" => "Get-MgFinancialCompanyDimensionValue_Route0",
                "RootGet" => "Get-MgFinancialCompanyDimensionValue_Route1",
                "NestedList" => "Get-MgFinancialCompanyDimensionValue_Route2",
                "NestedGet" => "Get-MgFinancialCompanyDimensionValue_Route3",
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
