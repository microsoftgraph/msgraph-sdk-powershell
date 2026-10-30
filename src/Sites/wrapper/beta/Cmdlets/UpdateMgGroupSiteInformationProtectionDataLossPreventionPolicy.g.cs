#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("PATCH", "/groups/{group-id}/sites/{site-id}/informationProtection/dataLossPreventionPolicies/{dataLossPreventionPolicy-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupSiteInformationProtectionDataLossPreventionPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.DataLossPreventionPolicy))]
    public class UpdateMgGroupSiteInformationProtectionDataLossPreventionPolicyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DataLossPreventionPolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DataLossPreventionPolicyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.DataLossPreventionPolicy();

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.DataLossPreventionPolicy? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].InformationProtection.DataLossPreventionPolicies[DataLossPreventionPolicyId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DataLossPreventionPolicyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Sites[SiteId].InformationProtection.DataLossPreventionPolicies[DataLossPreventionPolicyId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DataLossPreventionPolicyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
