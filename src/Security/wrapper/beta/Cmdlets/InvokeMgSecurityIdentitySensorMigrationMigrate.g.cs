#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/identities/sensorMigration/microsoft.graph.security.migrate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityIdentitySensorMigrationMigrate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.MigrateSensorsResult))]
    public class InvokeMgSecurityIdentitySensorMigrationMigrateCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? SensorIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.Identities.SensorMigration.MicrosoftGraphSecurityMigrate.MigratePostRequestBody();

    if (this.IsParameterBound(nameof(SensorIds)))
        body.SensorIds = SensorIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.MigrateSensorsResult? result;
            try
            {
                result = client.Security.Identities.SensorMigration.MicrosoftGraphSecurityMigrate.PostAsync(body, requestConfiguration =>
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
