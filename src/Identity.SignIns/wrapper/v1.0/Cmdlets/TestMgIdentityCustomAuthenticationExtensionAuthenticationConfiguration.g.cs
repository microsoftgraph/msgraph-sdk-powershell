#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/identity/customAuthenticationExtensions/{customAuthenticationExtension-id}/validateAuthenticationConfiguration")]
    [Cmdlet(VerbsDiagnostic.Test, "MgIdentityCustomAuthenticationExtensionAuthenticationConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationConfigurationValidation))]
    public class TestMgIdentityCustomAuthenticationExtensionAuthenticationConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CustomAuthenticationExtensionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomAuthenticationExtensionId, "Test"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationConfigurationValidation? result;
            try
            {
                result = client.Identity.CustomAuthenticationExtensions[CustomAuthenticationExtensionId].ValidateAuthenticationConfiguration.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CustomAuthenticationExtensionId);
                return;
            }

            WriteObject(result);
        }
    }
}
