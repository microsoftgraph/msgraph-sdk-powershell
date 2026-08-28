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
    [GraphRoute("POST", "/identityGovernance/termsOfUse/agreements/{agreement-id}/file/localizations")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernanceTermsOfUseAgreementFileLocalization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementFileLocalization))]
    public class NewMgIdentityGovernanceTermsOfUseAgreementFileLocalizationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AgreementId { get; set; } = string.Empty;

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
            if (!ShouldProcess(AgreementId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementFileLocalization();

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

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AgreementFileLocalization? result;
            try
            {
                result = client.IdentityGovernance.TermsOfUse.Agreements[AgreementId].File.Localizations.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
