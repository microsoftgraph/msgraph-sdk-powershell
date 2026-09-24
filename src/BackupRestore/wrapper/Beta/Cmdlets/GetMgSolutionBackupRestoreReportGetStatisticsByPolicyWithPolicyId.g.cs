#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/solutions/backupRestore/reports/getStatisticsByPolicy(policyId='{policyId}')")]
    [Cmdlet(VerbsCommon.Get, "MgSolutionBackupRestoreReportGetStatisticsByPolicyWithPolicyId")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.BackupPolicyReport))]
    public class GetMgSolutionBackupRestoreReportGetStatisticsByPolicyWithPolicyIdCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'policyId' parameter of this OData function.")]
        public string PolicyId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "policyId", PolicyId },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.BackupRestore.Client.Solutions.BackupRestore.Reports.GetStatisticsByPolicyWithPolicyId.GetStatisticsByPolicyWithPolicyIdRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.BackupPolicyReport? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
