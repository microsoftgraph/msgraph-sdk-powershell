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
    [GraphRoute("GET", "/solutions/backupRestore/oneDriveForBusinessProtectionPolicies/{oneDriveForBusinessProtectionPolicy-id}")]
    [Cmdlet(VerbsCommon.Get, "MgSolutionBackupRestoreOneDriveForBusinessProtectionPolicy_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.OneDriveForBusinessProtectionPolicy))]
    public class GetMgSolutionBackupRestoreOneDriveForBusinessProtectionPolicy_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OneDriveForBusinessProtectionPolicyId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.OneDriveForBusinessProtectionPolicy? result;
            try
            {
                result = client.Solutions.BackupRestore.OneDriveForBusinessProtectionPolicies[OneDriveForBusinessProtectionPolicyId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, OneDriveForBusinessProtectionPolicyId);
                return;
            }

            WriteObject(result);
        }
    }
}
