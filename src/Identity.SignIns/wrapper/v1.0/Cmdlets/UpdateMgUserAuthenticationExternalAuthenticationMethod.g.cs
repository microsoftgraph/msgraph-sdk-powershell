#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PATCH", "/users/{user-id}/authentication/externalAuthenticationMethods/{externalAuthenticationMethod-id}")]
    [Cmdlet(VerbsData.Update, "MgUserAuthenticationExternalAuthenticationMethod", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ExternalAuthenticationMethod))]
    public class UpdateMgUserAuthenticationExternalAuthenticationMethodCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ExternalAuthenticationMethodId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ConfigurationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ExternalAuthenticationMethodId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ExternalAuthenticationMethod();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(ConfigurationId)))
        body.ConfigurationId = ConfigurationId;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ExternalAuthenticationMethod? result;
            try
            {
                result = client.Users[UserId].Authentication.ExternalAuthenticationMethods[ExternalAuthenticationMethodId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ExternalAuthenticationMethodId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Authentication.ExternalAuthenticationMethods[ExternalAuthenticationMethodId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ExternalAuthenticationMethodId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
