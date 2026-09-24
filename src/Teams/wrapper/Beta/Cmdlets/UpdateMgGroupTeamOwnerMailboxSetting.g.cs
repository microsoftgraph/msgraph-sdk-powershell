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
    [GraphRoute("PATCH", "/groups/{group-id}/team/owners/{user-id}/mailboxSettings")]
    [Cmdlet(VerbsData.Update, "MgGroupTeamOwnerMailboxSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.MailboxSettings))]
    public class UpdateMgGroupTeamOwnerMailboxSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ArchiveFolder { get; set; }

        [Parameter(Mandatory = false)]
        public string? DateFormat { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeFormat { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeZone { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.AutomaticRepliesSetting? AutomaticRepliesSetting { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.DelegateMeetingMessageDeliveryOptions? DelegateMeetingMessageDeliveryOptions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.LocaleInfo? Language { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.UserPurpose? UserPurpose { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.MailboxRecipientType? UserPurposeV2 { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.WorkingHours? WorkingHours { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.MailboxSettings();

    if (this.IsParameterBound(nameof(ArchiveFolder)))
        body.ArchiveFolder = ArchiveFolder;

    if (this.IsParameterBound(nameof(DateFormat)))
        body.DateFormat = DateFormat;

    if (this.IsParameterBound(nameof(TimeFormat)))
        body.TimeFormat = TimeFormat;

    if (this.IsParameterBound(nameof(TimeZone)))
        body.TimeZone = TimeZone;

    if (this.IsParameterBound(nameof(AutomaticRepliesSetting)))
        body.AutomaticRepliesSetting = AutomaticRepliesSetting;

    if (this.IsParameterBound(nameof(DelegateMeetingMessageDeliveryOptions)))
        body.DelegateMeetingMessageDeliveryOptions = DelegateMeetingMessageDeliveryOptions;

    if (this.IsParameterBound(nameof(Language)))
        body.Language = Language;

    if (this.IsParameterBound(nameof(UserPurpose)))
        body.UserPurpose = UserPurpose;

    if (this.IsParameterBound(nameof(UserPurposeV2)))
        body.UserPurposeV2 = UserPurposeV2;

    if (this.IsParameterBound(nameof(WorkingHours)))
        body.WorkingHours = WorkingHours;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.MailboxSettings? result;
            try
            {
                result = client.Groups[GroupId].Team.Owners[UserId].MailboxSettings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Team.Owners[UserId].MailboxSettings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UserId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
