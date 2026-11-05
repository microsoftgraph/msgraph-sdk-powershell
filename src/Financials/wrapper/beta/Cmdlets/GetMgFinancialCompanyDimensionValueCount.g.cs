#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Financials
{
    [GraphRoute("GET", "/financials/companies/{company-id}/dimensionValues/$count", ParameterSetName = "RootScalar")]
    [GraphRoute("GET", "/financials/companies/{company-id}/dimensions/{dimension-id}/dimensionValues/$count", ParameterSetName = "NestedScalar")]
    [Cmdlet(VerbsCommon.Get, "MgFinancialCompanyDimensionValueCount", DefaultParameterSetName = "RootScalar")]
    [OutputType(typeof(int), ParameterSetName = new[] { "RootScalar" })]
    [OutputType(typeof(int), ParameterSetName = new[] { "NestedScalar" })]
    public class GetMgFinancialCompanyDimensionValueCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "RootScalar", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "NestedScalar", Position = 0)]
        public string CompanyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "RootScalar")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedScalar")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootScalar")]
        [Parameter(Mandatory = false, ParameterSetName = "NestedScalar")]
        public string? Search { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "NestedScalar", Position = 1)]
        public string DimensionId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootScalar" => "Get-MgFinancialCompanyDimensionValueCount_Route0",
                "NestedScalar" => "Get-MgFinancialCompanyDimensionValueCount_Route1",
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
