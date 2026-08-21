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
    [GraphRoute("POST", "/servicePrincipals/{servicePrincipal-id}/synchronization/templates")]
    [Cmdlet(VerbsCommon.New, "MgServicePrincipalSynchronizationTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationTemplate))]
    public class NewMgServicePrincipalSynchronizationTemplateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.Guid? ApplicationId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Default { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Discoverable { get; set; }

        [Parameter(Mandatory = false)]
        public string? FactoryTag { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationMetadataEntry[]? Metadata { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationTemplate();

    if (this.IsParameterBound(nameof(ApplicationId)))
        body.ApplicationId = ApplicationId;

    if (this.IsParameterBound(nameof(Default)))
        body.Default = Default;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(Discoverable)))
        body.Discoverable = Discoverable;

    if (this.IsParameterBound(nameof(FactoryTag)))
        body.FactoryTag = FactoryTag;

    if (this.IsParameterBound(nameof(Metadata)))
        body.Metadata = Metadata!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationTemplate? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].Synchronization.Templates.PostAsync(body, requestConfiguration =>
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
