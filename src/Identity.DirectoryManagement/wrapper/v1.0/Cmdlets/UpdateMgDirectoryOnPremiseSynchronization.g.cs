#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/directory/onPremisesSynchronization/{onPremisesDirectorySynchronization-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryOnPremiseSynchronization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OnPremisesDirectorySynchronization))]
    public class UpdateMgDirectoryOnPremiseSynchronizationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnPremisesDirectorySynchronizationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OnPremisesDirectorySynchronizationConfiguration? Configuration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OnPremisesDirectorySynchronizationFeature? Features { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnPremisesDirectorySynchronizationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OnPremisesDirectorySynchronization();


    if (this.IsParameterBound(nameof(Configuration)))
        body.Configuration = Configuration;

    if (this.IsParameterBound(nameof(Features)))
        body.Features = Features;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OnPremisesDirectorySynchronization? result;
            try
            {
                result = client.Directory.OnPremisesSynchronization[OnPremisesDirectorySynchronizationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, OnPremisesDirectorySynchronizationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.OnPremisesSynchronization[OnPremisesDirectorySynchronizationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, OnPremisesDirectorySynchronizationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
