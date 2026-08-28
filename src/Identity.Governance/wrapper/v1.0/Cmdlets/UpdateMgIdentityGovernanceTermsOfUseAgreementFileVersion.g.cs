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
    [GraphRoute("PATCH", "/identityGovernance/termsOfUse/agreements/{agreement-id}/files/{agreementFileLocalization-id}/versions/{agreementFileVersion-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceTermsOfUseAgreementFileVersion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementFileVersion))]
    public class UpdateMgIdentityGovernanceTermsOfUseAgreementFileVersionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AgreementId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AgreementFileLocalizationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AgreementFileVersionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? FileName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDefault { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMajorVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? Language { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementFileData? FileData { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AgreementFileVersionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementFileVersion();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(FileName)))
        body.FileName = FileName;

    if (this.IsParameterBound(nameof(IsDefault)))
        body.IsDefault = IsDefault;

    if (this.IsParameterBound(nameof(IsMajorVersion)))
        body.IsMajorVersion = IsMajorVersion;

    if (this.IsParameterBound(nameof(Language)))
        body.Language = Language;

    if (this.IsParameterBound(nameof(FileData)))
        body.FileData = FileData;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementFileVersion? result;
            try
            {
                result = client.IdentityGovernance.TermsOfUse.Agreements[AgreementId].Files[AgreementFileLocalizationId].Versions[AgreementFileVersionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AgreementFileVersionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.TermsOfUse.Agreements[AgreementId].Files[AgreementFileLocalizationId].Versions[AgreementFileVersionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, AgreementFileVersionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
