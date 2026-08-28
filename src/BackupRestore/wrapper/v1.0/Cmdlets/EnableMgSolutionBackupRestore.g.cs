#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/solutions/backupRestore/enable")]
    [Cmdlet(VerbsLifecycle.Enable, "MgSolutionBackupRestore", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ServiceStatus))]
    public class EnableMgSolutionBackupRestoreCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AppOwnerTenantId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Enable"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.BackupRestore.Client.Solutions.BackupRestore.Enable.EnablePostRequestBody();

    if (this.IsParameterBound(nameof(AppOwnerTenantId)))
        body.AppOwnerTenantId = AppOwnerTenantId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ServiceStatus? result;
            try
            {
                result = client.Solutions.BackupRestore.Enable.PostAsync(body, requestConfiguration =>
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
