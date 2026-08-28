#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.BackupRestore.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.BackupRestore
{
    [GraphRoute("GET", "/solutions/backupRestore/exchangeProtectionPolicies/{exchangeProtectionPolicy-id}/mailboxProtectionUnits/$count")]
    [Cmdlet(VerbsCommon.Get, "MgSolutionBackupRestoreExchangeProtectionPolicyMailboxProtectionUnitCount")]
    [OutputType(typeof(int))]
    public class GetMgSolutionBackupRestoreExchangeProtectionPolicyMailboxProtectionUnitCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ExchangeProtectionPolicyId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.Solutions.BackupRestore.ExchangeProtectionPolicies[ExchangeProtectionPolicyId].MailboxProtectionUnits.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ExchangeProtectionPolicyId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
