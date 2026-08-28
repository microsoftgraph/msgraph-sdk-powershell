#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("GET", "/organization/{organization-id}/branding/localizations/{organizationalBrandingLocalization-id}/headerLogo")]
    [Cmdlet(VerbsCommon.Get, "MgOrganizationBrandingLocalizationHeaderLogo")]
    [OutputType(typeof(byte[]))]
    public class GetMgOrganizationBrandingLocalizationHeaderLogoCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrganizationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OrganizationalBrandingLocalizationId { get; set; } = string.Empty;






        [Parameter(Mandatory = false,
            HelpMessage = "Writes the response content to this path instead of returning it as bytes.")]
        public string? OutFile { get; set; }

        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            System.IO.Stream? result;
            try
            {
                result = client.Organization[OrganizationId].Branding.Localizations[OrganizationalBrandingLocalizationId].HeaderLogo.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, OrganizationalBrandingLocalizationId);
                return;
            }

        if (result is not null)
        {
            using (result)
            {
                if (this.IsParameterBound(nameof(OutFile)))
                {
                    using var file = System.IO.File.Create(OutFile!);
                    result.CopyTo(file);
                }
                else
                {
                    using var buffer = new System.IO.MemoryStream();
                    result.CopyTo(buffer);
                    WriteObject(buffer.ToArray());
                }
            }
        }
        }
    }
}
