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
    [GraphRoute("PATCH", "/directory/sharedEmailDomains/{sharedEmailDomain-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectorySharedEmailDomain", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SharedEmailDomain))]
    public class UpdateMgDirectorySharedEmailDomainCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharedEmailDomainId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ProvisioningStatus { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SharedEmailDomainId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SharedEmailDomain();

    if (this.IsParameterBound(nameof(ProvisioningStatus)))
        body.ProvisioningStatus = ProvisioningStatus;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SharedEmailDomain? result;
            try
            {
                result = client.Directory.SharedEmailDomains[SharedEmailDomainId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SharedEmailDomainId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.SharedEmailDomains[SharedEmailDomainId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SharedEmailDomainId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
