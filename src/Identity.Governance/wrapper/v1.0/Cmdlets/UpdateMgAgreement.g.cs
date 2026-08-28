#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("PATCH", "/agreements/{agreement-id}")]
    [Cmdlet(VerbsData.Update, "MgAgreement", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Agreement))]
    public class UpdateMgAgreementCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AgreementId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsPerDeviceAcceptanceRequired { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsViewingBeforeAcceptanceRequired { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? UserReacceptRequiredFrequency { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.TermsExpiration? TermsExpiration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AgreementId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Agreement();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsPerDeviceAcceptanceRequired)))
        body.IsPerDeviceAcceptanceRequired = IsPerDeviceAcceptanceRequired;

    if (this.IsParameterBound(nameof(IsViewingBeforeAcceptanceRequired)))
        body.IsViewingBeforeAcceptanceRequired = IsViewingBeforeAcceptanceRequired;

    if (this.IsParameterBound(nameof(UserReacceptRequiredFrequency)))
        body.UserReacceptRequiredFrequency = UserReacceptRequiredFrequency;

    if (this.IsParameterBound(nameof(TermsExpiration)))
        body.TermsExpiration = TermsExpiration;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Agreement? result;
            try
            {
                result = client.Agreements[AgreementId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AgreementId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Agreements[AgreementId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, AgreementId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
