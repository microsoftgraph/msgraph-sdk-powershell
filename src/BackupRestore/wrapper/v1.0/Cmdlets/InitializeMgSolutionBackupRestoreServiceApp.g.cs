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
    [GraphRoute("POST", "/solutions/backupRestore/serviceApps/{serviceApp-id}/activate")]
    [Cmdlet(VerbsData.Initialize, "MgSolutionBackupRestoreServiceApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ServiceApp))]
    public class InitializeMgSolutionBackupRestoreServiceAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServiceAppId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EffectiveDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServiceAppId, "Initialize"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.BackupRestore.Client.Solutions.BackupRestore.ServiceApps.Item.Activate.ActivatePostRequestBody();

    if (this.IsParameterBound(nameof(EffectiveDateTime)))
        body.EffectiveDateTime = EffectiveDateTime;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ServiceApp? result;
            try
            {
                result = client.Solutions.BackupRestore.ServiceApps[ServiceAppId].Activate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ServiceAppId);
                return;
            }

            WriteObject(result);
        }
    }
}
