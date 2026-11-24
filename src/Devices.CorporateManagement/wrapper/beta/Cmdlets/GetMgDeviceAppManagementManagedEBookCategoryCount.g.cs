#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("GET", "/deviceAppManagement/managedEBookCategories/$count", ParameterSetName = "RootScalar")]
    [GraphRoute("GET", "/deviceAppManagement/managedEBooks/{managedEBook-id}/categories/$count", ParameterSetName = "EBookScalar")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceAppManagementManagedEBookCategoryCount", DefaultParameterSetName = "RootScalar")]
    [OutputType(typeof(int), ParameterSetName = new[] { "RootScalar" })]
    [OutputType(typeof(int), ParameterSetName = new[] { "EBookScalar" })]
    public class GetMgDeviceAppManagementManagedEBookCategoryCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = "RootScalar")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookScalar")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootScalar")]
        [Parameter(Mandatory = false, ParameterSetName = "EBookScalar")]
        public string? Search { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "EBookScalar", Position = 0)]
        public string ManagedEBookId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootScalar" => "Get-MgDeviceAppManagementManagedEBookCategoryCount_Route0",
                "EBookScalar" => "Get-MgDeviceAppManagementManagedEBookCategoryCount_Route1",
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
