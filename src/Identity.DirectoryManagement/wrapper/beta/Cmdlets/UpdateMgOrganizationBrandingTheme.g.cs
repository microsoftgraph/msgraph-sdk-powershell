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
    [GraphRoute("PATCH", "/organization/{organization-id}/branding/themes/{organizationalBrandingTheme-id}")]
    [Cmdlet(VerbsData.Update, "MgOrganizationBrandingTheme", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrganizationalBrandingTheme))]
    public class UpdateMgOrganizationBrandingThemeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrganizationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OrganizationalBrandingThemeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsDefaultTheme { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrganizationalBrandingThemeId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrganizationalBrandingTheme();

    if (this.IsParameterBound(nameof(IsDefaultTheme)))
        body.IsDefaultTheme = IsDefaultTheme;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrganizationalBrandingTheme? result;
            try
            {
                result = client.Organization[OrganizationId].Branding.Themes[OrganizationalBrandingThemeId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OrganizationalBrandingThemeId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Organization[OrganizationId].Branding.Themes[OrganizationalBrandingThemeId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, OrganizationalBrandingThemeId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
