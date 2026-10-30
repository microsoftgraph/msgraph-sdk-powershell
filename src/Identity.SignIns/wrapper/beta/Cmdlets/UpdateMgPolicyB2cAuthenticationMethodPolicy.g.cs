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
    [GraphRoute("PATCH", "/policies/b2cAuthenticationMethodsPolicy")]
    [Cmdlet(VerbsData.Update, "MgPolicyB2cAuthenticationMethodPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.B2cAuthenticationMethodsPolicy))]
    public class UpdateMgPolicyB2cAuthenticationMethodPolicyCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? IsEmailPasswordAuthenticationEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsPhoneOneTimePasswordAuthenticationEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsUserNameAuthenticationEnabled { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.B2cAuthenticationMethodsPolicy();

    if (this.IsParameterBound(nameof(IsEmailPasswordAuthenticationEnabled)))
        body.IsEmailPasswordAuthenticationEnabled = IsEmailPasswordAuthenticationEnabled;

    if (this.IsParameterBound(nameof(IsPhoneOneTimePasswordAuthenticationEnabled)))
        body.IsPhoneOneTimePasswordAuthenticationEnabled = IsPhoneOneTimePasswordAuthenticationEnabled;

    if (this.IsParameterBound(nameof(IsUserNameAuthenticationEnabled)))
        body.IsUserNameAuthenticationEnabled = IsUserNameAuthenticationEnabled;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.B2cAuthenticationMethodsPolicy? result;
            try
            {
                result = client.Policies.B2cAuthenticationMethodsPolicy.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.B2cAuthenticationMethodsPolicy.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
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
