#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Planner.Client;
using Microsoft.Graph.PowerShell.Planner.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Planner
{
    [GraphRoute("POST", "/users/{user-id}/planner/plans/{plannerPlan-id}/buckets")]
    [Cmdlet(VerbsCommon.New, "MgUserPlannerPlanBucket", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerBucket))]
    public class NewMgUserPlannerPlanBucketCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsArchived { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? OrderHint { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlanId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerArchivalInfo? ArchivalInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerBucketCreation? CreationSource { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerPlanId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerBucket();

    if (this.IsParameterBound(nameof(IsArchived)))
        body.IsArchived = IsArchived;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(OrderHint)))
        body.OrderHint = OrderHint;

    if (this.IsParameterBound(nameof(PlanId)))
        body.PlanId = PlanId;

    if (this.IsParameterBound(nameof(ArchivalInfo)))
        body.ArchivalInfo = ArchivalInfo;

    if (this.IsParameterBound(nameof(CreationSource)))
        body.CreationSource = CreationSource;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerBucket? result;
            try
            {
                result = client.Users[UserId].Planner.Plans[PlannerPlanId].Buckets.PostAsync(body, requestConfiguration =>
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
