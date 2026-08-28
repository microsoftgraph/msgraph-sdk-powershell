#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/agreements/{agreement-id}/file/localizations/{agreementFileLocalization-id}/versions/{agreementFileVersion-id}")]
    [Cmdlet(VerbsCommon.Get, "MgAgreementFileLocalizationVersion_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementFileVersion))]
    public class GetMgAgreementFileLocalizationVersion_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AgreementId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AgreementFileLocalizationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AgreementFileVersionId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementFileVersion? result;
            try
            {
                result = client.Agreements[AgreementId].File.Localizations[AgreementFileLocalizationId].Versions[AgreementFileVersionId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AgreementFileVersionId);
                return;
            }

            WriteObject(result);
        }
    }
}
