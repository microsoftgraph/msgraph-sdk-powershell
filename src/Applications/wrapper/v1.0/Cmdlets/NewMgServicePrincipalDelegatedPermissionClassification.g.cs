#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/servicePrincipals/{servicePrincipal-id}/delegatedPermissionClassifications")]
    [Cmdlet(VerbsCommon.New, "MgServicePrincipalDelegatedPermissionClassification", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.DelegatedPermissionClassification))]
    public class NewMgServicePrincipalDelegatedPermissionClassificationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? PermissionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PermissionName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.PermissionClassificationType? Classification { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.DelegatedPermissionClassification();

    if (this.IsParameterBound(nameof(PermissionId)))
        body.PermissionId = PermissionId;

    if (this.IsParameterBound(nameof(PermissionName)))
        body.PermissionName = PermissionName;

    if (this.IsParameterBound(nameof(Classification)))
        body.Classification = Classification;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.DelegatedPermissionClassification? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].DelegatedPermissionClassifications.PostAsync(body, requestConfiguration =>
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
