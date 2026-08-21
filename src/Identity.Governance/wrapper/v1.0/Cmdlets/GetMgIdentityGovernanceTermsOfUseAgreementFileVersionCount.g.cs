#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/identityGovernance/termsOfUse/agreements/{agreement-id}/files/{agreementFileLocalization-id}/versions/$count")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityGovernanceTermsOfUseAgreementFileVersionCount")]
    [OutputType(typeof(int))]
    public class GetMgIdentityGovernanceTermsOfUseAgreementFileVersionCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AgreementId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AgreementFileLocalizationId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.IdentityGovernance.TermsOfUse.Agreements[AgreementId].Files[AgreementFileLocalizationId].Versions.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AgreementFileLocalizationId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
