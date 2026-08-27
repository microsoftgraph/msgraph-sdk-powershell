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
    [GraphRoute("POST", "/teams/{team-id}/schedule/dayNotes")]
    [Cmdlet(VerbsCommon.New, "MgTeamScheduleDayNote", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.DayNote))]
    public class NewMgTeamScheduleDayNoteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? DayNoteDate { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ItemBody? DraftDayNote { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ItemBody? SharedDayNote { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.DayNote();

    if (this.IsParameterBound(nameof(DayNoteDate)))
        body.DayNoteDate = DayNoteDate;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(DraftDayNote)))
        body.DraftDayNote = DraftDayNote;

    if (this.IsParameterBound(nameof(SharedDayNote)))
        body.SharedDayNote = SharedDayNote;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.DayNote? result;
            try
            {
                result = client.Teams[TeamId].Schedule.DayNotes.PostAsync(body, requestConfiguration =>
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
