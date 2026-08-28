#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.ConfigurationManagement.Client;
using Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.ConfigurationManagement
{
    [GraphRoute("PATCH", "/admin/configurationManagement/configurationSnapshotJobs/{configurationSnapshotJob-id}")]
    [Cmdlet(VerbsData.Update, "MgAdminConfigurationManagementConfigurationSnapshotJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationSnapshotJob))]
    public class UpdateMgAdminConfigurationManagementConfigurationSnapshotJobCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ConfigurationSnapshotJobId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Resources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.SnapshotJobStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ConfigurationSnapshotJobId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationSnapshotJob();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Resources)))
        body.Resources = Resources!.ToList();

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.ConfigurationManagement.Client.Models.ConfigurationSnapshotJob? result;
            try
            {
                result = client.Admin.ConfigurationManagement.ConfigurationSnapshotJobs[ConfigurationSnapshotJobId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ConfigurationSnapshotJobId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.ConfigurationManagement.ConfigurationSnapshotJobs[ConfigurationSnapshotJobId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ConfigurationSnapshotJobId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
