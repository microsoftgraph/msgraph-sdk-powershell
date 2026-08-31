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
    [GraphRoute("POST", "/organization/{organization-id}/certificateBasedAuthConfiguration")]
    [Cmdlet(VerbsCommon.New, "MgOrganizationCertificateBasedAuthConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CertificateBasedAuthConfiguration))]
    public class NewMgOrganizationCertificateBasedAuthConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrganizationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CertificateAuthority[]? CertificateAuthorities { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrganizationId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CertificateBasedAuthConfiguration();


    if (this.IsParameterBound(nameof(CertificateAuthorities)))
        body.CertificateAuthorities = CertificateAuthorities!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CertificateBasedAuthConfiguration? result;
            try
            {
                result = client.Organization[OrganizationId].CertificateBasedAuthConfiguration.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
