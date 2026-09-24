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
    [GraphRoute("PATCH", "/users/{user-id}/profile/positions/{workPosition-id}")]
    [Cmdlet(VerbsData.Update, "MgUserProfilePosition", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.People.Client.Models.WorkPosition))]
    public class UpdateMgUserProfilePositionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string WorkPositionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSearchable { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Categories { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCurrent { get; set; }

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
        public Microsoft.Graph.PowerShell.People.Client.Models.RelatedPerson[]? Colleagues { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.PositionDetail? Detail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.People.Client.Models.RelatedPerson? Manager { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkPositionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.People.Client.Models.WorkPosition();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(IsSearchable)))
        body.IsSearchable = IsSearchable;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Categories)))
        body.Categories = Categories!.ToList();

    if (this.IsParameterBound(nameof(IsCurrent)))
        body.IsCurrent = IsCurrent;

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

    if (this.IsParameterBound(nameof(Colleagues)))
        body.Colleagues = Colleagues!.ToList();

    if (this.IsParameterBound(nameof(Detail)))
        body.Detail = Detail;

    if (this.IsParameterBound(nameof(Manager)))
        body.Manager = Manager;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.People.Client.Models.WorkPosition? result;
            try
            {
                result = client.Users[UserId].Profile.Positions[WorkPositionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkPositionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Profile.Positions[WorkPositionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WorkPositionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
