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
    [GraphRoute("POST", "/oauth2PermissionGrants")]
    [Cmdlet(VerbsCommon.New, "MgOauth2PermissionGrant", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.OAuth2PermissionGrant))]
    public class NewMgOauth2PermissionGrantCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? ClientId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ConsentType { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Scope { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.OAuth2PermissionGrant();

    if (this.IsParameterBound(nameof(ClientId)))
        body.ClientId = ClientId;

    if (this.IsParameterBound(nameof(ConsentType)))
        body.ConsentType = ConsentType;

    if (this.IsParameterBound(nameof(PrincipalId)))
        body.PrincipalId = PrincipalId;

    if (this.IsParameterBound(nameof(ResourceId)))
        body.ResourceId = ResourceId;

    if (this.IsParameterBound(nameof(Scope)))
        body.Scope = Scope;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.OAuth2PermissionGrant? result;
            try
            {
                result = client.Oauth2PermissionGrants.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
