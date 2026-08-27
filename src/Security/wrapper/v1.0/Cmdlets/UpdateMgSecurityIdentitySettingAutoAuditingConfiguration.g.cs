#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/identities/settings/autoAuditingConfiguration")]
    [Cmdlet(VerbsData.Update, "MgSecurityIdentitySettingAutoAuditingConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.AutoAuditingConfiguration))]
    public class UpdateMgSecurityIdentitySettingAutoAuditingConfigurationCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? IsAutomatic { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.AutoAuditingConfiguration();

    if (this.IsParameterBound(nameof(IsAutomatic)))
        body.IsAutomatic = IsAutomatic;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.AutoAuditingConfiguration? result;
            try
            {
                result = client.Security.Identities.Settings.AutoAuditingConfiguration.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Identities.Settings.AutoAuditingConfiguration.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
