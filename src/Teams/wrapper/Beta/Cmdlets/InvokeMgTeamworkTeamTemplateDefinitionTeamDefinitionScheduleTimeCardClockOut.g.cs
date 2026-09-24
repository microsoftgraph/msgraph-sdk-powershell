#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/teamwork/teamTemplates/{teamTemplate-id}/definitions/{teamTemplateDefinition-id}/teamDefinition/schedule/timeCards/{timeCard-id}/clockOut")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgTeamworkTeamTemplateDefinitionTeamDefinitionScheduleTimeCardClockOut", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TimeCard))]
    public class InvokeMgTeamworkTeamTemplateDefinitionTeamDefinitionScheduleTimeCardClockOutCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamTemplateId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TeamTemplateDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TimeCardId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? AtApprovedLocation { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAtApprovedLocation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ItemBody? Notes { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TimeCardId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Teamwork.TeamTemplates.Item.Definitions.Item.TeamDefinition.Schedule.TimeCards.Item.ClockOut.ClockOutPostRequestBody();

    if (this.IsParameterBound(nameof(AtApprovedLocation)))
        body.AtApprovedLocation = AtApprovedLocation;

    if (this.IsParameterBound(nameof(IsAtApprovedLocation)))
        body.IsAtApprovedLocation = IsAtApprovedLocation;
    if (this.IsParameterBound(nameof(Notes)))
        body.Notes = Notes;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TimeCard? result;
            try
            {
                result = client.Teamwork.TeamTemplates[TeamTemplateId].Definitions[TeamTemplateDefinitionId].TeamDefinition.Schedule.TimeCards[TimeCardId].ClockOut.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TimeCardId);
                return;
            }

            WriteObject(result);
        }
    }
}
