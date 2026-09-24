#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.People.Client;
using Microsoft.Graph.PowerShell.People.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.People
{
    [GraphRoute("POST", "/users/{user-id}/profile/account")]
    [Cmdlet(VerbsCommon.New, "MgUserProfileAccount", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.People.Client.Models.UserAccountInformation))]
    public class NewMgUserProfileAccountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSearchable { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? AgeGroup { get; set; }

        [Parameter(Mandatory = false)]
        public string? CountryCode { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.AllowedAudiences? AllowedAudiences { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.InferenceData? Inference { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.PersonDataSources? Source { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.ProfileSourceAnnotation[]? Sources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.OriginTenantInfo? OriginTenantInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.LocaleInfo? PreferredLanguageTag { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.UserPersona? UserPersona { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.People.Client.Models.UserAccountInformation();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(IsSearchable)))
        body.IsSearchable = IsSearchable;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(AgeGroup)))
        body.AgeGroup = AgeGroup;

    if (this.IsParameterBound(nameof(CountryCode)))
        body.CountryCode = CountryCode;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(AllowedAudiences)))
        body.AllowedAudiences = AllowedAudiences;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Inference)))
        body.Inference = Inference;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(Sources)))
        body.Sources = Sources!.ToList();

    if (this.IsParameterBound(nameof(OriginTenantInfo)))
        body.OriginTenantInfo = OriginTenantInfo;

    if (this.IsParameterBound(nameof(PreferredLanguageTag)))
        body.PreferredLanguageTag = PreferredLanguageTag;

    if (this.IsParameterBound(nameof(UserPersona)))
        body.UserPersona = UserPersona;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.People.Client.Models.UserAccountInformation? result;
            try
            {
                result = client.Users[UserId].Profile.Account.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
