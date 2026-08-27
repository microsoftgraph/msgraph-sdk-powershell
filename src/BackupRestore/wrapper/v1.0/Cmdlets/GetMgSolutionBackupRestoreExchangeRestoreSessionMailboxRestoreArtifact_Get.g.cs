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
    [GraphRoute("GET", "/solutions/backupRestore/exchangeRestoreSessions/{exchangeRestoreSession-id}/mailboxRestoreArtifacts/{mailboxRestoreArtifact-id}")]
    [Cmdlet(VerbsCommon.Get, "MgSolutionBackupRestoreExchangeRestoreSessionMailboxRestoreArtifact_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.MailboxRestoreArtifact))]
    public class GetMgSolutionBackupRestoreExchangeRestoreSessionMailboxRestoreArtifact_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ExchangeRestoreSessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MailboxRestoreArtifactId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.MailboxRestoreArtifact? result;
            try
            {
                result = client.Solutions.BackupRestore.ExchangeRestoreSessions[ExchangeRestoreSessionId].MailboxRestoreArtifacts[MailboxRestoreArtifactId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, MailboxRestoreArtifactId);
                return;
            }

            WriteObject(result);
        }
    }
}
