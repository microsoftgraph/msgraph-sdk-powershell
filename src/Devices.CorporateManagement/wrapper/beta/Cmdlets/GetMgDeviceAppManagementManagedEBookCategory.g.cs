#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("GET", "/deviceAppManagement/managedEBookCategories", ParameterSetName = "RootList")]
    [GraphRoute("GET", "/deviceAppManagement/managedEBookCategories/{managedEBookCategory-id}", ParameterSetName = "RootGet")]
    [GraphRoute("GET", "/deviceAppManagement/managedEBooks/{managedEBook-id}/categories", ParameterSetName = "EBookList")]
    [GraphRoute("GET", "/deviceAppManagement/managedEBooks/{managedEBook-id}/categories/{managedEBookCategory-id}", ParameterSetName = "EBookGet")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceAppManagementManagedEBookCategory", DefaultParameterSetName = "RootList")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedEBookCategory), ParameterSetName = new[] { "RootList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedEBookCategory), ParameterSetName = new[] { "RootGet" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedEBookCategory), ParameterSetName = new[] { "EBookList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedEBookCategory), ParameterSetName = new[] { "EBookGet" })]
    public class GetMgDeviceAppManagementManagedEBookCategoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookList")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "RootGet")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookList")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookGet")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "RootGet")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookList")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookGet")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookList")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookList")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookList")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookList")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookList")]
        public SwitchParameter Count { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookList")]
        public SwitchParameter All { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "RootGet", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "EBookGet", Position = 1)]
        public string ManagedEBookCategoryId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "EBookList", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "EBookGet", Position = 0)]
        public string ManagedEBookId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootList" => "Get-MgDeviceAppManagementManagedEBookCategory_Route0",
                "RootGet" => "Get-MgDeviceAppManagementManagedEBookCategory_Route1",
                "EBookList" => "Get-MgDeviceAppManagementManagedEBookCategory_Route2",
                "EBookGet" => "Get-MgDeviceAppManagementManagedEBookCategory_Route3",
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
