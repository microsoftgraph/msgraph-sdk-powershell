#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("GET", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}/languages/{userFlowLanguageConfiguration-id}/defaultPages/{userFlowLanguagePage-id}/$value")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityB2XUserFlowLanguageDefaultPageContent")]
    [OutputType(typeof(byte[]))]
    public class GetMgIdentityB2XUserFlowLanguageDefaultPageContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2xIdentityUserFlowId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UserFlowLanguageConfigurationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string UserFlowLanguagePageId { get; set; } = string.Empty;






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
                result = client.Identity.B2xUserFlows[B2xIdentityUserFlowId].Languages[UserFlowLanguageConfigurationId].DefaultPages[UserFlowLanguagePageId].Content.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, UserFlowLanguagePageId);
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
