#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/security/identities/sensors/microsoft.graph.security.getDeploymentAccessKey()")]
    [Cmdlet(VerbsCommon.Get, "MgSecurityIdentitySensorGetDeploymentAccessKey")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.DeploymentAccessKeyType))]
    public class GetMgSecurityIdentitySensorGetDeploymentAccessKeyCommand : GraphClientCmdlet
    {










        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Security.Client.Models.Security.DeploymentAccessKeyType? result;
            try
            {
                result = client.Security.Identities.Sensors.MicrosoftGraphSecurityGetDeploymentAccessKey.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
