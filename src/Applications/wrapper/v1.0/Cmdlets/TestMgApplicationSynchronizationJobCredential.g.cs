#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/applications/{application-id}/synchronization/jobs/{synchronizationJob-id}/validateCredentials")]
    [Cmdlet(VerbsDiagnostic.Test, "MgApplicationSynchronizationJobCredential", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class TestMgApplicationSynchronizationJobCredentialCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationJobId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ApplicationIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? TemplateId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? UseSavedCredentials { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationSecretKeyStringValuePair[]? Credentials { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SynchronizationJobId, "Test"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.Synchronization.Jobs.Item.ValidateCredentials.ValidateCredentialsPostRequestBody();

    if (this.IsParameterBound(nameof(ApplicationIdentifier)))
        body.ApplicationIdentifier = ApplicationIdentifier;

    if (this.IsParameterBound(nameof(TemplateId)))
        body.TemplateId = TemplateId;

    if (this.IsParameterBound(nameof(UseSavedCredentials)))
        body.UseSavedCredentials = UseSavedCredentials;
    if (this.IsParameterBound(nameof(Credentials)))
        body.Credentials = Credentials!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Applications[ApplicationId].Synchronization.Jobs[SynchronizationJobId].ValidateCredentials.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, SynchronizationJobId);
                return;
            }

        }
    }
}
