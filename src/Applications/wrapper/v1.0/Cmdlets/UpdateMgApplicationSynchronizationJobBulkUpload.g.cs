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
    [GraphRoute("PATCH", "/applications/{application-id}/synchronization/jobs/{synchronizationJob-id}/bulkUpload")]
    [Cmdlet(VerbsData.Update, "MgApplicationSynchronizationJobBulkUpload", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.BulkUpload))]
    public class UpdateMgApplicationSynchronizationJobBulkUploadCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationJobId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SynchronizationJobId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.BulkUpload();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.BulkUpload? result;
            try
            {
                result = client.Applications[ApplicationId].Synchronization.Jobs[SynchronizationJobId].BulkUpload.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SynchronizationJobId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Applications[ApplicationId].Synchronization.Jobs[SynchronizationJobId].BulkUpload.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, SynchronizationJobId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
