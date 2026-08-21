#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/teamwork/workforceIntegrations")]
    [Cmdlet(VerbsCommon.New, "MgTeamworkWorkforceIntegration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.WorkforceIntegration))]
    public class NewMgTeamworkWorkforceIntegrationCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public int? ApiVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsActive { get; set; }

        [Parameter(Mandatory = false)]
        public string? Url { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.EligibilityFilteringEnabledEntities? EligibilityFilteringEnabledEntities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.WorkforceIntegrationEncryption? Encryption { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.WorkforceIntegrationSupportedEntities? SupportedEntities { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.WorkforceIntegration();

    if (this.IsParameterBound(nameof(ApiVersion)))
        body.ApiVersion = ApiVersion;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsActive)))
        body.IsActive = IsActive;

    if (this.IsParameterBound(nameof(Url)))
        body.Url = Url;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(EligibilityFilteringEnabledEntities)))
        body.EligibilityFilteringEnabledEntities = EligibilityFilteringEnabledEntities;

    if (this.IsParameterBound(nameof(Encryption)))
        body.Encryption = Encryption;

    if (this.IsParameterBound(nameof(SupportedEntities)))
        body.SupportedEntities = SupportedEntities;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.WorkforceIntegration? result;
            try
            {
                result = client.Teamwork.WorkforceIntegrations.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
