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
    [GraphRoute("PATCH", "/users/{user-id}/authentication/emailMethods/{emailAuthenticationMethod-id}")]
    [Cmdlet(VerbsData.Update, "MgUserAuthenticationEmailMethod", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.EmailAuthenticationMethod))]
    public class UpdateMgUserAuthenticationEmailMethodCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EmailAuthenticationMethodId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? EmailAddress { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EmailAuthenticationMethodId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.EmailAuthenticationMethod();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(EmailAddress)))
        body.EmailAddress = EmailAddress;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.EmailAuthenticationMethod? result;
            try
            {
                result = client.Users[UserId].Authentication.EmailMethods[EmailAuthenticationMethodId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EmailAuthenticationMethodId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Authentication.EmailMethods[EmailAuthenticationMethodId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, EmailAuthenticationMethodId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
