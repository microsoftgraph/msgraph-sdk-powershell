#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.BackupRestore.Client;
using Microsoft.Graph.PowerShell.BackupRestore.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.BackupRestore
{
    [GraphRoute("GET", "/solutions/backupRestore/sharePointProtectionPolicies/{sharePointProtectionPolicy-id}/siteExclusionUnitsBulkAdditionJobs/{siteExclusionUnitsBulkAdditionJob-id}")]
    [Cmdlet(VerbsCommon.Get, "MgSolutionBackupRestoreSharePointProtectionPolicySiteExclusionUnitBulkAdditionJob_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.SiteExclusionUnitsBulkAdditionJob))]
    public class GetMgSolutionBackupRestoreSharePointProtectionPolicySiteExclusionUnitBulkAdditionJob_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharePointProtectionPolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteExclusionUnitsBulkAdditionJobId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.SiteExclusionUnitsBulkAdditionJob? result;
            try
            {
                result = client.Solutions.BackupRestore.SharePointProtectionPolicies[SharePointProtectionPolicyId].SiteExclusionUnitsBulkAdditionJobs[SiteExclusionUnitsBulkAdditionJobId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SiteExclusionUnitsBulkAdditionJobId);
                return;
            }

            WriteObject(result);
        }
    }
}
