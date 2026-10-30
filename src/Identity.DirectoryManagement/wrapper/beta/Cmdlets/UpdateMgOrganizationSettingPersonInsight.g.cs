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
    [GraphRoute("PATCH", "/organization/{organization-id}/settings/peopleInsights")]
    [Cmdlet(VerbsData.Update, "MgOrganizationSettingPersonInsight", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.InsightsSettings))]
    public class UpdateMgOrganizationSettingPersonInsightCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrganizationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisabledForGroup { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabledInOrganization { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrganizationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.InsightsSettings();

    if (this.IsParameterBound(nameof(DisabledForGroup)))
        body.DisabledForGroup = DisabledForGroup;

    if (this.IsParameterBound(nameof(IsEnabledInOrganization)))
        body.IsEnabledInOrganization = IsEnabledInOrganization;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.InsightsSettings? result;
            try
            {
                result = client.Organization[OrganizationId].Settings.PeopleInsights.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OrganizationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Organization[OrganizationId].Settings.PeopleInsights.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, OrganizationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
