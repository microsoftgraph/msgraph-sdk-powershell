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
    [GraphRoute("PATCH", "/users/{user-id}/profile/certifications/{personCertification-id}")]
    [Cmdlet(VerbsData.Update, "MgUserProfileCertification", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.People.Client.Models.PersonCertification))]
    public class UpdateMgUserProfileCertificationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PersonCertificationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSearchable { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? CertificationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? EndDate { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? IssuedDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? IssuingAuthority { get; set; }

        [Parameter(Mandatory = false)]
        public string? IssuingCompany { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? StartDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? ThumbnailUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }

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






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PersonCertificationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.People.Client.Models.PersonCertification();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(IsSearchable)))
        body.IsSearchable = IsSearchable;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(CertificationId)))
        body.CertificationId = CertificationId;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EndDate)))
        body.EndDate = EndDate;

    if (this.IsParameterBound(nameof(IssuedDate)))
        body.IssuedDate = IssuedDate;

    if (this.IsParameterBound(nameof(IssuingAuthority)))
        body.IssuingAuthority = IssuingAuthority;

    if (this.IsParameterBound(nameof(IssuingCompany)))
        body.IssuingCompany = IssuingCompany;

    if (this.IsParameterBound(nameof(StartDate)))
        body.StartDate = StartDate;

    if (this.IsParameterBound(nameof(ThumbnailUrl)))
        body.ThumbnailUrl = ThumbnailUrl;

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;

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


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.People.Client.Models.PersonCertification? result;
            try
            {
                result = client.Users[UserId].Profile.Certifications[PersonCertificationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PersonCertificationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Profile.Certifications[PersonCertificationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PersonCertificationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
