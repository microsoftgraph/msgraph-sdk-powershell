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
    [GraphRoute("GET", "/solutions/backupRestore/protectionUnits/{protectionUnitBase-id}/graph.mailboxProtectionUnit")]
    [Cmdlet(VerbsCommon.Get, "MgSolutionBackupRestoreProtectionUnitAsMailboxProtectionUnit_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.MailboxProtectionUnit))]
    public class GetMgSolutionBackupRestoreProtectionUnitAsMailboxProtectionUnit_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ProtectionUnitBaseId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.MailboxProtectionUnit? result;
            try
            {
                result = client.Solutions.BackupRestore.ProtectionUnits[ProtectionUnitBaseId].GraphMailboxProtectionUnit.GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, ProtectionUnitBaseId);
                return;
            }

            WriteObject(result);
        }
    }
}
