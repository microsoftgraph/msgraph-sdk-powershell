#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Migrations.Client;
using Microsoft.Graph.PowerShell.Migrations.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Migrations
{
    [GraphRoute("POST", "/solutions/migrations/crossTenantMigrationJobs/{crossTenantMigrationJob-id}/cancel")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgMigrationCrossTenantMigrationJobCancel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationCancelResponse))]
    public class InvokeMgMigrationCrossTenantMigrationJobCancelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CrossTenantMigrationJobId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CrossTenantMigrationJobId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationCancelResponse? result;
            try
            {
                result = client.Solutions.Migrations.CrossTenantMigrationJobs[CrossTenantMigrationJobId].Cancel.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CrossTenantMigrationJobId);
                return;
            }

            WriteObject(result);
        }
    }
}
