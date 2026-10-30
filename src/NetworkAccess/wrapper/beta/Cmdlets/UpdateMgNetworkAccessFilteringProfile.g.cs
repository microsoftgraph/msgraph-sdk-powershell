#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("PATCH", "/networkAccess/filteringProfiles/{filteringProfile-id}")]
    [Cmdlet(VerbsData.Update, "MgNetworkAccessFilteringProfile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.FilteringProfile))]
    public class UpdateMgNetworkAccessFilteringProfileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string FilteringProfileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public long? Priority { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Status? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(FilteringProfileId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.FilteringProfile();

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Priority)))
        body.Priority = Priority;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.FilteringProfile? result;
            try
            {
                result = client.NetworkAccess.FilteringProfiles[FilteringProfileId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, FilteringProfileId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.NetworkAccess.FilteringProfiles[FilteringProfileId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, FilteringProfileId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
